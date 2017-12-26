using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Zoo
{
    class Tree : Plant
    {
        public Tree(string name, int age, int height)
        {
            Name = name;
            Age = age;
            Height = height;
        }

        public override string ToString()
        {
            return Name + "," + Age + "," + Height;
        }

        public override void Growth()
        {
            this.Height++;
            Console.WriteLine("Now {0} is {1} meters height!", this.Name, this.Height);

        }

        public static List<Tree> LoadAll()
        {
            List<Tree> treeList = new List<Tree> { };
            string currentPath = Directory.GetCurrentDirectory();
            string[] listOfTrees = File.ReadAllLines(currentPath + "\\trees.txt");

            foreach (string tree in listOfTrees)
            {
                string[] param = tree.Split(',');

                treeList.Add(new Tree(param[0], int.Parse(param[1]), int.Parse(param[2])));

            }

            return treeList;

        }


        public static void SaveAll(List<Tree> listOfTrees)
        {
            string currentPath = Directory.GetCurrentDirectory();
            List<string> StringTreeList = new List<string> { };
            foreach (Tree tree in listOfTrees)
            {
                StringTreeList.Add(tree.ToString());

            }

            File.WriteAllLines(currentPath + "\\trees.txt", StringTreeList);


        }
    }
}
