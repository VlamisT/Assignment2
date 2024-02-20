﻿# Assignment2

Create a solution named MyErpApp in VS 2022 containing at least the following 2 projects:
MyErp.Application => Console Application Project (.NET 6)
MyErp.Business => Class Library Project (.NET 6)
MyErp.DAL => Class Library Project (.NET 6)
MyErp.PrintService => Class Library Project (.NET 6).

The MyErp.DAL
The MyErp.DAL project should contain 3 classes:
Order
Customer
Static Class Called ErpDB which contains 2 Lists. One of Customer and one of Order

The MyErp.Business
The MyErp.Business should contain 2 implementations of the Repository Pattern:
OrderRepository
CustomerRepository
Each Repository needs to at least have a Create and GetAll method. These methods will insert and retrieve data from the corresponding Lists from MyErp.DAL.

MyErp.PrintService
The MyErp.PrintServices project should have:
A PrintintService Class which must include a Print<T>(T input)  method that converts the input item in Json Format. (Use the Newtonsoft Nuget to Serialize the object as a Json string.)

MyErp.Application
The MyErp.Application project is a console app which should include the following inside the Program.cs:
Create 5 new Orders and save them using the OrderRepository
Create 5 new Customers and save them using CustomerRepository
Retrieve all the Orders using the OrderRepository
Retrieve all the Customers using CustomerRepository
Print the first Order and first Customer from the retrieved data using the PrintintService 

Note: Each Layer (except the MyErp.Application) Needs to have its own Models and Interfaces. 
For example, for MyErp.Business there should be a project called MyErp.Business.Interfaces  which should include the IGenericRepository class and the layer related classes of Customer and Order.

