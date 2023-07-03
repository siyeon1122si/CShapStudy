using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 클래스 내부에 있는 변수 : 필드 
// 클래스 내부에 있는 함수 : 맴버함수 다른말로는 메서드

// static 메서드에서 인스턴스 필드는 찍을 수 없다.

namespace _230614
{
    public class Print1     // 클래스의 접근 수준이 public
    {
        public static string staticMessage = default;
        string message = default;

        public void PrintMessage( string localMessage )     // 메서드의 접근 수준도 public
        {
            message = localMessage;
            Console.WriteLine("이런 걸 출력할 것 -> {0}",message);
        }     // PrintMesage()

        public static void PrintMesage()
        {
            Console.WriteLine();
        }
    }
}
