using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SneakTrack___POS___Inventory_System
{
    public class Validator
    {
        private MainSystem sys;

        public Validator(MainSystem system)
        {
            this.sys = system;
        }

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

        public int readInt(object input)
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

        public double readDouble(object input)
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

        public bool tableHasValue(DataTable table, string column, string value, bool ignoreCase = false)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (ignoreCase)
                {
                    if (dr[column].ToString().Equals(value, StringComparison.OrdinalIgnoreCase)) return true;
                }
                else
                {
                    if (dr[column].ToString().Equals(value)) return true;
                }
            }
            return false;
        }

        public bool validateCharacters(string input)
        {
            String pattern = @"^[a-zA-Z0-9-_.]+$";
            return Regex.IsMatch(input, pattern);
        }
    }
}
