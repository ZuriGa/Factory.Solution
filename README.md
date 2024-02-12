# Dr. Sillystringz's Factory

#### A C# / ASP.NET Core MVC application using Entity Framework Core and MySQL, Many-to-Many relationships. 

#### By Zuri Gallegos 👩🏾‍💻

## Technologies Used

* C#
* HTML
* CSS
* Bootstrap
* .NET
* VScode
* MySQL Workbench
* Entity Framework Core 6.0
* Pomelo.EntityFrameworkCore.MySql


## Description: 
### This project involves building an MVC web application for the factory of the Dr. Sillystringz to manage machine repairs and their engineers. The application allows the factory manager to maintain a database of engineers, machines, and their repair relationships. Here are the key features:
* Allows users to add a list of engineers and machines.
* Define a many-to-many relationship between engineers and machines.
* Add engineers and machines to the system.
* Specify which engineers are licensed to repair which machines.
* View details of engineers and machines.
* Add or remove machines that an engineer can repair.
* Add or remove engineers from a specific machine.




## Setup/Installation Requirements ⚙️ 🖥️

* Make sure you have MySQL Server and MySQL Workbench installed on your system. The following steps assume you have the required installations. 

#### Setting up Entity Framework Core:
* Install the dotnet-ef tool globally by opening your terminal and executing: 
    
    $ dotnet tool install --global dotnet-ef --version 6.0.0

* Optionally, verify that EF Core CLI tools are correctly installed by running:
    
    $ dotnet ef

#### Install and Run the Project: 
* Copy the URL of this repository: `https://github.com/ZuriGa/Factory.Solution.git`
* Open your Terminal
* Navigate to the directory where you want to clone the project.
* Run this command in your terminal: <br /> 

      $ git clone https://github.com/ZuriGa/Factory.Solution.git

* Navigate to the projects directory name Factory <br />

* Create your `appsettings.json` file within the projects production directory to protect the sensitive data within our database connection string by adding it to our `.gitignore`

* Add your appsettings.json with the following contents, replacing the following values with your own:

      [YOUR-USER-HERE] with your username
      [YOUR-PASSWORD-HERE] with your password
      [YOUR-DB-NAME] with the name of your database


      ProjectName.Solution/ProjectName/appsettings.json
        {
          "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
        }
      }

* With appsettings.json properly configured, run the following command in your terminal to reference the project's migrations and re-create the application's database:

      $ dotnet ef database update
      
* In the command line, run the command `dotnet run` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
* Optionally, you can compile the web app without running it by executing:

      $ dotnet build

* Open your web browser and navigate to https://localhost:5001 to use the web application.<br />
Note: If you're unable to access https://localhost:5001, you may need to configure a .NET developer security certificate for HTTPS.



## Known Bugs

* _No known bugs. If you encounter any issues, please feel free to contact the author._


## License

MIT License

Copyright (c) 2024 Zuri Gallegos
