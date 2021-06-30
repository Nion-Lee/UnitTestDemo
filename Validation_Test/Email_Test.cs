using Shouldly;
using Validation;
using Xunit;

namespace Validation_Test
{
    public class Email_Test
    {
        private readonly Email _email = new Email();

        [Theory]
        [InlineData("nionismine@yahoo.com.tw", true)]
        [InlineData("HiHi@123.", false)]
        [InlineData("I'm happy", false)]
        [InlineData("123@yahoo.com", true)]
        [InlineData("yesmyLord.com", false)]
        [InlineData(null, false)]
        public void IsValidEmail_Test(string text, bool expected)
        {
            _email.IsValidEmail(text).ShouldBe(expected);
        }
    }
}
