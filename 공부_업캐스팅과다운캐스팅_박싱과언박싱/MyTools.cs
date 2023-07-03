using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230619
{
    public static class MyTools
    {
        // ! List 안의 Element가 유효한지 검사한다
        public static bool IsValid<T>(this List<T> list_)
        {
            bool isValid = (list_ != null) && ( 0 < list_.Count );
            return isValid;
        }
        public static void DogPrint(this Dog myDog)
        {
            myDog.PrintInfos();
        }

        public static int PlusAndPrint(this int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
