using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230619
{
    public class Child : Parent // 부모 클래스 불러오기
    {
        string strChild = default;

        public override void PrintInfos()
        {
            base.PrintInfos();

            number = 10;
            strValue = "This is Child";
            strChild = "Sentence of Child added";

            Console.WriteLine("Child class -> number : {0} , strValue : {1},strChild : {2} ",
                this.number , this.strValue , this.strChild);
        }
    }
}
