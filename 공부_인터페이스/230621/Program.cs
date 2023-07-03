using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230621
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button clickableObject = new Button();
            clickableObject.ClickThisObject(true);
        }
        ///// <summary>
        ///// 이 함수는 매개변수를 하나 받아서 출력하는 함수입니다.
        ///// </summary>
        ///// <param name="descStr"> 이 변수는 문자열로 이루어진 설명을 받아서 저장하는 변수</param>


        /// /// <summary>
        /// 이 함수는 매개변수를 하나 받아서 출력하는 함수입니다.
        /// </summary>
        /// <param name="descStr"> 이 변수는 문자열로 이루어진 설명을 받아서 저장하는 변수</param>
        /// <returns> 함수가 정상 동작했을 때 true를 리턴합니다.</returns>

        // 함수에는 타인이 읽을 수 있도록 설명을 추가할 수 있다.
        // 1 번째 방법 : attribute 기능을 사용한 설명 추가
        [Obsolete("\n 이 함수는 아무런 기능이 없는 테스트 함수입니다 ")]

        

        static void TestFunc001()
        {
            Console.WriteLine(" 함수 콜 ");
        }

        static void DescFunc001(string descStr)
        {
            Console.WriteLine(" 함수 콜, 매개 변수 -> {0}",descStr);
            return true;
        }
    }
}
