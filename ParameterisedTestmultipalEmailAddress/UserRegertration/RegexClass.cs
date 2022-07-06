using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UserRegestration
{
    public class RegexClass
    {

        public Regex FirstNameRegex = new Regex(@"^[A-Z]{1}[A-Za-z]{3,}?$");
        public bool ValidateFirstNameRegex(string FirstName)
        {
            try
            {
                Console.WriteLine("\nFirstName:" + FirstName);
                if (FirstNameRegex.IsMatch(FirstName))
                {
                 return true;
                }
                else
                {
                   return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.NULL_Message, "Name should not be null.");
            }


        }
        public Regex LastNameRegex = new Regex(@"^[A-Z]{1}[A-Za-z]{3,}?$");
        public bool ValidateLastNameRegex(string LastName)
        {
            try
            {
                Console.WriteLine("\nLastName:" + LastName);
                if (LastNameRegex.IsMatch(LastName))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Empty_Message, "Last name should not be empty.");
            }



        }


        public Regex EmailAddressRegex = new Regex(@"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$");
        public bool ValidateEmailAddressRegex(string EmailAddress)
        {
            try
            {
                Console.WriteLine("\nemail address:" + EmailAddress);
                if (EmailAddressRegex.IsMatch(EmailAddress))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Empty_Message, "Email should not be empty.");

            }

        }

        public Regex PhoneNumberRegex = new Regex(@"^(91){1}[ ]+[0-9]{10}$"); 
        public bool ValidatePhoneNumberRegex(string PhoneNumber)
        {
            try
            {
                Console.WriteLine("\nphonenumber:" + PhoneNumber);
                if (PhoneNumberRegex.IsMatch(PhoneNumber))
                {
                    return true;
                }
                else
                {
                    return false ;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Empty_Message, "Mobile number should not be empty.");

            }


        }


        public Regex PasswordRegex = new Regex(@"^[A-Za-z]{8,}[A-Z]{1,}[0-9]{1,}[-~!@#$%^*()_+{}:|?`;',]{1,}$");
        public bool ValidatePasswordRegex(string Password)
        {
            try
            {
                Console.WriteLine("\nPassword:" + Password);
                if (PasswordRegex.IsMatch(Password))
                {
                    return true;
                }
                else
                {
                   return false ;   
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Empty_Message, "Password should not be empty.");
            }


        }



    }
}
