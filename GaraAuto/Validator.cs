using System;

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
            return !text.Equals("") && text.Length < 20;
        }
    }
}