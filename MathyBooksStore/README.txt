﻿2021-10-27 9:53 Just created a new projct called MathyBooksstore, and I think I mispelled the word but it's fine
9:54 comment out the HTTPS in properties/launchSettings.json
9:56 Run the app......all good
10:03 we just add some breakpoint in the home controllers folder and run the app buh wasn't running we had to click on continue nd showed the privacy policy page
10:15 just downloaded the solar bootswatch and copy it the bootstrap.css file in bootsrap folder
10:22 go in the _layout file in the views folder and modify on line 7 and change the bootstrap.min.css to bootsrap

2021-11-02 8:27 didn't save my last file so had to pull out everything from github by clonning the 
repository
8:29 now im going add to the _layout.cshtml page in the views folder the additional stylesheets
and scripts from the CSS_JS.txt file located on blackboard
8:45 so moving on, im gonna add in the same _yout.cshtml page a dropdwon to the navbar
8:50 Run the app and notice the change...all good
9:00 Adding 3 new projects(.NET Core class library) to the application
9:18 had hard time finding the .NET Core claass library ohh God...
finally
9:20 done, just created the 3 projects now what next...let's find out
9:23 copy the dat folder from the first project MAthyBooksStore to the new project MathyBooks.DataAccess
and delete the original one
9:30 next install the Microsoft.EntityFrameworkCore.Relational and Core.SqlServer Packages
but before to do that...
9:31 Im gonna take a break
11:40 I'm back...
11:42: I was trying to figure out how to install the package and I think I just installed it
on the first project instead of MathysBooks.DataAccess
11:43 So, in the PMC I just run the following command: Install-Package Microsoft.EntityFrameworkCore.Relational 
-version 5.0.11 MathysBooks.DataAccess and it worked
11:44 run: Install-Package Microsoft.EntityFrameworkCore.SqlServer
-version 5.0.11 MathysBooks.DataAccess, successfully installed.
11:47 next I'm gonna Delete the migratiosn folder in the data folder
11:56 Install NuGet Packages: Identity.EntityFrameworkCore
11:57 In the PMC run the command: Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore 
-version 5.0.2 MathysBooks.DataAccess
12:00 In the ApplicationDbContext.cs file in Data folder I just modify the namespace to reflect the Project
12:05 Next, delete default Class1.cs file in all 3 projects
12:07 Build the Project
12:11 now im gonna move the models folder in to MathysBooks.Models and delete the original
12:19 Modify views-shared-Error.cshtml file but I have no idea of what I should modify exactly
12:23 Im just going to move on the next part, adding the project reference in the first project
MathyBooksStore and select MathysBooks.DataAccess and MathyBooks.Models
12:30 Rename Models folder to ViewModels in the MathysBooks.Models project
12:32 Inside the ErrorViewModels.cs file I changed the namespace to .Models.ViewModels
12:33 Build the project
12:38 I just noticed that the building failed so let's check what's going on...
12:56 I guess I'm gonna fix this tomorrow in class

11/3/2021 9:59 just fix my first error, I had to modify the startup.cs service'AddContext' with using statement:
using MathyBooksStore.DataAccess.Data;
10:14 Just added a static class in MathyBooks.Utility
10:25 add a customer areas to area
10:35 add a new amin area in areas
10:31 my project is not running

11/8/2021 12:19 My project wasn't running so I had to back to slide and try to figured out what I've missed
12:20 had to add the views file and all it's contents in customer/areas folder...I almost cry because of this
12:22 Now let start with the Part 2 of the project
12:24 Before to start the second part of the project, lemme make sre there are no errors by building my solution
12:25 Gooddddd....now review the appsettings.json, all goodd
12:26 so next, I'm gonna modify the database name in the appsettings.json on the default connection and save it
12:30 and now adding the migrations in the PMC by running the following command: add-migration AddDefaultIdenityMigration
12:32 The build succeeded but I got this message: Your target project 'MathyBooksStore' doesn't match your migrations assembly 'MathysBooks.DataAccess'. 
Either change your target project or change your migrations assembly.
Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("MathyBooksStore")). 
By default, the migrations assembly is the assembly containing the DbContext.
Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.
12:43 I had to hange the default project to MathysBooks.DataAccess and run the the command again
12:44 Done for today

2021-11-14 11:23 back to finish my project part 2
11:25 Migration file name: 20211108174311_AddDefaultIdentityMigration.cs
11:26 Now I'm reviewing the file for the SQL like-syntax,statements,columns, and primary key
11:28 I've complete the database, now I'm gonna update the database in the PM console
11:30 Build succeeded
11:35 just run the app, no errors...let's move on to the next part
11:37 I just add a new table to the DB by creating a category model in MathysBooks.Models
11:45 Then add a new class file to the .models projects and modify
11:49 Add the Migration via PM console: add-migration AddCategoryToDb
11:50 Build succeeded...great
11:51 Break....
12:40 Getting errors, still didn't figure it out yet....bruhhhhhhhh tired honestly
12:45 still wondering how to update the dbcontext.cs I just created
12:49 let's move on, I;ll go back to that later
12:50 Add a new foldder in the MathysBooks.DataAccess and name it Repository
12:52 then add an IRepository for the interface folder inside the Repository Folder
12:55 now im gonna add a new item of type interface inside the IRepository folder
1:00 just modify the IRepository.cs Item
1:08 Implement the class that implements the Repository
1:15 I just Included the using system in the Repository.cs Item and view the potential fixes 
and implement the interface
1:26 then modify the code to create the constructors and dependency injection (DI)
1:35: create a repos repository inside the IRepository file and Repository file called
ICategoryRepository.cs and CategoryRepository.cs
1:39 then modify the CategoryRepository Item but getting errors, I guess I need to modify
or update the ApplicationDbContext.cs file but don't know how
1:50 modify the ICategoryRepository.cs errors too.....arghhhhhhhhhhhh
2:00 next add the a new interface in the IRepository folder called ISP_Call.cs
2:05 then install the nuGet packaget for dapper
2:15 now Im gonna add a new class in the Repository folder call SP_Call.cs
2:20 going to bed gonna fix this and finish up everyhthing tomorrow

2021-11-14 12:00 Started to work on my errors but still can't fix it Im getting errors on my ApplicationDbContext.cs
12:02 still tryna figure out how to fix it
12:10 I try to move on to the next part and create an Interface inside the IRepository folder calle IUniofWork.cs
12:13I updated the code inside the new interface created
12:24 I created an Interface UnitofWork inside the Repository file and modify the code
12:25 Im still getting bunch of errors, arghhhhhhhhh....dn't know how to fix it....God...
12:30 now im gonna register it in the startup.cs with bunches of errors arggghhh...
12:35 Add a controller in the Controller folder in the MathyBooksStore
12:38 can't go further as I got bunches of errors so im gonna stop right here
2021-11-15 not the end of the project buh can't fix it now so im gonna stop

2021-11-21 4:00 PM I had to start the project all over again so I can see where I made those errors
4:10 And I think my project wasn't running cuz I deleted the models file in the previous project
4:19 now that I started all over again my project is finally running...oufff
5:00 adding a new MVC Controller empty inside areas/Admin and named it Category.cs


2021-11-23 12:31 adding a new class in the .Models project name Product with 2 errors of the previous project
12:33 edit the file just created and build the blue print
12:45 now im gonna add reference to the new products piece to the database in the ApplicationDbContext.cs file
12:50 I just checked my Tables in SQl SOE and can't find the dbo products, categories and covertypes, arghh....
12:53 add the IWebHostEnvironment call and its using statement to the Microsoft.AspNetCore.Hosting
12:58 Im gonna stop right here and do the rest tomorrow, im tired arghhhh...

2021-11-23 11:17 Im back to finish my project knowing that I still have an error in categorycontroller.cs
11:18 still tryna figure out how to fix it
11:52 next part Im gonna add the productController.cs to the areas/admin
11:53 I still have errors on my categorycontroller.cs and I don't know how to fix it so im gonna keep going v
11:54 Getting worse with my errors I have like 25 errors now, arghhhh...
12:05 create a viewModel in the models project to hold the product object and select list
12:07 im gonna modify the ProductVM class so it is public and install the Ms.AspNetCore.Mvc.ViewFeaturespackage.
12:12 errors again arghh,...tired of this errors honestly

2021-11-24 10:10 im still tryna fix the errors I made and I can't find my project on Github, arghhh...
10:14 I was adding the productRepository.cs and Iproductrepository in the Repository file but you knw what...?
10:15 still getting errors because this is not my original file
10:16 I had my original file in github but couldn't load all the the projects I don't get it

 Part 3 : completion days and hours: 2days and 3hours 

2021-12-03 22:04 I was tryna start a new project as I got bunch of errors in this one but didn't work
22:06 So Im gonna stick to this one and try to fix my errors
22:10 Went to bed because I'm pissed, can't fix my errors

2021-12-04 11:40 create a viewModel in the Models project to hold the Product object
11:42 select list for category and covertype
11:45 Modify the class just created inside the viewModels in the Models folder
11:50 Modify the ProductController so the IActionResult upSert calls to the ProductVM
11:55 not my keyboard freezing...arghhh
11:57 adding an Index View and copy the Index.cshmtl code from views/Category and modify product
12:00 just create a razor view called upsert.cshtml inside the views folder
12:10 create the index.cshtml and Upsert.cshtml inside the coverType folder and modify them
12:24 Inside the Views folder create also index.cshtml and upsert.cshtml files inside the product folder
12:26 I just modify the index.cshtml and upsert.cshmtl files
12:30 Im going to bed im gonna finish everything tomorrow cuz now im tired...arghh

2021-12-05 7:39 Im back to finish up my project and figure out how o fix my errors
7:43 now im gonna modify the CategoryController.cs file inside the Controllers folder
7:48 I think I've got bunch of errors cuz there was many files I didn't modify
7:49 now I'm gonna modify the CoverTypeController.cs file too 
7:52 copying the HomeController.cs file inside the Controllers folder in the Customer folder
7:55 Inside the Views folder in the Customer folder, just modify the Index.cshtml file
8:15 Create a file inside the Viewes/Shared folder called _CreateAndBackToListButton.cshtml
and modify it
8:18 im gonna create also the file called _EditAndBackToListButton.cshtml inside the same folder
8:23 modify the CategoryRepository.cs file inside the Repository folder
8:30 getting errors inside the CoverTypeRepository and CategoryRepository.cs files arghhh...
8:35 Im gonna take a break...see u
9:25 Im back...let's move on to the next part
9:28 checking the Repository.cs file iniside the Repository folder and modify it
9:32 modifying the SP_Call.cs inside the Repository folder
9:38 adding covertype and product in the UnitOfWork.cs file inside Repository folder
9:50 adding void Update(CoverType coverType); inside ICoverTypeRepository.cs file
9:55 public interface IProductRepository : IRepository<Product> inside the IProductRepository.cs file
10:00 Most of the errors I got was because I didn't have the CoverType.cs file inside MathysBooks.Models
10:10 got errors inside Product.cs file inside MathysBooks.Models project trying to fix it
10:18 I just add using System.ComponentModel.DataAnnotations.Schema; and it worked
10:26 adding public const string Proc_CoverType_Create = "usp_CreateCoverType";
        public const string Proc_CoverType_Get = "usp_GetCoverType";
        public const string Proc_CoverType_GetAll = "usp_GetCoverTypes";
        public const string Proc_CoverType_Update = "usp_UpdateCoverType";
        public const string Proc_CoverType_Delete = "usp_DeleteCoverType";
inside SD.cs file

11:50 try to add-migration AddProductToDb but the build failed

2021-12-06 11:13 Just Install the Microsot.AspNetCore.Mvc.ViewFeatures package.
