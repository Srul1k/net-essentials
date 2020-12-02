using System;
using System.IO;
using System.Collections.Generic;
using ExceptionsLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = null;
            var persons = new List<Person>();

            try
            {
                sr = new StreamReader("persons.txt");
                while (!sr.EndOfStream)
                {
                    var buffer = sr.ReadLine().Split(':');
                    persons.Add(new Person(buffer[0], buffer[1], buffer[2]));
                }
            }
            catch(WrongGenderException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                Console.WriteLine($"Wrong value: {ex.Value}");
            }
            catch(PersonNotCreatedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            
            foreach (var p in persons)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
