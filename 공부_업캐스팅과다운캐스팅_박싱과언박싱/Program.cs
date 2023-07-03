using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _230619
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parent myParent = new Parent();
            Child myChild = new Child();

            //myParent.PrintInfos(); 
            //myChild.PrintInfos();

            Parent tempParent = myChild;         // 업 캐스팅
            Child tempChile = (Child)tempParent; // 다운 캐스팅

            tempParent.PrintInfos();
            tempChile.PrintInfos();

            List<MonsterBase> monsterList = new List<MonsterBase>();
            Wolf myWolf = new Wolf();
            Slime mySlime = new Slime();
            Dog myDog = new Dog();

            myDog.DogPrint();

            int number = 10;
            number.PlusAndPrint(5);

            monsterList.Add(myWolf);
            monsterList.Add(myDog);
            monsterList.Add(mySlime);

            if ( monsterList.IsValid())
            {
                Console.WriteLine(" 이 리스트는 유효하다. Null도 아니고, 값도 들어있다.");
                
            }
            else
            {
                Console.WriteLine(" 이 리스트는 유효하지 않다. Null 이거나 , 값이 없거나. ");
            }

            foreach ( var monster in monsterList )
            {
                monster.PrintInfos();
            }
        }




        // 박싱과 언박싱
        static void Desc01()
        {
            // 박싱과 언박싱
            int number = 10;
            char charValue = 'A';
            string textStr = "Hello World";

            object canSaveAll1 = number;
            object canSaveAll2 = charValue;
            object canSaveAll3 = textStr;

            Console.WriteLine(canSaveAll1);
            Console.WriteLine(canSaveAll2);
            Console.WriteLine(canSaveAll3);
            //
            Console.WriteLine();
            //
            int number2 = (int)canSaveAll1;

            Console.WriteLine(number2);
            //
            Console.WriteLine();
            //
            var canSaveAnything1 = number;
            var canSaveAnything2 = charValue;
            var canSaveAnything3 = textStr;

            Console.WriteLine(canSaveAnything1);
            Console.WriteLine(canSaveAnything2);
            Console.WriteLine(canSaveAnything3);
            //
        }
        // 박싱과 언박싱
    }
}
