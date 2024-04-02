namespace UserRegistration.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void AddUser_InvalidUsername_TooShort() //Testar om username är för kort 
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string username = "abc"; // Too short
            string password = "password123";
            string email = "emmafilip17@example.com";

            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "Username must be between 5 and 20 characters long.");
        }

        [TestMethod]
        public void AddUser_InvalidUsername_TooLong()  //Testar om username är för lång
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string username = "abcdefghijklmnopqrstu"; // Too long
            string password = "password123";
            string email = "emmafilip17@example.com";

            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "Username must be between 5 and 20 characters long.");
        }

        [TestMethod]
        public void Password_ValidPasswordWithSpecialCharacter()  // Testar om password innehåller specialtecken, true
        {
            // Arrange
            var registrationService = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "password123!";
            string email = "emmafilip17@gmail.com";
            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "User added successfully.");
        }
        [TestMethod]
        public void Password_ValidPasswordWithoutSpecialCharacter()  // Testar om password innehåller specialtecken, false
        {
            // Arrange
            var registrationService = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "passw";
            string email = "emmafilip17@gmail.com";
            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "Password lenght must be over 8 characters and must include special sign");
        }

        [TestMethod]
        public void Password_TooShort() // Testar om password är rätt längd i detta fall för kort
        {
            // Arrange
            var registrationService = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "passw!";
            string email = "emmafilip17@gmail.com";
            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "Password lenght must be over 8 characters and must include special sign");
        }
        [TestMethod]
        public void CheckIfEmailIsCorrectFormat() //Testar om email är i rätt format @gmail.com true
        {
            //Arrange
            var testDummy = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "password12!";
            string email = "emmafilip17@gmail.com";

            //Act
            string result = testDummy.AddUser(username, password, email);
            //Assert
            Assert.AreEqual(result, "User added successfully.");
        }
        [TestMethod]
        public void CheckIfEmailIsinCorrectFormat() //Testar om email är i rätt format, false
        {
            //Arrange
            var testDummy = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "password12!";
            string email = "test@hotmail.com";

            //Act
            string result = testDummy.AddUser(username, password, email);
            //Assert
            Assert.AreEqual(result, "Email must include @gmail.com");
        }
        [TestMethod]
        public void AddUser() //Testar att lägga till en user
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string username = "abcdefghijkl"; // Too long
            string password = "password123!";
            string email = "emmafilip17@gmail.com";

            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "User added successfully.");
        }
    }
}

