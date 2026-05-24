using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public class Validator
    {
        private MainSystem sys;

        public Validator(MainSystem system)
        {
            this.sys = system;
        }

        public string readString(string input)
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

        public bool validateCharacters(string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }

        public bool validateCellValue(DataGridViewCell cell, bool condition, string errorMessage)
        {
            string value = cell.Value?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(value))
            {
                cell.Style.BackColor = Color.Tomato;
                cell.Style.ForeColor = Color.White;
                cell.ErrorText = "This field is required";
                return false;
            }

            else if (condition)
            {
                cell.Style.BackColor = Color.White;
                cell.Style.ForeColor = Color.Black;
                cell.ErrorText = "";  // Tooltip error
                return true;
            }

            else
            {
                cell.Style.BackColor = Color.Tomato;
                cell.Style.ForeColor = Color.White;
                cell.ErrorText = errorMessage;  // Show on cell hover
                return false;
            }
        }

        public bool dataGridHasErrorsOrBlank(DataGridView grid, List<int> excludeColumns = null)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row for adding data

                foreach (DataGridViewCell cell in row.Cells)
                {
                    Debug.WriteLine("checking column: " + cell.ColumnIndex);
                    if (excludeColumns != null && excludeColumns.Contains(cell.ColumnIndex))
                    {
                        continue;
                    }

                    if (!string.IsNullOrEmpty(cell.ErrorText))
                    {
                        return true;
                    }

                    else if (string.IsNullOrEmpty(cell.Value?.ToString()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
