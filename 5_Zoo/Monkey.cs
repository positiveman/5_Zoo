using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Zoo
{
    class Monkey : Animal
    {

        public Monkey(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        public override void Say()
        {
            Console.WriteLine("Wu-wu-wu"); ;
        }

        public void Birthday()
        {
            Age++;
            Console.WriteLine("Now monkey {0} is {1} years old!", this.Name, this.Age);

        }

        public override string ToString()
        {
            return Name + "," + Age + "," + Weight;
        }

        public static List<Monkey> LoadAll()
        {
            List<Monkey> monkeyList = new List<Monkey> { };
            string currentPath = Directory.GetCurrentDirectory();
            string[] listOfMonkeys = File.ReadAllLines(currentPath + "\\monkeys.txt");

            foreach (string monkey in listOfMonkeys)
            {
                string[] param = monkey.Split(',');

                monkeyList.Add(new Monkey(param[0], int.Parse(param[1]), int.Parse(param[2])));

            }

            return monkeyList;

        }


        public static void SaveAll(List<Monkey> listOfMonkeys)
        {
            string currentPath = Directory.GetCurrentDirectory();
            List<string> StringMonkeyList = new List<string> { };
            foreach (Monkey monkey in listOfMonkeys)
            {
                StringMonkeyList.Add(monkey.ToString());

            }

            File.WriteAllLines(currentPath + "\\monkeys.txt", StringMonkeyList);


        }


    }
}
