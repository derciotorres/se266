using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



   public class ValidationLibrary
    {
        public static bool GotBadWords(string temp)
        {
            bool result = false;

            string[] strBadWords = { "STUDY", "HOMEWORK", "QUIZ", " LABS" };

            foreach (string strBW in strBadWords)
                if (temp.Contains(strBW))
                {
                    result = true;
                }
            return result;
        }//endo of bad words

       
        public static bool FutureDate(DateTime temp)
        {
            bool blnResult;
            if (temp <= DateTime.Now)
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;

            }
            return blnResult;
        }//end date

        public static bool MinNumAmount(int temp, int min)
        {
            bool blnResult;
            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }
            return blnResult;
        }//end min amount integer 
        public static bool MinNumAmount(double temp, double min)
        {
            bool blnResult;
            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }
            return blnResult;

        }//end min amount double



        //checking to see if the spot was filled in
        public static bool FilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }
            return result;
        }

        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;

            if (temp.Length >= minlen)
            {
                result = true;
            }

            return result;
        }



        //checking if the input as the word facebook
        public static bool CheckFace(string temp)
        {
            bool blnResult = true;

            int atLocation = temp.IndexOf("facebook");// on the function i am just looking for the person to type on the facebook link the word facebook 

            if (temp.Length < 15)
            {
                blnResult = false;
            }
            else if (atLocation < 4)
            {
                blnResult = false;
            }

            return blnResult;


        }

        // LOOK FOR ZIP CODES USING REGULAR EXPRESSION
        public static bool ZipCode(string zipCode)
        {
            var _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
            var validZipCode = true;
            if ((!Regex.Match(zipCode, _usZipRegEx).Success) && (!Regex.Match(zipCode, _caZipRegEx).Success))
            {
                validZipCode = false;
            }
            return validZipCode;
        }

        // LOOK FOR EMAIL USING REGULAR EXPRESSION

        public static bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // LOOK FOR VALID NUMBERS USING REGULAR EXPRESSION

        public static bool IsValidPhone(string Phone)
        {
            try
            {
                if (string.IsNullOrEmpty(Phone))
                    return false;
                var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
                return r.IsMatch(Phone);

            }
            catch (Exception)
            {
                throw;
            }
        }



        public static bool States(String state)
        {
            String states = "|AL|AK|AS|AZ|AR|CA|CO|CT|DE|DC|FM|FL|GA|GU|HI|ID|IL|IN|IA|KS|KY|LA|ME|MH|MD|MA|MI|MN|MS|MO|MT|NE|NV|NH|NJ|NM|NY|NC|ND|MP|OH|OK|OR|PW|PA|PR|RI|SC|SD|TN|TX|UT|VT|VI|VA|WA|WV|WI|WY|";
            return state.Length == 2 && states.IndexOf(state) > 0;
        }



    }



