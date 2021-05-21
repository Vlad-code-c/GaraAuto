using System;
using System.Text.RegularExpressions;

namespace GaraAuto
{
    public class Validator
    {
        static public bool isValidNrInmatriculare(string nrImatric)
        {
            return !nrImatric.Equals("") && nrImatric.Length >= 6 && nrImatric.Length <= 12;
        }

        public static bool isValidDenumireTipAuto(string text)
        {
            return !text.Equals("") && text.Length <= 25;
        }

        public static bool isValidDenumireLocalitate(string text)
        {
            return !text.Equals("") && text.Length <= 20;
        }

        public static bool isValidPersonName(string text)
        {
            return !text.Equals("") && text.Length <= 20 && text.Length >= 3;
        }

        public static bool isValidEmail(string text)
        {
            return Regex.IsMatch(text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        public static bool isValidPassword(string text)
        {
            return !text.Equals("") && text.Length <= 50 && text.Length >= 5;
        }
    }
}