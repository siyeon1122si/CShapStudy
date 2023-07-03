using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230621
{
    public class Button : IClickable, IDamagable // 다중 상속이 가능
    {
        public void ClickThisObject(bool isClick_)
        {
            // 이제는 에러가 없어진다.
        }

        public void Damaged(int damage)
        {
            throw new NotImplementedException();
        }

        public void TesFunc()
        {
            Console.WriteLine(" 함수 테스트 ");
        }
    }
}
