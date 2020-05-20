using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Names namesList = new Names();

            Console.WriteLine(namesList[3]);
            Console.WriteLine(namesList["Rares"]);

            //Console.WriteLine(namesList[7]);
            //Console.WriteLine(namesList["Serban"]);
        }
    }

    internal class Names
    {
        private string[] names = { "George", "Vlad", "Dragos", "Mihai", "Bogdan", "Rares", "Marius" };

        public int this[string name] => FindNameIndex(name);

        private int FindNameIndex(string name)
        {
            for (int i = 0; i < names.Length; i++)
                if (name == names[i])
                    return i;

            throw new System.ArgumentOutOfRangeException(nameof(name), $"{name} is not in the names list.");
        }

        public string this[int index] {
            get
            {
                if(index >= names.Length)
                    throw new System.ArgumentOutOfRangeException(nameof(index), $"Index out of range.");
                else
                    return names[index];
            }
        }
    }
}
