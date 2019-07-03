/* This class is designed to hold all the information needed to access a mySQL database in the background for a 
 * session. This includes the permission level of the user (currently Employee or Managerm based on the table)
 * it also holds the connection data, so that it is always the same.
 * 
 * each function that can retrieve or send data to the mySQL database deals with the connection internally
 * it opens and closes it to make sure there are no extra open connections floating around
 * 
 * a note on exceptions. 
 * 
 * Due to the limited time in the summer semester for putting together a project of this magnitude, I have
 * elected to go with a cheap and dirty exception method: just continue to throw the ex upward.
 * 
 * in the main program I handle catches with message boxes to display what went wrong. No, it is not ideal, 
 * and no it is not necessarily the best practice, but it works and gets the job done, plus
 * when I break something in the RDS I can see the message easier than having to make a console testbed for it.
 * 
 * Designed by: Anthony Goh (lynkfox on GitHub)
 * For: Columbus State Community College, CSCI-2999 capstone, su2019.
 */




/* TO DO LIST
 * 
 * More Detailed Exceptions (custom?)
 * 
 * perhaps change some bool functions to throw custom message if false.
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CcnSession.Properties;

namespace CcnSession
{
    public class SQL
    {
        //public properties - used to check permissions and defaults

        // Consider changing IsManager to an int? For more than just 2 levels of permission? Future proofing.
        static public bool IsManager { get; set; }
        static public bool PwCorrect { get; set; }
        static public string DefaultStore { get; set; }
        public static string Username { get; set; }
        public static bool CurEmp { get; set; }

        public static int LoggedInEmpNum { get; set; }


        //Private properties, variables

        // these remain private, as they are not really needed outside of the class

        private static string address, database, userid, password;

        private static MySqlConnectionStringBuilder cnnStr = new MySqlConnectionStringBuilder
        {
           
        };

        /* Public Functions */

        /* Housekeeping Functions
         * 
         * these functions are setup and cleanup of the static object
         */
        /* SQL.Setup(username, password) - No Overloads
         * 
         * Initializes session.
         * 
         * takes parameters of the username and the password
         * 
         * sets the Username inside the static object, to be used within various other functions used during
         * the session
         * 
         * sets the permission level (IsManager true/false)
         * 
         * checks to make sure the password is correct, sets a bool for later (so as not to store pw)
         * 
         * stores the DefaultStore string for use in the main program.
         * 
         * 
         * 
         * this should be called immediately after login, and ONLY after login. Never again.
         */

        static public void Setup(string user, string password)
        {

            try
            {
                SetupConnection();

                Console.WriteLine("CallingCheckUsername");
                if (CheckUsername(user))
                {
                    Username = user;
                } else
                {
                    throw new Exception("Those records do not match our database.");
                }






                Console.WriteLine("Calling ChkPassword");
                if (ChkPassword(password))
                {
                    PwCorrect = true;
                    Console.WriteLine("Calling Permission");
                    Permission();
                    Console.WriteLine("Calling GetStore");
                    DefaultStore = GetStore();
                    Console.WriteLine("Calling GetEmpNum");
                    LoggedInEmpNum = GetEmpNum(Username);
                }
                else
                {
                    IsManager = false;
                    CurEmp = false;
                    PwCorrect = false;
                    LoggedInEmpNum = 0;
                    throw new Exception("Those records do not match our database.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /* SQL.Cleanup() - No overloads.
         * 
         * Safety function. Cleans up the static class for logout (but not program exit). 
         * 
         * Needs to be called at every position that can log out. Setup **should** overwrite for a new user, but
         * its better to be safe and call this.
         * 
         */

        static public void Cleanup()
        {
            Username = null;
            PwCorrect = false;
            IsManager = false;
            DefaultStore = null;
            CurEmp = false;
            LoggedInEmpNum = 0;
        }

        /* User (Employee Database) functions
         * 
         * these functions are for creating, and updating new user entries in the employee database
         */

        /* SQL.ChkPassword(password) - No Overloads
         * 
         * Checks the password against the database, and returns true if valid, false if not.
         * 
         * to do - add exception handling.
         * 
         * Passwords are stored with a 24bit Hash and a 24bit salt. We will pull the salt and store
         * it in a string, then generate the hash from the inputed pw and the salt, comparing that to the hash
         * (without ever storing it in a variable of its own other than the reader).
         */
        public static bool ChkPassword(string pw)
        {

            try
            {
                byte[] salt;
                string hash;
                var saltData = new DataTable();
                var hashData = new DataTable();
                Console.WriteLine("Getting Salt.");
                saltData = GetColumn("employee", "salt", "username", Username);

                Console.WriteLine("Getting Hash.");
                hashData = GetColumn("employee", "password", "username", Username);

                salt = Convert.FromBase64String(saltData.Rows[0]["salt"].ToString());
                hash = hashData.Rows[0]["password"].ToString();

                if (hash == Convert.ToBase64String(PasswordHash.ComputeHash(pw, salt)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                throw ex;
            }
            

        }

        /* SQL.CreateUser(fname, lname, desiredPW) - no overloads
         * 
         * CreateUser takes the employees first and last name and desired pw.
         * 
         * will automatically generate a unique username (first initial, last name + numbers as needed)
         * 
         * will generate a salt for the pw, and store the salt and the resulting hash in the database, along with the firstname/lastname
         * username. Additional information will need to be stored by other means
         * 
         * returns the generated username as a string.
         * 
         * 
         * if this errors out in some way, it will should return null - check when using that username !null.
         */

        public static string CreateUser(string fName, string lName, string pw)
        {

            

            // automatically create the username as first initial, last name - all lowercase
            string username = fName[0] + lName;
            username = username.ToLower();

            /* if there happen to be 2 people with the same first initial/last name combo
             * then this section will add a number to the end of the username.
             */

            int i = 1;

            while (CheckUsername(username))
            {

                if (i > 1 && i < 10)
                {
                    /* if there happen to be more than 2 people with the same first initial, last name
                     * then we remove the 1 (the last char fo the string) and add the new incrimimented i
                     * to the username (so username2, then username3, ect)
                     */
                    username = username.Substring(0, username.Length - 1);
                }
                else if (i >= 10)
                {
                    /* Let's be real here. If there are more than 10 people with the exact same first
                     * initial and last name, there there is either nepotism or something very weird going on
                     * but just in case, we're removing 2 numbers if it gets above 10 for i.
                     * 
                     * we're not going to check for 3 numbers. Something is messed up, contact IT
                     */
                    username = username.Substring(0, username.Length - 2);
                }
                username += i; // add the iteration number (starting at 1!!!) to the end of the preset username.
                i++;
            }

            //Generate the salt and the hash
            var passwordSalt = PasswordHash.GenerateSalt();
            var passwordHash = PasswordHash.ComputeHash(pw, passwordSalt);

            //convert the hash and salt to a string for database storage
            string saltString = Convert.ToBase64String(passwordSalt);
            string hashString = Convert.ToBase64String(passwordHash);

            //setup the sql string for insertion

            try
            {
                var cmd = new MySqlCommand
                {
                    CommandText = "INSERT INTO employee (first_name, last_name, username, password, salt, hired, location) VALUES(@first_name, @last_name, @username, @password, @salt, @hired, @location)"
                };
                cmd.Parameters.AddWithValue("@first_name", fName);
                cmd.Parameters.AddWithValue("@last_name", lName);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashString);
                cmd.Parameters.AddWithValue("@salt", saltString);
                //cmd.Parameters.AddWithValue("@hired", today);
                cmd.Parameters.Add("@hired", MySqlDbType.Timestamp).Value = DateTime.Now;
                cmd.Parameters.AddWithValue("@location", DefaultStore);


                //string sql = "INSERT INTO employee (first_name, last_name, username, password, salt, hired, location) VALUES ('" + fName + "','" + lName + "','" + username + "','" + hashString + "','" + saltString + "','" + today + "', '" + DefaultStore + "')";

                if (SendQry(cmd))
                {
                    return username;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

        /* SQL.CheckUsername(username) - no overloads
         * 
         * returns bool if username exists (good for creating new user to prevent duplicate usernames and error in the
         * sql insert or to make sure the username exists before calling the database for the passwordhash
         */
        public static bool CheckUsername(string username)
        {
            try
            {
                if (GetColumn("employee", "username", username).Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /* SQL.ChangePassword(newPW) - no overloads
         * 
         * Method for changing the pw in the database.
         * 
         * Pulls the username from the current session. Overloaded version takes a username as a second argument.
         * 
         * Note. This method JUST changes the pw (and the hash and the salt, of course).
         * 
         * Be sure to ChkPassword BEFORE calling this function.
         * 
         * returns true if successful, false if not.
         */

        public static bool ChangePassword(string newPW)
        {
            var salt = PasswordHash.GenerateSalt();
            var hash = PasswordHash.ComputeHash(newPW, salt);

            string saltString = Convert.ToBase64String(salt);
            string hashString = Convert.ToBase64String(hash);

            //if the PWs are the same, then we don't want to change it!

            // really needs exception handling here.
            if (ChkPassword(newPW))
            { return false; }

            var cmd = new MySqlCommand()
            {
                CommandText = "UPDATE employee SET password = @hash, salt = @salt WHERE username = @username;"
            }  ;

            cmd.Parameters.AddWithValue("@hash", hashString);
            cmd.Parameters.AddWithValue("@salt", saltString);
            cmd.Parameters.AddWithValue("@username", Username);



            //string sql = "UPDATE employee SET password = '" + hashString + "', salt = '" + saltString + "' WHERE username = '" + Username + "';";

            if (SendQry(cmd))
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        /* SQL.GetEmpNumber(username)
         * 
         * returns an employee number. 
         * 
         * important because for safety reasons (to prevent errors or miss data) we use the emp number for all
         * update and modification functions. The empNum is the Primary Key in the database, unique, and so much
         * less trouble than possibly mispelling usernames.
         *
         * 
         */

        public static int GetEmpNum(string user)
        {
            try
            {
                int.TryParse(GetColumn("employee", "emp_num", "username", user).Rows[0]["emp_num"].ToString(), out int empNum);

                
                if (empNum ==0)
                {
                    throw new Exception("No employee found.");
                } else
                {
                    return empNum;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

        public static void UpdateFname(int empNum, string fname)
        {
            
            try
            {

                var cmd = new MySqlCommand()
                {
                    CommandText = "UPDATE employee SET first_name = @fname WHERE emp_num = @empNum;"
                };
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@empNum", empNum);


                //string sql = "UPDATE employee SET first_name = '" + fname + "' WHERE emp_num = '" + empNum + "';";
                SendQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateLname(int empNum, string lname)
        {
            
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "UPDATE employee SET last_name = @lname WHERE emp_num = @empNum;"
                };
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@empNum", empNum);


                //string sql = "UPDATE employee SET last_name = '" + lname + "' WHERE emp_num = '" + empNum + "';";
                SendQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateStreet(int empNum, string street)
        {
            
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "UPDATE employee SET street = @street WHERE emp_num = @empNum;"
                };

                cmd.Parameters.AddWithValue("@street", street);
                cmd.Parameters.AddWithValue("@empNum", empNum);

                //string sql = "UPDATE employee SET street = '" + street + "' WHERE emp_num = '" + empNum + "';";
                SendQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateCity(int empNum, string city)
        {
            
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "UPDATE employee SET city = @city WHERE emp_num = @empNum;"
                };

                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@empNum", empNum);

                //string sql = "UPDATE employee SET city = '" + city + "' WHERE emp_num = '" + empNum + "';";
                SendQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateState(int empNum, string st)
        {
            
            try
            {
                var cmd = new MySqlCommand()
                { CommandText= "UPDATE employee SET state = @state WHERE emp_num = @empNum; "

                };
                cmd.Parameters.AddWithValue("@state", st);
                cmd.Parameters.AddWithValue("@empNum", empNum);

                //string sql = "UPDATE employee SET state = '" + st + "' WHERE emp_num = '" + empNum + "';";
                SendQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateZip(int empNum, int zip)
        {
           
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "UPDATE employee SET zip = @zip WHERE emp_num = @empNum;"
                };
                cmd.Parameters.AddWithValue("@zip", zip);
                cmd.Parameters.AddWithValue("@empNum", empNum);

                //string sql = "UPDATE employee SET zip = '" + zip + "' WHERE emp_num = '" + empNum + "';";
                SendQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Promote(int empNum)
        {
            
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "UPDATE employee SET type = 'Manager' WHERE emp_num = @empNum;"
                };
                cmd.Parameters.AddWithValue("@empNum", empNum);

               // string sql = "UPDATE employee SET type = 'Manager' WHERE emp_num = '" + empNum + "';";
                SendQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Demote(int empNum)
        {
            
            try
            {
                var cmd = new MySqlCommand()
                { CommandText = "UPDATE employee SET type = 'Employee' WHERE emp_num = @empNum;" };

                cmd.Parameters.AddWithValue("@empNum", empNum);

                //string sql = "UPDATE employee SET type = 'Employee' WHERE emp_num = '" + empNum + "';";
                SendQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Changestore(int empNum, string store)
        {
            
            try
            {
                var cmd = new MySqlCommand()
                { CommandText = "UPDATE employee SET location = @store WHERE emp_num = @empNum;" };

                cmd.Parameters.AddWithValue("@store", store);
                cmd.Parameters.AddWithValue("@empNum", empNum);
                   
                //string sql = "UPDATE employee SET location = '" + store + "' WHERE emp_num = '" + empNum + "';";
                SendQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ChangePay(int empNum, double newPay)
        {
            
            try
            {
                var cmd = new MySqlCommand()
                { CommandText= "UPDATE employee SET pay = @newPay WHERE emp_num = @empNum;"
            };
                cmd.Parameters.AddWithValue("@newPay", newPay);
                cmd.Parameters.AddWithValue("@empNum", empNum);


                //string sql = "UPDATE employee SET pay = '" + newPay + "' WHERE emp_num = '" + empNum + "';";
                SendQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Terminate(int empNum)
        {
            
            
            try
            {
                /*
                var cmd = new MySqlCommand
                {
                    CommandText = "UPDATE `employee` SET `type` = 'Terminated', `terminated` = NOW() WHERE (`emp_num` = @empNum);"
                };
                cmd.Parameters.AddWithValue("@empNum", empNum);
                */

                /* This is ... not proper, but not to bad.
                 * we are not taking directly the empNum from a user.  empNumber is derived from other commands, and therefore can't be altered by
                 * an SQL injection attack.
                 * 
                 * Given that I was having trouble getting NOW() to work with the MySqlCommand paramaters, this seemed to work just fine.
                 */

                string sql = "UPDATE `employee` SET `type` = 'Terminated', `terminated` = NOW() WHERE(`emp_num` = " + empNum + ");";
                SendQry(new MySqlCommand(sql));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetEmployee(int empNum)
        {
            
            try
            {
                var data = GetTable("employee", "emp_num", empNum.ToString());
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /* Order Database Functions
         * 
         * these functions all have to do with retrieving and viewing orders
         * 
         */


        /* SQL.GetOrders( ... several overloads)
         * 
         * at its basic returns orders for the default store of the user.
         * 
         * overloads can return for a different store, or for specific customers, or even specific orders
         */


            /*Default version - defaults to ALL orders from USERS DEFAULT STORE
             * 
             */
        public static DataTable GetOrders()
        {
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT acct_num, del_addy, trans_date, del_date, total, pay_rec, order_status, order_num  FROM order_history WHERE location = @store ORDER BY del_date DESC;"
                };

                cmd.Parameters.AddWithValue("@store", DefaultStore);

                //string sql = "SELECT acct_num, del_addy, trans_date, del_date, total, pay_rec, order_status, order_num  FROM order_history WHERE location = '" + DefaultStore + "' ORDER BY del_date DESC;";
                return SelectQry(cmd);
            } catch (Exception ex)
            {
                throw ex;
            }
            

        }

        /* Overload 1 - Allows to select ALL orders from a SPECIFIC STORE
         */
        public static DataTable GetOrders(string store)
        {
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT acct_num, del_addy, trans_date, del_date, pay_rec, total, order_status, order_num FROM order_history WHERE location = @store ORDER BY del_date DESC;"
                };

                cmd.Parameters.AddWithValue("@store", store);

                
                //string sql = "SELECT acct_num, del_addy, trans_date, del_date, pay_rec, total, order_status, order_num FROM order_history WHERE location = '" + store + "' ORDER BY del_date DESC;";
                return SelectQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            


        }

        /* Overload 2 - All of a single users orders (by email address) from a specific store
         */
        public static DataTable GetOrders(string store, string email)
        {
            try
            {
                string acctNum = GetAcctNum(email).ToString();
                int.TryParse(acctNum, out int custNum);

                return GetOrders(store, custNum);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            


        }

        /* Overload 3 ALL of a users orders (by acct_num) in ANY store
         */
        public static DataTable GetOrders(int custNum)
        {

            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT acct_num, del_addy, trans_date, del_date, total, pay_rec, order_status, order_num FROM order_history WHERE acct_num = @acctNum ORDER BY del_date DESC;"
                };

                cmd.Parameters.AddWithValue("@acctNum", custNum);

                //string sql = "SELECT acct_num, del_addy, trans_date, del_date, total, pay_rec, order_status, order_num FROM order_history WHERE acct_num = '" + custNum + "'ORDER BY del_date DESC;";
                return SelectQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /* Overload 4 - returns all of a customers orders at a specific store, searched by cust num (called in the one searched by email)
         */
        public static DataTable GetOrders(string store, int custNum)
        {
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT acct_num, del_addy, trans_date, del_date, total, pay_rec, order_status, order_num FROM order_history WHERE location = @store AND acct_num = @custNum ORDER BY del_date DESC;"
                };

                cmd.Parameters.AddWithValue("@store", store);
                cmd.Parameters.AddWithValue("@custNum", custNum);
                
                //string sql = "SELECT acct_num, del_addy, trans_date, del_date, total, pay_rec, order_status, order_num FROM order_history WHERE location = '" + store + "' AND acct_num = '"+custNum+ "'ORDER BY del_date DESC;";
                return SelectQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /* Overload 5  - all of a customers order, for a specific store, after a certain date
         */
        public static DataTable GetOrders(string store, int custNum, DateTime date)
        {
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT acct_num, del_addy, trans_date, del_date, total, pay_rec, order_status, order_num FROM order_history WHERE DATE(trans_date) > @date AND  location = @store AND acct_num = @custNum ORDER BY del_date DESC;"
                };
                cmd.Parameters.AddWithValue("@custNum", custNum);
                cmd.Parameters.AddWithValue("@store", store);
                cmd.Parameters.Add("@date", MySqlDbType.Timestamp).Value = date;

                //string sql = "SELECT acct_num, del_addy, trans_date, del_date, total, pay_rec, order_status, order_num FROM order_history WHERE DATE(trans_date) > '@date' AND  location = '" + store + "' AND acct_num = '" + custNum + "' ORDER BY del_date DESC;";

                return SelectQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /* GetOrderItems(ordernum) - no overloads - for pulling up the items from an order to the new window.
         * 
         * for retrieving the line items out of the order_items database.
         * 
         * only used in the GetOrder functions - no use for just the line items without the additional
         * order information in the order_history database
         * 
         */

        public static DataTable GetOrderItems(int orderNum)
        {

            try
            {
                var cmd = new MySqlCommand()
                { CommandText = "SELECT h.order_num, v.item_name, i.qty, h.total, h.pay_rec, h.del_date, h.order_status, h.del_addy, h.emp_num FROM order_history h JOIN order_items i ON i.order_num = h.order_num AND h.order_num = @orderNum JOIN items v ON v.item_id = i.item_id ORDER by h.order_num"
                 };

                cmd.Parameters.AddWithValue("@orderNum", orderNum);
                //string sql = "SELECT h.order_num, v.item_name, i.qty, h.total, h.pay_rec, h.del_date, h.order_status, h.del_addy FROM order_history h JOIN order_items i ON i.order_num = h.order_num AND h.order_num = "+orderNum+" JOIN items v ON v.item_id = i.item_id ORDER by h.order_num";

                return SelectQry(cmd);
            } catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /*
         * valid status:
         * 
         * Ordered, Recieved, Processed, Out for Delivery, Delivered, Canceled
         * 
         * Paid, Not Paid
         */
        public static void ChangeStatus(int orderNum, string status)
        {
            try
            {
                
                
                    var cmd = new MySqlCommand()
                    {
                        CommandText = "UPDATE order_history SET order_status = @status, emp_num=@empNum WHERE order_num = @orderNum;"
                    };

                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@orderNum", orderNum);
                    cmd.Parameters.AddWithValue("@empNum", LoggedInEmpNum);

                    SendQry(cmd);
                
                

            } catch(Exception ex)
            {
                throw ex;
            }
            

        }

        public static void ChangeStatus(int orderNum, int empNum)
        {
            if(empNum == 0)
            {
                //order number is not user inputed on the top app, so this is a safe string.
                //this is if a user is unclaiming the order, so emp_num is set back to 0.
                string sql = "UPDATE order_history SET order_status = 'Received', emp_num='0' WHERE order_num = " + orderNum + ";";
                SendQry(sql);
            } else
            {
                //order number is not user inputed on the top app, so this is a safe string.
                // the empNum is generated from a username or firstname, and not directly entered by the user so not a problem for SQL injection attacks either.
                string sql = "UPDATE order_history SET order_status = 'Received', emp_num="+empNum+" WHERE order_num = " + orderNum + ";";
                SendQry(sql);
            }
            
        }

        public static void ChangeDate(int orderNum, string date)
        {

        }

        public static void ChangeDelAddy(int orderNum, string address)
        {

        }

        public static void AddItem(int orderNum, int itemNum, int qty)
        {

        }

        public static void AdjustQty(int orderNum, int itemNum, int qty)
        {

        }

        public static int GetAcctNum(string email)
        {
            try
            {
                int.TryParse(GetColumn("customer", "acct_num", "email", email).Rows[0]["acct_num"].ToString(), out int acctNum);


                if (acctNum == 0)
                {
                    throw new Exception("No employee found.");
                }
                else
                {
                    return acctNum;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int GetAcctNum(string fName, string lName)
        {
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT acct_num FROM customer WHERE first_name =@name AND last_name = @lname;"
                };

                cmd.Parameters.AddWithValue("@fname", fName);
                cmd.Parameters.AddWithValue("@lname", lName);

                //string sql = "SELECT acct_num FROM customer WHERE first_name ='" + fName + "' AND last_name = '" + lName + "';";
                int.TryParse(SelectQry(cmd).Rows[0]["acct_num"].ToString(), out int acctNum);


                if (acctNum == 0)
                {
                    throw new Exception("No employee found.");
                }
                else
                {
                    return acctNum;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* Store Inventory Functions
         * 
         * these functions deal with the inventory database. 
         * 
         * they DO NOT deal with the item database - that stuff is NOT adjusted by the store app
         * and at this point is to be dealt with by HQ when new items are brought to sale.
         * 
         */

        /* SQL.GetInventory( ... several overloads)
         * 
         * at its basic returns orders for the default store of the user.
         * 
         * overloads can return for a different store, or for specific items
         */
        public static DataTable GetInventory()
        {
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT items.item, items.item_name, items.purchase_cost, items.sell_cost, items.category, store_inventory.qty FROM items  INNER JOIN store_inventory WHERE store_inventory.item_id = items.item_id AND location = @store; "
                };
                cmd.Parameters.AddWithValue("@store", DefaultStore);

                return SelectQry(cmd);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            


           

        }

        public static DataTable GetInventory(string store)
        {
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT items.item, items.item_name, items.purchase_cost, items.sell_cost, items.category, store_inventory.qty FROM items  INNER JOIN store_inventory WHERE store_inventory.item_id = items.item_id AND location = @store; "
                };

                cmd.Parameters.AddWithValue("@store", store);

                return SelectQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            


        }

        public static DataTable GetInventory(string store, int itemNum)
        {
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT items.item, items.item_name, items.purchase_cost, items.sell_cost, items.category, store_inventory.qty FROM items  INNER JOIN store_inventory WHERE store_inventory.item_id = items.item_id AND location = @store AND items.item_id = @itemNum; "
                };
                cmd.Parameters.AddWithValue("@store", store);
                cmd.Parameters.AddWithValue("@itemNum", itemNum);
                
                return SelectQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            

        }

        public static int GetItemId(string itemName)
        {
            try
            {
                var data = new DataTable();

                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT item_id FROM items WHERE item_name =@itemName;"
                };

                cmd.Parameters.AddWithValue("@itemName", itemName);

                //string sql = "SELECT item_id FROM items WHERE item_name ='" + itemName + "';";
                try
                {
                    data = SelectQry(cmd);
                }
                catch 
                {
                    throw new Exception("No item found with that name");
                }
                int.TryParse(data.Rows[0]["item_id"].ToString(), out int item_id);

                return item_id;
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        /* SQL.ChangeQty(itemNum, qty)
         * 
         * this updates the item qty at the store - positive or negative - and spits out an error message if the
         * item is going to go negative.
         * 
         * autmatically uses the users default store. CANNOT MODIFY OTHER STORES INVENTORY
         */
        public static void ChangeQty(int itemNum, int qty)
        {

            var cmd = new MySqlCommand()
            {
                CommandText = "UPDATE store_inventory SET qty = @qty WHERE item_id=@itemNum AND location = @store;"
            };

            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@itemNum", itemNum);
            cmd.Parameters.AddWithValue("@store", DefaultStore);


           //string sql= "UPDATE store_inventory SET qty = '"+qty+"' WHERE item_id='"+itemNum+"' AND location = '"+DefaultStore+"';";
           
            try
            {
                if (SendQry(cmd))
                {
                    Console.WriteLine("Command sent, Qty Updated.");
                }
            } catch (Exception ex)
            {
                throw ex;
            }

        }

        /* SQL.ItemChgStore(itemNum, store, amount)
         * 
         * moves an amount of item from default store to new store
         * 
         */

        public static void ItemChgStore(int itemName, string store, int amt)
        {

        }



        /* Accounting methods
         * 
         * these methods handle the Accts Rec, Accts Payable, and basic financial reporting tools for the
         * default store. They ONLY affect the default store, and cannot be used to see other stores information
         */

        /*SQL.GetAcRec(... several overloads
         * 
         * this method retrieves the accounts recievables for the store, or a specific one, or a specific users)
         */
        public static DataTable GetAcRec()
        {
            var data = new DataTable();


            return data;

        }

        /* valid types are invoice and account
         */
        public static DataTable GetAcRec(int idNum, string type)
        {
            var data = new DataTable();


            return data;

        }

        public static DataTable GetAcRec(string startDate, string endDate)
        {
            var data = new DataTable();


            return data;

        }

        public static int AmtOwed(int invoiceNum)
        {
            int owed = 0;
            return owed;
        }

        public static void AddPay(int invoiceNum, int pmt)
        {

        }

        public static void NewAcRec(int acctNum, int orderNum, int owed)
        {

        }

        public static DataTable AcctPay()
        {
            var data = new DataTable();


            return data;

        }

        public static DataTable AcctPay(int id)
        {
            var data = new DataTable();


            return data;

        }

        public static DataTable AcctPay(string vendor, int invoiceNum)
        {
            var data = new DataTable();


            return data;

        }

        public static DataTable AcctPay(string vendor)
        {
            var data = new DataTable();


            return data;

        }

        public static DataTable AcctPay(string startDate, string endDate)
        {
            var data = new DataTable();


            return data;

        }

        public static int AcctPayOwed(int id)
        {
            int owed = 0;
            return owed;
        }

        public static int AcctPayOwed(string vendor, int invoiceNum)
        {
            int owed = 0;
            return owed;
        }

        public static void AcctPayPmt(string vendor, int invoiceNum, int pmt)
        {

        }

        /* still Accounting Methods - but these are the Report Generation Methods
         * 
         * again - these all only deal with the current store of the logged in manager.
         * 
         * this information can be provided to corporate account department for corporate level reports
         */

        public static DataTable GeneralLedger()
        {
            var data = new DataTable();


            return data;

        }

        public static DataTable ProfitReport()
        {
            var data = new DataTable();


            return data;

        }

        public static DataTable LossReport()
        {
            var data = new DataTable();


            return data;

        }

        public static DataTable CashReport()
        {
            var data = new DataTable();


            return data;

        }

        public static void RunReports()
        {

        }









        /*Private Internal Functions */

        /* GetStore() - no overloads - private - internal use Only
         * 
         * used to get the store of the logged in account.
         */

        private static string GetStore()
        {
            try
            {
                var data = new DataTable();
                data = GetColumn("employee", "location", "username", Username);

                string store = data.Rows[0]["location"].ToString();
                return store;

            } catch (Exception ex)
            {
                throw ex;
            }
            
        }
        
        /* SetupConnection() - Internal, Private, No Overloads
         * 
         * This function reads in the connection data from the file in the resources and adds its information to the 
         * properties needed for the connection builder.
         * 
         * to do: encrypt and decrypt the file for additional protection
         */

        private static void SetupConnection()
        {

            string[] rows = Resources.connection.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            /* I acknowledge this is a dirty way to do this. There is no error checking to make sure that the
             * file is in the correct order, nor is it a deliniated list. This is fast and effective for the moment
             * mostly being used as a current method until I figure out how to use the config file properly.:/
             */
            address = rows[0];
            database = rows[1];
            userid = rows[2];
            password = rows[3];
            

            MySqlConnectionStringBuilder cnn = new MySqlConnectionStringBuilder
            {

                Server = address,
                Database = database,
                UserID = userid,
                Password = password,
                Port = 3306,
                AllowZeroDateTime = true

            };

            cnnStr = cnn;
        }

        /* Permission() - No Overloads - Private - Internal use Only
         * 
         * This function can be used to determine if the current employee has permission to access
         * whatever it is being asked of. 
         * 
         * checks the password
         * 
         * checks for if the user has the Manager access level, and sets appropriately.
         * 
         * 
         * 
         * This may change in the future.
         */
        private static void Permission()
        {

            var cmd = new MySqlCommand()
            {
                CommandText = "SELECT type FROM employee WHERE username = @user;"
            };

            cmd.Parameters.AddWithValue("@user", Username);

            //string sql = "SELECT type FROM employee WHERE username = '" + Username + "';";
            MySqlDataReader rdr = null;
            int i = 0;

            using (var cnn = new MySqlConnection(cnnStr.ConnectionString))
            {
                try
                {
                    cmd.Connection = cnn;
                    cnn.Open();

                    Console.WriteLine("Connection:  {0}", cnn.State);
                    Console.WriteLine("Sending Command: {0}", cmd);

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Console.WriteLine("Checking Data. Username: " + Username + " | AcctType: " + rdr.GetString(i));
                        i++;
                        // this bit is just in case the command somehow draws back more than one username of the same name. 
                        // the username col in this table is set to unique, so this shouldn't happen. 
                        // unless - where the username is similar like: abcd and abcde - 
                        // check into this!!!!


                        if (rdr.GetString(0) == "Manager")
                        {

                            IsManager = true;
                            CurEmp = true;

                        } else if (rdr.GetString(0) == "Terminated")
                        {
                            CurEmp = false;
                            IsManager = false;
                        }
                        else
                        {
                            IsManager = false;
                            CurEmp = true;
                        }
                        



                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                    throw ex;
                }
                finally
                {
                    if (cnn != null) cnn.Close();
                }



            }


        }







        /* Generic SQL functions to Follow
         * 
         * The goal is to not use these functions outside of the class. Because these are some of the generic connection
         * types were going to need over and over, then they are functions. 
         * 
         *
         * 
         * they are available for public use for edge cases however
         */


        /* SQL.GetTable(... Multiple overloads)
         * 
         * This function is designed to get any table from the connection.
         * 
         * Overloaded version can order the table by a custom ORDER BY
         * 
         * Overloaded version can be ordered by, where col = value
         * 
         * Both functions return NULL data if they catch an exception, and log it to the console
         * 
         * in live, check for Null when using these functions, if return null then throw an error.
         * 
         * does where val does not currently work with BETWEEN
         * 
         * some of these  use what appears to be vulnerable to an SQL Injection attack. Due to the nature in which we
         * are using them in the app, they are actually secure - for most only the "Search" value (where = value)" is
         * entered by the user. Everything else is predetermined.
         */
        static public DataTable GetTable(string tableName)
        {
            try
            {
                string sql = "SELECT * FROM " + tableName;
                return SelectQry(sql);
            } catch (Exception ex)
            {
                throw ex;
            }
            


        }
        static public DataTable GetTable(string tableName, string orderBy)
        {
            try
            {
                string sql = "SELECT * FROM " + tableName + "ORDER BY" + orderBy + ";";
                return SelectQry(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        static public DataTable GetTable(string tableName, string whCol, string whVal)
        {
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT * FROM "+tableName+" WHERE "+whCol+" = @value;"
                };

                
                cmd.Parameters.AddWithValue("@value", whVal);

                //string sql = "SELECT * FROM " + tableName + " WHERE " + whCol + "=" + whVal + ";";
                return SelectQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /* same as GetTable, except takes the table name and the column name as arguments, and only returns
         * that single column
         * 
         * single overload with a third string, WHERE query
         * 
         * session.GetColumn(tablename, columnName, valueOfCol)
         * 
         * session.GetColumn(ACCT_REC, acct_num, "10003")
         * 
         * does not currently work with BETWEEN query (tho you could jury rig it with
         * FROM table BETWEEN value=start, value=end; as one string in the tableName.
         * 
         * don't do this. just use sendqry instead.
         * 
         * some of these  use what appears to be vulnerable to an SQL Injection attack. Due to the nature in which we
         * are using them in the app, they are actually secure - for most only the "Search" value (where = value)" is
         * entered by the user. Everything else is predetermined.
         */
        static public DataTable GetColumn(string tableName, string colName)
        {
            try
            {
                string sql = "SELECT " + colName + " FROM " + tableName + ";";
                return SelectQry(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            


        }
        static public DataTable GetColumn(string tableName, string colName, string whereVal)
        {
            try
            {
                var cmd = new MySqlCommand()
                {
                    CommandText = "SELECT "+colName+" FROM "+tableName+" WHERE "+colName+"= @value ;"
                };

                
                cmd.Parameters.AddWithValue("@value", whereVal);
                //string sql = "SELECT " + colName + " FROM " + tableName + " WHERE " + colName + "= '" + whereVal + "' ;";
                return SelectQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            


        }

        static public DataTable GetColumn(string tableName, string colName, string whereCol, string whereVal)
        {
            try
            {
                string sql = "SELECT " + colName + " FROM " + tableName + " WHERE " + whereCol + "=@value ;";
                var cmd = new MySqlCommand()
                {
                    CommandText = sql
                };

                cmd.Parameters.AddWithValue("@value", whereVal);
                
                return SelectQry(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

        /* SendQry(2 overloads)
         * 
         * 
         * For Executing non table getting queries (INSERT, ALTER, UPDATE)
         * 
         * takes a string, and puts it into a MySqlCommand 
         * 
         * or
         *
         * takes a MySqlCommand - built with the MySqlCommand.CommandText functions
         * 
         * using something like:
         * 
         *          cmd.CommandText = "INSERT INTO testTable(ID, FIRST_NAME, LAST_NAME, EMAIL) VALUES(?ID, ?FIRST_NAME, ?LAST_NAME, ?EMAIL)";
                    cmd.Parameters.Add("?ID", MySqlDbType.Int32).Value = ID;
                    cmd.Parameters.Add("?FIRST_NAME", MySqlDbType.Text).Value = firstName;
                    cmd.Parameters.Add("?LAST_NAME", MySqlDbType.Text).Value = lastName;
                    cmd.Parameters.Add("?EMAIL", MySqlDbType.Text).Value = email;

            * Alternatively, it the  SQL Query to be sent does not need to be rebuilt like this often,
            * simply store it as a string.
            * 
            *       cmd.CommandText+"INSERT INTO Customer(" +id + firstName + lastName + email+ ")";

            returns a boolean, of True if the command is successful (ie, returns more than 0 rows), or false
            if the command is not successful (returns 0 rows)
         */
        static public bool SendQry(MySqlCommand cmd)
        {

            using (var cnn = new MySqlConnection(cnnStr.ConnectionString))
            {

                try
                {


                    //logging
                    Console.WriteLine("Connecting... ");

                    // assigns the connection to the command, so when executeNonQry fires it knows what connection to use
                    cmd.Connection = cnn;
                    cnn.Open();

                    //logging
                    Console.WriteLine("Connection:  {0}", cnn.State);
                    Console.WriteLine("Sending Command: {0}", cmd.ToString()) ;

                    //Sends the command, as defined by the string builder externally.
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    //mostly for debugging at this point.
                    Console.WriteLine("Error: {0}", ex.Message);
                    throw ex;
                }
                finally
                {
                    if (cnn != null) cnn.Close();
                }

            }

        }

        static public bool SendQry(string sql)
        {

            using (var cnn = new MySqlConnection(cnnStr.ConnectionString))
            {

                try
                {


                    //logging
                    Console.WriteLine("Connecting... ");

                    // assigns the connection to the command, so when executeNonQry fires it knows what connection to use
                    var cmd = new MySqlCommand(sql, cnn);
                    cnn.Open();

                    //logging
                    Console.WriteLine("Connection:  {0}", cnn.State);
                    Console.WriteLine("Sending Command: {0}", cmd);

                    //Sends the command, as defined by the string builder externally.
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    //mostly for debugging at this point.
                    Console.WriteLine("Error: {0}", ex.Message);
                    throw ex;
                }
                finally
                {
                    if (cnn != null) cnn.Close();
                }

            }

        }


        /* SelectQry( ... 2 overloads
         * 
         * this is the most basic function here, returns a datatable from a Select string.
         * 
         * all GetTable and GetColumn functions use it, they just build the string for you
         * 
         * this is public in case need something that doesn't fit in the GetTable, GetColumn overloads
         */


        static public DataTable SelectQry(MySqlCommand cmd)
        {
            var tableData = new DataTable();
            using (var cnn = new MySqlConnection(cnnStr.ConnectionString))
            {

                try
                {


                    //logging
                    Console.WriteLine("Connecting... ");

                    cmd.Connection = cnn;
                    cnn.Open();
                    //logging
                    Console.WriteLine("Connection:  {0}", cnn.State);
                    Console.WriteLine("Sending Command: {0}", cmd.CommandText);

                    using (MySqlDataAdapter data = new MySqlDataAdapter(cmd))
                    {
                        data.Fill(tableData);
                    }

                    return tableData;
                }
                catch (Exception ex)
                {
                    //mostly for debugging at this point.
                    Console.WriteLine("Error: {0}", ex.Message);
                    throw ex;
                }
                finally
                {
                    if (cnn != null) cnn.Close();
                }

            }
        }

        static public DataTable SelectQry(string sql)
        {
            var tableData = new DataTable();
            using (var cnn = new MySqlConnection(cnnStr.ConnectionString))
            {

                try
                {
                    

                    //logging
                    Console.WriteLine("Connecting... ");

                    var cmd = new MySqlCommand(sql, cnn);
                    cnn.Open();
                    //logging
                    Console.WriteLine("Connection:  {0}", cnn.State);
                    Console.WriteLine("Sending Command: {0}", sql);

                    using (MySqlDataAdapter data = new MySqlDataAdapter(cmd))
                    {
                        data.Fill(tableData);
                    }

                    return tableData;
                }
                catch (Exception ex)
                {
                    //mostly for debugging at this point.
                    Console.WriteLine("Error: {0}", ex.Message);
                    throw ex;
                }
                finally
                {
                    if (cnn != null) cnn.Close();
                }

            }
        }

    }



}

