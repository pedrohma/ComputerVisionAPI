using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ComputerVisionAPI
{
    class Helper
    {
        public static void analyzeInput(string input)
        {
            List<string> parameters = new List<string> { "Categories", "Description", "Color", "ImageType", "Tags", "Adult", "Faces" };

            List<string> inputs = input.Split(',').ToList();

            if (inputs.Count > 0)
            {
                foreach (string inp in inputs)
                {
                    if (!parameters.Contains(inp))
                    {
                        throw new Exception(String.Format("Parameter {0} not valid.", inp));
                    }
                }
            }
        }
        public static void analyzePath(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new Exception("Path not valid.");
            }
        }
    }
}
