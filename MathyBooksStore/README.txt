2021-10-27 9:53 Just created a new projct called MathyBooksstore, and I think I mispelled the word but it's fine
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
