using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace SneakTrack___POS___Inventory_System
{
    public class FileHandler
    {
        MainSystem sys;

        public FileHandler(MainSystem system)
        {
            this.sys = system;
        }

        string imageDirPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\images"));

        // Duplicates a image to be stored in the system, returns the new path.
        public string imagePathtoFile(string path, string fileName)
        {
            try
            {
                string extension = System.IO.Path.GetExtension(path);
                string newFileName = fileName + extension;
                string destPath = System.IO.Path.Combine(imageDirPath, newFileName);
                System.IO.File.Copy(path, destPath, overwrite: true);
                return destPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
