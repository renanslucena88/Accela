# Accela
AccelaTest
Starting at 6:30
Completed at 10:00

HOW TO CONFIGURE

Change the Connection String on the appsettings.json in both projects: AccelaTest.Data and AccelaTest.UI. My Local Sql Server have no instance and I log in 
  "ConnectionStrings": {
    "AccelaConnection": "Server=localhost;Database=AccelaTest;Trusted_Connection=True;MultipleActiveResultSets=true"
  },



On Package Manage Console, select Default Project = AccelaTest.Data and run the command Update-Database. The local Database will be created. 

The Exercise is ready.






WHAT I USED FOR THIS PROJECT

Entity Framework Core
DDD
XUnit 
I tried to simulate a project using DDD. I hope you can noticed.
.Net Core 3.1
Dependency Injectio
SOLID Principles
Code First
SQL Server







