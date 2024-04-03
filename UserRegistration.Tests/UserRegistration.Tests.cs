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
        public void AddUser_ValidPassword_With_SpecialCharacter()  // Testar om password innehåller specialtecken
        {
            // Arrange
            var registrationService = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "password!";
            string email = "emmafilip17@gmail.com";
            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "User added successfully.");
        }
        [TestMethod]
        public void AddUser_ValidPassword_Without_SpecialCharacter()  // Testar om password saknar specialtecken
        {
            // Arrange
            var registrationService = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "pass";
            string email = "emmafilip17@gmail.com";
            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "Password lenght must be over 8 characters and must include special sign");
        }

        [TestMethod]
        public void AddUser_CheckifPassword_IsTooShort() // Testar om password är för kort
        {
            // Arrange
            var registrationService = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "pass!";
            string email = "emmafilip17@gmail.com";
            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "Password lenght must be over 8 characters and must include special sign");
        }
        [TestMethod]
        public void AddUser_CheckIfEmail_IsCorrectFormat() //Testar om email är i rätt format @gmail.com
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
        public void AddUser_ShouldReturnError_IfEmail_DoesNotEndWithCorrect_Format() //Testar om email inte är i rätt format
        {
            //Arrange
            var testDummy = new UserRegistrationService();
            string username = "abcdehen8";
            string password = "password12!";
            string email = "emmafilip17@hotmail.com";

            //Act
            string result = testDummy.AddUser(username, password, email);
            //Assert
            Assert.AreEqual(result, "Email must include @gmail.com");
        }
        [TestMethod]
        public void AddUser() //Testar att lägga till en användare (user)
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string username = "abcdefghi"; // Too long
            string password = "password123!";
            string email = "emmafilip17@gmail.com";

            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "User added successfully.");
        }
        [TestMethod]
        public void AddUser_InvalidNonAlphanumericCharacters_ReturnFalse() // Testar att användarnamet inte inehåller icke-alphanumeriska tecken

        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string nonAlphanumericString = "abc$123";
            string password = "password123!";
            string email = "emmafilip17@gmail.com";

            // Act
            bool result = registrationService.IsAlphanumeric(nonAlphanumericString);
            // Assert
            Assert.IsFalse(result, "Expected user registration to fail due to invalid characters in username.");
        }
        [TestMethod]
        public void IsAlphanumeric_EmptyString_ReturnsFalse()
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string emptyString = " ";

            // Act
            bool result = registrationService.IsAlphanumeric(emptyString);

            // Assert
            Assert.IsFalse(result);

        }
    }
}


