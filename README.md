# UnitTest
1 - Install the NUnit test adapter extension for Visual Studio:

2 - In Visual Studio, go to Tools > Extensions and Updates
    Search for "NUnit Test Adapter"
    Click Download to install the extension
    Add the NUnit test project to your ASP.NET Core solution:

3 - In Visual Studio, right-click on the solution and select Add > New Project
    Select the NUnit 3 Test Project (.NET Core) template and give it a name (e.g. MyProject.Tests)
    Click Create
    Add a reference to your ASP.NET Core project in the NUnit test project:

4 - In the MyProject.Tests project, right-click on Dependencies and select Add Reference
    Select the Projects tab and check the box next to your ASP.NET Core project
    Click OK
    
5 - To use the StringManipulation class in your test methods, you can simply add a using statement at the top of your test class to import the namespace that contains the StringManipulation class (assuming it's in a separate namespace from your test class). 
![image](https://user-images.githubusercontent.com/73199337/224343387-07768c0f-c6de-4a93-a4c0-262e106f3a27.png)

6 -Run the test:

Open the Test Explorer window in Visual Studio (Test > Windows > Test Explorer)
Select the test you just created and click Run Selected Tests
The test should pass if the Substitute function behaves as expected. If it fails, you may need to modify the function or the test case to fix the issue.

7 - Repeat steps 6-7 for additional test cases:

Create test cases that cover different scenarios, such as:
The search string is not found in the input string
The search string appears multiple times in the input string
The input string is null or empty
The search string or replace string is null or empty
