using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Zoo
{
    class Mushroom : Plant
    {
        private bool IsPoisonous;
        public Mushroom(string name, int age, int height, bool isPoisonous)
        {
            Name = name;
            Age = age;
            Height = height;
            IsPoisonous = isPoisonous;
        }
        public override void Growth()
        {
            this.Height++;
            Console.WriteLine("Now {0} is {1} meters height!", this.Name, this.Height);
        }

        public override string ToString()
        {
            return Name + "," + Age + "," + Height + "," + IsPoisonous;
        }

        public static List<Mushroom> LoadAll()
        {
            List<Mushroom> mushroomList = new List<Mushroom> { };
            string currentPath = Directory.GetCurrentDirectory();
            string[] listOfMushrooms = File.ReadAllLines(currentPath + "\\mushrooms.txt");

            foreach (string mushroom in listOfMushrooms)
            {
                string[] param = mushroom.Split(',');

                mushroomList.Add(new Mushroom(param[0], int.Parse(param[1]), int.Parse(param[2]), bool.Parse(param[3])));

            }

            return mushroomList;

        }


        public static void SaveAll(List<Mushroom> listOfMushrooms)
        {
            string currentPath = Directory.GetCurrentDirectory();
            List<string> StringMushroomList = new List<string> { };
            foreach (Mushroom mushroom in listOfMushrooms)
            {
                StringMushroomList.Add(mushroom.ToString());

            }

            File.WriteAllLines(currentPath + "\\mushrooms.txt", StringMushroomList);


        }


    }
}
