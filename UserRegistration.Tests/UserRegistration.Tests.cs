namespace UserRegistration.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void AddUser_InvalidUsername_TooShort() //Testar om username �r f�r kort 
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
        public void AddUser_InvalidUsername_TooLong()  //Testar om username �r f�r l�ng
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
        public void Password_ValidPasswordWithSpecialCharacter()  // Testar om password inneh�ller specialtecken, true
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
        public void Password_ValidPasswordWithoutSpecialCharacter()  // Testar om password inneh�ller specialtecken, false
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
        public void Password_TooShort() // Testar om password �r r�tt l�ngd i detta fall f�r kort
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
        public void CheckIfEmailIsCorrectFormat() //Testar om email �r i r�tt format @gmail.com true
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
        public void CheckIfEmailIsinCorrectFormat() //Testar om email �r i r�tt format, false
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
        public void AddUser() //Testar att l�gga till en user
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
        [TestMethod]
        public void AddUser_InvalidNonAlphanumericCharacters_ReturnFalse() // Testar att den inte ineh�ller icke-alphanumeriska tecken
        
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            //string Username = "abc$123"; // non-alphanumeric characters
            string nonAlphanumericString = "abc$123";
            string password = "password123!";

            string email = "emmafilip17@gmail.com";

            // Act
            bool result = registrationService.IsAlphanumeric(nonAlphanumericString);
            // Assert
            Assert.IsFalse(result, "Expected user registration to fail due to invalid characters in username.");
        }
        //[TestMethod]
        //public void IsAlphanumeric_InvalidNonAlphanumericString_ReturnsFalse() // Testar att den inte imeh�ller icke-alphanumeriska tecken
        //{
        //    // Arrange
        //    UserRegistrationService registrationService = new UserRegistrationService();
        //    string nonAlphanumericString = "abc$123";

        //    // Act
        //    bool result = registrationService.IsAlphanumeric(nonAlphanumericString);

        //    // Assert
        //    Assert.IsFalse(result, "Expected user registration to fail due to invalid characters in username.");
        //}
    }
}

