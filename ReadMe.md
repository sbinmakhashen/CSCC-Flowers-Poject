# Columbus State Community College, CSCI-2999 Capstone, su2019

## Take It Or Leaf It Flowers, Intranet App

This windows form app is simulating an intranet app that would be deployed to multiple retail locations.

It's purpose is to provide inventory management, new employee and updated employee management information, and order management, to work in concert with a customer based website (being developed elsewhere)

## CcnSession.dll

We have created a custom class library for controlling all of the SQL connections. This is useful two fold. 

1) It helps reduce and prevent SQL Injection attacks by divorcing as much of the sql code from direct user input as possible (because much of the needed SQL Statements in the app are called through methods of the class, very little needs to be user implimented. Those that are user implimented use paramaterized sql commands for additional safety.

2) it ensures that all connections are properly cleaned up after their use, and that we have only the commands called for what we need, when we need it, reducing load.

## Future Notes:

When this project is finished in August 2019, the database will be taken off line and this app will no longer properly function.

SQL files with the tables and dummy data for insertion will be included for use, but the connection data will need to be updated.

