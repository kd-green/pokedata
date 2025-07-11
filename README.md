SimData is a Blazor web application developed using Visual Studio. 
This application was developed using two SQL Server databases - one for user authentication and another for test data.
The purpose of this application is to provide a hub for test data that can be used for the new application that Team CW is developing. 
Junior and regular developers only need to be able to access the data and compare it to what they currently have developed on their branch, thus logged out users have Read permissions; senior developers make use of an account with fulL CRUD permissions.

The logged-in user experience can be sought using the following credentials:
email: test@gmail.com
password: Test1!

The following Visual Studio application templates were used in the development of this application:
- Blazor Web App
- NUnit Test Project

A common error when running the app is incorrect information being automatically added to pokedata.AssemblyInfo.cs prior to running. If this error occurs, it can be fixed by manually deleting any and all assembly: lines and proceeding with running it that way.