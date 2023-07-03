using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _230612
{
    internal class Kirby : MonsterBase // 상속 => 부모 클래스를 가져다 씀
    {
        //private string Name;
        //private int HP;
        //private int MP;
        //private int damage;
        //private int defence;
        //private string monsterType;

        public override void Initilize(string Name, int HP, int MP, int damage, int defence, string monsterType)
        {
            base.Initilize(Name, HP, MP, damage, defence, monsterType);  
        }

        public override void Print_MonsterInfo()
        {
            base.Print_MonsterInfo();
        }

        public void Print_overloadingTest( int textStr )
        {
            Console.WriteLine(" 함수 찍힌다 -> {0}",textStr);
        }
    }
}
