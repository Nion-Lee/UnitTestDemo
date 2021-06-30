using System.Text.RegularExpressions;

namespace Validation
{
    public class Email
    {
        private readonly string _emailRule = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public Email() { }
        public Email(string regix) => _emailRule = regix;
        public bool IsValidEmail(string text)
        {
            if (text == null)
                return false;
            return new Regex(_emailRule).IsMatch(text);
        }
    }
}