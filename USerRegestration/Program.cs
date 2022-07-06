namespace UserRegestration
{
    class Program
    {
        public static void Main(String[] args)
        {
            RegexClass regex = new RegexClass();
            regex.ValidateFirstNameRegex("Atul");
            regex.ValidateLastNameRegex("Sikarwal");


            string[] EmailList = { "abc@yohoo.com","abc-100@yohoo.com",
                                    "abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net",
                                     "abc.100@abc.com.au", "abc@1.com","abc","abc@.com.my",
                                    "abc123@gmail.a",
                                     "abc1232.com"
                                     ,".abc@abc.com","abc123.com.my", "abc123@.com.com","atulsikarwal5@gmail.com"};

            regex.ValidateEmailAddressRegex("lksahu303@gmail.com");
            foreach (string SampleEmailAddress in EmailList)
            {
                regex.ValidateEmailAddressRegex(SampleEmailAddress);
            }
            regex.ValidatePhoneNumberRegex("91 9983922916");

            regex.ValidatePasswordRegex("Atul@7");

        }


    }
}