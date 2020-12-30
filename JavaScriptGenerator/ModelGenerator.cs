using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace JavaScriptGenerator
{
    public class ModelGenerator
    {

        #region Generate Javascripts Model
        public static bool WriteJSClass(Type type)
        {
            try
            {
                string fileString = "function " + type.Name + "(defaultData){\n this = defaultData | {}; \n";

                // Get the public properties.
                PropertyInfo[] propInfos = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                //DisplayPropertyInfo(propInfos);


                fileString += WriteJSClassPropertyInfo(propInfos);
                fileString += "}";
                // now create a js file

                return File.CreateFile(fileString, type.Name, Extension.js);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static string WriteJSClassPropertyInfo(PropertyInfo[] propInfos)
        {
            string body = "";
            // Display information for all properties.
            foreach (var propInfo in propInfos)
            {
                var defaultValue = SetJSDefaultValue(propInfo.PropertyType);
                body += $" this.{ConvertToCamelCase(propInfo.Name)} = defaultData.{propInfo.Name} | {defaultValue};\n";
            }
            return body;
        }
        private static string SetJSDefaultValue(Type type)
        {

            string result = null;

            switch (type.Name)
            {
                case "Int16":
                    result = "0";
                    break;
                case "Int32":
                    result = "0";
                    break;
                case "Int64":
                    result = "0";
                    break;
                default:
                    result = "null";
                    break;
            }

            return result;
        }
        #endregion

        #region Generate TypeScripts Model
        public static bool WriteTSClass(Type type)
        {
            try
            {
                string fileString = "class " + type.Name + " {\n";

                // Get the public properties.
                PropertyInfo[] propInfos = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                //DisplayPropertyInfo(propInfos);


                fileString += WriteTSClassPropertyInfo(propInfos);
                fileString += "}";
                // now create a js file

                return File.CreateFile(fileString, type.Name, Extension.ts);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static string WriteTSClassPropertyInfo(PropertyInfo[] propInfos)
        {
            string body = "";
            // Display information for all properties.
            foreach (var propInfo in propInfos)
            {
                var defaultValue = SetTSDefaultValue(propInfo.PropertyType);
                body += $" {ConvertToCamelCase(propInfo.Name)}: {defaultValue};\n";
            }
            return body;
        }
        private static string SetTSDefaultValue(Type type)
        {

            string result = null;

            switch (type.Name)
            {
                case "Int16":
                    result = "number";
                    break;
                case "Int32":
                    result = "number";
                    break;
                case "Int64":
                    result = "number";
                    break;
                default:
                    result = "string";
                    break;
            }

            return result;
        }

        #endregion

        #region Utility 
        public static void DisplayPropertyInfo(PropertyInfo[] propInfos)
        {
            // Display information for all properties.
            foreach (var propInfo in propInfos)
            {
                bool readable = propInfo.CanRead;
                bool writable = propInfo.CanWrite;

                Console.WriteLine(" Property name: {0}", propInfo.Name);
                Console.WriteLine(" Property type: {0}", propInfo.PropertyType);
                Console.WriteLine(" Read-Write:    {0}", readable & writable);
                if (readable)
                {
                    MethodInfo getAccessor = propInfo.GetMethod;
                    Console.WriteLine("   Visibility:    {0}", GetVisibility(getAccessor));
                }
                if (writable)
                {
                    MethodInfo setAccessor = propInfo.SetMethod;
                    Console.WriteLine("   Visibility:    {0}", GetVisibility(setAccessor));
                }
                Console.WriteLine();
            }
        }

        public static string ConvertToCamelCase(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                    result = result.Append(Char.ToLower(str[i]));
                else
                    result = result.Append(str[i]);
            }
            return result.ToString();
        }

        public static String GetVisibility(MethodInfo accessor)
        {
            if (accessor.IsPublic)
                return "Public";
            else if (accessor.IsPrivate)
                return "Private";
            else if (accessor.IsFamily)
                return "Protected";
            else if (accessor.IsAssembly)
                return "Internal/Friend";
            else
                return "Protected Internal/Friend";
        }
        #endregion
    }
}
