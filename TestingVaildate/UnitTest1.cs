using UserRegestration;

namespace UserRegisrationTest
{
    public class Tests
    {
        RegexClass user;
        [SetUp]
        public void Setup()
        {
            user = new RegexClass();
        }

        public void FirstName()
        {
            // Arrange 
            bool expected = true;
            string name = "Atul";
            RegexClass user = new RegexClass();

            // Act
            bool result = user.ValidateFirstNameRegex(name);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void LastName()
        {
            // Arrange 
            bool expected = true;
            string name = "Sikarwal";
            RegexClass user = new RegexClass();

            // Act
            bool result = user.ValidateLastNameRegex(name);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Email()
        {
            // Arrange 
            bool expected = true;
            string email = "atulsikarwal5@gmail.com";
            RegexClass user = new RegexClass();

            // Act
            bool result = user.ValidateEmailAddressRegex(email);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void MobileNumber()
        {
            // Arrange 
            bool expected = true;
            string mobile = "91 9983922916";
            RegexClass user = new RegexClass();

            // Act
            bool result = user.ValidatePhoneNumberRegex(mobile);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Password()
        {
            // Arrange 
            bool expected = true;
            string password = "abcdfghihgE1@";
            RegexClass user = new RegexClass();

            // Act
            bool result = user.ValidatePasswordRegex(password);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}