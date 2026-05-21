using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SneakTrack___POS___Inventory_System
{
    public class Validator
    {

        public String readString (String input)
        {
            if (input == null || input.Trim().Length == 0)
            {
                return null;
            }
            else
            {
                return input.Trim();
            }
        }

        public String readStringNoEnd(String input)
        {
            if (input == null || input.TrimEnd().Length == 0)
            {
                return null;
            }
            else
            {
                return input.TrimEnd();
            }
        }

        public int readInt(String input)
        {
            int result;
            try
            {
                result = Convert.ToInt32(input);
                return result;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public double readDouble(string input)
        {
            double result;
            try
            {
                result = Convert.ToDouble(input);
                return result;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public bool validateCharacters(string input)
        {
            String pattern = @"^[a-zA-Z0-9-_.]+$";
            return Regex.IsMatch(input, pattern);
        }
    }
}
