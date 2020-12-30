using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace JavaScriptGenerator
{
    public class File
    {
        #region File Access Method
        public static Assembly ReadDLLFile(string path)
        {
            return Assembly.LoadFrom(path);
        }
        public static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes()
                      .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                      .ToArray();

        }
        public static bool CreateFile(string body, string fileName, string extension)
        {
            string path = @"F:\" + fileName + "." + extension;

            try
            {
                WriteFile(path, body);
                ReadFile(path);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void WriteFile(string path, string body)
        {
            try
            {


                // Create the file, or overwrite if the file exists.
                using (FileStream fs = System.IO.File.Create(path, 1024))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(body);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ReadFile(string path)
        {
            try
            {

                // Open the stream and read it back.
                using (StreamReader sr = System.IO.File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
