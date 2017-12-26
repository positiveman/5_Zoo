using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Zoo
{
    class Program
    {

        
        static void Main(string[] args)
        {
            List<Human> HumanList = Human.LoadAll();
            List<Tree> TreeList = Tree.LoadAll();
            List<Mushroom> MushroomList = Mushroom.LoadAll();
            List<Monkey> MonkeyList = Monkey.LoadAll();
            

            HumanList.Add(new Human("Dimon", 28, 81));
            HumanList.Add(new Human("Alex", 50, 150));

            MonkeyList.Add(new Monkey("Homer", 19, 150));
            MonkeyList.Add(new Monkey("Bart", 33, 198));

            MushroomList.Add(new Mushroom("champignon", 2, 15, false));
            MushroomList.Add(new Mushroom("toadstool", 3, 17, true));

            TreeList.Add(new Tree("maple", 150, 50));
            TreeList.Add(new Tree("chestnut", 70, 40));


            HumanList[0].Eat();
            HumanList[1].Say();
            MonkeyList[0].Say();
            MonkeyList[1].Birthday();
            MushroomList[0].Growth();
            TreeList[1].Growth();


            Human.SaveAll(HumanList);
            Monkey.SaveAll(MonkeyList);
            Mushroom.SaveAll(MushroomList);
            Tree.SaveAll(TreeList);



       
        }




        


        




    }
}
