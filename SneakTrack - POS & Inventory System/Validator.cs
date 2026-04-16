using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int readInt(object input)
        {
            int result;
            try
            {
                result = (int)input;
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
                result = (double)input;
                return result;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
    }
}
