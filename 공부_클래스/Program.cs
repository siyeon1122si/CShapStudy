using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230612
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mango cutemango= new Mango();
            cutemango.Print_MonsterInfo();
            Console.WriteLine();

            Slime cuteslime = new Slime();
            cuteslime.Print_MonsterInfo();
            Console.WriteLine();

            Kirby starkirby = new Kirby();
            starkirby.Print_MonsterInfo();
            Console.WriteLine();



            string[] str = new string[2] { "Hello","World " };
            CallFunc001(str);
            CallFunc002("Hello", "World", "+", "Hello", "World");
            CallFunc003(ref str);

            string[] resultstr; // string 배열을 선언함
            CallFunc004(str , out resultstr);  // out 을 활용해서 값을 넘겨 받음

            foreach ( string result_ in resultstr)
            {
                Console.WriteLine("{0} ",result_);
            }
            Console.WriteLine();


            int number = 0;
                number = number++;
            Console.WriteLine("number는 무슨 값이 들어 있나?? {0} ",number);
            Console.WriteLine();


            Dog myDog = new Dog();
            Console.WriteLine(" 우리 집 강아지 이름은 {0} 이고, 다리 갯수는 {1} 개이다",myDog.dogName , myDog.legCount);
            Console.WriteLine();

            myDog.Print_DogDesc();
            Console.WriteLine();

            Dog.Print_DogDesc002();
            Console.WriteLine();


            Cat myCat = new Cat(4,"야옹이","검정색");
            myCat.Print_MyCat();
        }  // Main


        // 함수를 Call 하는 방법 
        static void CallFunc001(string[] str) // 1번째 : 매개변수를 Call by Value 방식으로 넘기는 방법
        {
            foreach (string strElement in str)
            {
                Console.WriteLine("{0} ",strElement);
            }
            Console.WriteLine();
        }

        static void CallFunc002(params string[] str) // 2번째 : 매개변수를 Call by Value 방식으로 넘기는 건 똑같음,
        {                                            // 그런데 넘겨줄 매개변수를 배열의 요소 형태로 여러개 넘길 수 있다.
            foreach (string strElement in str)
            {
                Console.WriteLine("{0} ", strElement);
            }
            Console.WriteLine();
        }

        static void CallFunc003(ref string[] str) // 3번째 : 매개변수를 Call by reference 방식으로 넘기는 방법
        {
            foreach ( string strElement in str)
            {
                Console.WriteLine("{0} ",strElement);
            }
            Console.WriteLine();
        }

        static void CallFunc004(string[] str , out string[] outstr) // 4번째 : 매개변수를 Call by reference 방식으로 넘기는 방법
        {                                                           // 매개변수를 통해서 값을 Return 한다.
            string[] resultstring = new string[str.Length + 1];

            for ( int i = 0; i < str.Length; i++ )
            {
                resultstring[i] = str[i];
            }
            resultstring[str.Length] = "!";
            outstr = resultstring;
        }
        // 함수를 Call 하는 방법



    } // class Program

}
