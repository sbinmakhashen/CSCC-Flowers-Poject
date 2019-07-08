# TO DO for Salem

## High Priority
* ~~Make the Change Password link on the main screen clearer, better~~
* ~~Make the ChangePW form look good~~
* ~~Make the OrderDetails form (double click on any order in the OrderHistory page to get there) look good~~

## Medium Priority
* ~~Make it so that any changes in the Update Empoyee fields are highlighted in red.~~

## Low Priority
* Help Oussama write up something for the website for the document
* Get Screenshots of all the windows (clean, no other stuff in the background) so we can make training documentation

## VERY low Priority
* ~~See what Error Message Boxes we can move into the form itself (maybe as a hover box of some sort?) rather than as a click button error.~~
~~+ for example: bad zip code - does it have to be a click through MessageBox.Show? Can we do something else? (maybe a label pop up in red saying its a bad zip?)~~

**To answer your question the only other error method we can use instead of an error message box is the "Error Provider" method after adding this feature to the form itself it will show an error icon next to any problem and you'd have to point the mouse to the red flag or icon to read the error, if your interested lemme know!!!**


# TO DO for Anthony

## High Priority
* ~~Get the Search on Order History by Date to work.~~ done, and working very well.
* Accounting - ~~Acct Rec and Acct Payable~~ - Can view
+ CRUD operations for Managers
* Reports - Ledgers and what not.

## Medium Priority
* Additional employee level. HR
+ Change other employees PWs, update employee information.

* Table design for PW changes 
+ Time Changed
+ previous pw hash
+ previous pw salt
+ emp_num (fkey)
* method to check
+ check if any hash matches
+ if matched, check if more at least 23 rows before end (last row -23? find last row number from the foreach check of hash/salt?)



## Low Priority
* When Set Processed button on OrderDetails pressed, auto deduct qty from inventory.
* if changed to lesser status (Ordered or Canceled) add the qty BACK into inventory. 

* Table for recording order_num status changes
+ order_num (fkey)
+ timestamp
+ status
+ emp_num who changed it.
* method for displaying that in the OrderDetails page.
* Table for recording inventory changes
+ same as above.

