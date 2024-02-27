.Net8 Lab 2 Configuring Routing and Navigation
 Mentor: Shailendra Chauhan
 Type : GuidedLab
 Points : 10
 Duration : 01:30:00
 Lab Problem Lab Solution
**Lab Details**
**Description**
In this lab, you will be learning how to implement routing into your ASP.NET Core applications. By the end of the lab, you'll have the skills to create an application with modules and connect the application pages.
Lab Objective
Upon completion of this lab, you will be able to:
Describe how to set up routing for your ASP.NET Core application
Create modules using Areas in ASP.NET Core
Describe how to set up routing for Areas in ASP.NET Core
Navigation between Public pages and Modules pages.
Prerequisites
You should be familiar with:
Basic Understanding of ASP.NET Core
Visual Studio IDE
Lab Requirements
Create an Empty ASP.NET Core MVC application.
Create a Login Page for Login as User and Admin roles.
After providing login details (username and password)
The user will go to the admin dashboard if the username & password are admin@gmail.com, 12345678
The user will go to the user dashboard if the username & password are user@gmail.com, 12345678
Create two modules one for Admin and one for User using Areas.
Both modules (admin and user) will have two pages – dashboard and profile pages.
Create a separate layout for each module.
Add the Logout link and upon clicking redirect to the logout page and show the message: “You have been logout successfully”
Note: Don’t use any database, just pass username and password and do navigation.

**Lab 3: Creating User Registration Form with Validations**
 
 Type : GuidedLab
 Points : 10
 Duration : 01:30:00
 Lab Problem  
Lab Details
**Description**
In this lab, you will be learning how to create a Login page and implement form validation into your ASP.NET Core applications. By the end of the lab, you'll have the skills to Form validations and use them in the application.

**Lab Objective**
Upon completion of this lab, you will be able to:
Create the SignUp page with Form validations in your ASP.NET Core application
How to use Custom validation attributes in the application

**Prerequisites**
You should be familiar with:
Basic Understanding of ASP.NET Core

**Lab Requirements**
Create a User Registration form with the following fields and validations.
Name: Required
Email: Required, Email
Password: Required with (1 Uppercase, 1 Number, 1 Special Char, and 1 Lowercase Char), Min Length (8 Chars)
ConfirmPassword: Required, Compare
Contact: Regular Expression
Gender: Required (Radio Button)
Accept Terms: Required (Check Box)
Note: Use Bootstrap for UI and Error Messages.
