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
        public void EmailTest()
        {
            string EMail1 = "xyz@gamil.com";
            string EMail2 = "xyz.bcd@gmail.com";
            string EMail3 = "xyz.hguyyt100@gmail.com";
            string EMail4 = "hyt.werd411@gmail.com";
            string EMail5 = "dfr.fdgd@gmail.com";
            bool result1 = user.ValidateEmailAddressRegex(EMail1);
            bool result2 = user.ValidateEmailAddressRegex(EMail2);
            bool result3 = user.ValidateEmailAddressRegex(EMail3);
            bool result4 = user.ValidateEmailAddressRegex(EMail4);
            bool result5 = user.ValidateEmailAddressRegex(EMail5);
            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
        }
    }
}