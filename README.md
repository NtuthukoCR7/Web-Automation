Project Background

This is an automation project that navigates user to: http://www.way2automation.com/angularjs-protractor/webtables/

- Firstly it launches the URL mentioned above.
- It's then add first and second user using the methods created

Functionality
- I created a method called NavigateToURL tha will launch the URL
- Then I created a method called AddNewUser that will get all the browser elements
- I then Created an Add_New_USer test method that will add first and second user using TestCase source

How to run the tests
- Firstly you need to make sure you provide data for two users on the [TestCase] source
- Go to Test Explorer >> Expand Tests >> right click and run Add_New_User test
- The wait untill the tests finishes running the confirm they all passed
