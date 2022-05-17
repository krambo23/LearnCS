using System;
using System.IO;

namespace FileApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Text File Manipulation
            ReadFile();
            System.Console.WriteLine();
            
            WriteToFile();
            System.Console.WriteLine();

            // Binary File Manipulation
            WriteBinaryToFile();
            System.Console.WriteLine();

            ReadBinaryFile();
            System.Console.WriteLine();
        }

        private static void ReadFile()
        {
            try
            {
                // Create 'StreamReader' Instance
                // File Is Automatically Closed
                using (StreamReader streamReader = new StreamReader("Jamaica.txt"))
                {
                    string line;
                    System.Console.WriteLine("Reading File...");

                    // Read & Display Line By Line Until EOF
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        System.Console.WriteLine(line);
                    }
                    
                    System.Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Something Went Wrong - File Couldn't Be Read!");
                System.Console.WriteLine(e.Message);
            }
        }
    
        private static void WriteToFile()
        {
            string[] names = new string[] {"Bart Simpson", "Nelson Muntz"};
            
            try
            {
                using (StreamWriter streamWriter = new StreamWriter("names.txt"))
                {
                    foreach (string name in names)
                    {
                        streamWriter.WriteLine(name);
                    }
                }
                
                System.Console.WriteLine("Writing Complete!");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Something Went Wrong - File Couldn't Be Written!");
                System.Console.WriteLine(e.Message);
            }
        }
    
        private static void WriteBinaryToFile()
        {
            BinaryWriter binaryWriter = null;

            int i = 69;
            double d = 3.14157;
            bool b = true;
            string s = "I Am Very Happy";

            // Create File
            try
            {
                binaryWriter = new BinaryWriter(new FileStream("binary_data", FileMode.Create));
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Error Creating Binary File!");
                System.Console.WriteLine(e.Message);

            }

            try
            {
                // Write To File
                binaryWriter.Write(i);

                binaryWriter.Write(d);
                
                binaryWriter.Write(b);
                
                binaryWriter.Write(s);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error Writing To Binary File!");
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                binaryWriter.Close();
                System.Console.WriteLine("Writing to Binary File Complete!");
            }
        }

        private static void ReadBinaryFile()
        {
            BinaryReader binaryReader = null;

            try
            {
                binaryReader = new BinaryReader(new FileStream("binary_data", FileMode.Open));
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Something Went Wrong - Binary File Couldn't Be Read!");
                System.Console.WriteLine(e.Message);
            }

            try
            {
                System.Console.WriteLine("Reading Binary File...");
                int i = binaryReader.ReadInt32();
                double d = binaryReader.ReadDouble();
                bool b = binaryReader.ReadBoolean();
                string s = binaryReader.ReadString();

                Console.WriteLine("Integer data: {0}", i);
                Console.WriteLine("Double data: {0}", d);
                Console.WriteLine("Boolean data: {0}", b);
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Something Went Wrong - Binary File Couldn't Be Read!");
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                binaryReader.Close();
            }
        }
    }
}
// pg 218, 219, 220
// pg 221, 222
// pg 225, 226, 227, 228