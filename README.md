# AccountingSystem
This accounting system is mainly for my parants to track their spending. I also try my best to let my code follow 
the book of [clean code](https://www.amazon.com/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882) which is written by Uncle Bob.
if you have any ideas, you can Pull Resquests.

# Installation
```
git clone https://github.com/chiayisu/AccountingSystem.git
```
# Function 
This classs has some function to peform database operation and some functions will return code such as sucesss.

```
IsNull(string s)
```
this function is used to check the data you get is null or not. You can also change argument s to something like Class a. and it will return boolean value.

```
Conn(string DB_Name)
```
you need to send the connection string to this class and you will get the object of sqlconnection.

```
 IsDataExist(string sSQL, SqlConnection oConn)
```
In this function, you need to pass to arguments. sSQL is for the query of select and pass the sqlconnection object that has been serialized. you will get three types of code in this function.

```
CalculateTotal(string sSQL, SqlConnection oConn)
```
this function is for calculating some operation in accouting system e.g. income. 

# CAccount 
this class is a data structure used for database.

# CMessage
I defined some messages in this class for return to user.

# CDate 
you can get the date for now in this class.


 
