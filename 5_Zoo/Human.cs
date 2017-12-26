using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Zoo
{
    class Human : Animal
    {
        
        public Human(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override void Say()
        {
            Console.WriteLine("My name is {0}", Name);
        }

        public void Eat()
        {
            this.Weight ++;
            Console.WriteLine("{0} is {1} kg weight.", this.Name, this.Weight);
        }
        public override string ToString()
        {
            return  Name + ","+ Age +","+ Weight;
        }

        public static List<Human> LoadAll()
        {
            List<Human> humanList = new List<Human> { };
            string currentPath = Directory.GetCurrentDirectory();
            string[] listOfHumans = File.ReadAllLines(currentPath + "\\humans.txt");

            foreach (string human in listOfHumans)
            {
                string[] param = human.Split(',');

                humanList.Add(new Human(param[0], int.Parse(param[1]), int.Parse(param[2])));

            }

            return humanList;

        }


        public static void SaveAll(List<Human> listOfHumans)
        {
            string currentPath = Directory.GetCurrentDirectory();
            List<string> StringHumanList = new List<string> { };
            foreach (Human human in listOfHumans)
            {
                StringHumanList.Add(human.ToString());

            }

            File.WriteAllLines(currentPath + "\\humans.txt", StringHumanList);


        }

    }
}
