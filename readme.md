# .NET Code Challenge

You've been provided with the shell of a .Net application in Visual Studio with some sample inputs 

Create an application which outputs the horse names in price ascending order. 

The code should be at a standard you'd feel comfortable with putting in production.

# Horse automated Ascending Sorting console App  

# Getting Started
Prerequsites
Visual studio 2019 
Download the zip and open the solution in vs2019 editor
ctrl + F5 
Four horses ascending order displayed from both xml and json are listed in console
Build the project

# Running the Tests
The tests covers service, simple unit. Moq is used as Mock framework. Nunit is used in this example.

It tests the Handle exception, mocked service, and Factory Method that create object read xml, json automatically based on the file extension.

File read test: if read file not successfully, throw custom exception. edge cases
Factory Method test: Test the factory design pattern and generated corresponding instance
Contoller test: test the ascending sorting and return type e.g. string['horsename1'...]

# Built With
asp net core 2.0

# Versioning 1.0.0

# Authors
Sean Shen

# Acknoledgments
 Time is limited, refactor is required in future.
# Features
Read the data file, and automatically read the file to object depending on file extention name e.g( .json, .xml)
Defensive coding is used someplace, but basically limited to certain scope.
No DI framework applied, autofac would be added in the future. Simple DI is written in this example
Various Nunit test is developed as a manner of TDD.

# Need to Improve
linq sorting xml could be refactored. 
Repository pattern might be applied if the system goes complex



