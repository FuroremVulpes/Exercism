using System;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var phoneNumberDigits = new String(phoneNumber.Where(Char.IsDigit).ToArray());

        if (phoneNumberDigits.Length >= 10 && phoneNumberDigits.Length < 12)
        {
            if (phoneNumberDigits.Length == 11)
            {
                if (phoneNumberDigits.StartsWith('1'))
                    phoneNumberDigits = phoneNumberDigits.Remove(0, 1);
                else
                    throw new ArgumentException();
            }
            if (Char.GetNumericValue(phoneNumberDigits[0]) < 2 || Char.GetNumericValue(phoneNumberDigits[3]) < 2)
                throw new ArgumentException();
                
            return phoneNumberDigits;
        }
        else
            throw new ArgumentException();
    }
}