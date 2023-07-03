using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _230609
{
    public class Program
    {
        static void Main(string[] args)
        {

            // 로또 번호 랜덤 뽑기
            Random random = new Random();
            int[] lottos = new int[6];

            for (int i = 0; i < lottos.Length; i++)
            {
                lottos[i] = random.Next(1, 45);
            }

            Thread.Sleep(1000);       // 둘 다 1000 이 1초로
            Task.Delay(1000).Wait();  // C++의 sleep 과 같다.

            foreach (int lotto_ in lottos)
            {
                Console.Write("{0} ", lotto_);
                Task.Delay(1000).Wait(); 
            }
            Console.WriteLine();

            // 로또 번호 랜덤 뽑기



            Desc001();

            int[] numbers = new int[5];
            int[,] numbers2 = new int[5, 5];

            int valueCount = 0;
            for ( int y = 0; y <5; y++ )
            {
                for (int x = 0; x < 5; x++)
                {
                    valueCount += 1;
                    numbers2[y, x] = valueCount;
                }
            }

            PrintMyArray(numbers2);
        } // Main()
        static void Desc001()
        {


            string userInput1 = default;
            string userInput2 = default;

            int number = default;

            float floatNumber = default;

            int userNumber1 = default;
            int userNumber2 = default;

            // { 여기서 입력을 받는다.
            userInput1 = Console.ReadLine();
            userInput2 = Console.ReadLine();
            // } 여기서 입력을 받는다.


            // { 입력 받은 것을 숫자로 변환한다.
            userNumber1 = System.Convert.ToInt32(userInput1);   // 방법 1
            userNumber2 = System.Convert.ToInt32(userInput2);


            userNumber1 = int.Parse(userInput1);                // 방법 2
            userNumber2 = int.Parse(userInput2);


            int.TryParse(userInput1, out userNumber1);          // 방법 3
            int.TryParse(userInput2, out userNumber2);
            // } 입력 받은 것을 숫자로 변환한다.


            // {1} , {0} 처럼 중괄호 안에 쓰이는 숫자의 의미는 '자리 표시자' , 쉽게 말하면 출력되는 순서로 0 부터 먼저 출력된다.
            Console.WriteLine("입력 받은 내용을 출력하고 싶어 -> {1},{0} \n\n", userInput1, userInput2);


            // 문자열을 입력 받아서 더하니 계산이 불가능하다.( ex : 1 + 1 = 11 )
            Console.WriteLine("{0} + {1} = {2} \n", userInput1, userInput2, userInput1 + userInput2);


            // 방법 1 , 2 , 3 중 택하면 알맞게 계산이 된다.
            Console.WriteLine("{0} + {1} = {2} \n", userNumber1, userNumber2, userNumber1 + userNumber2);

        }

        static void PrintMyArray(int[,] array_)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("{0} ", array_[y, x]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }


}
