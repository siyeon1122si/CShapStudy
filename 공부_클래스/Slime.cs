using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230612
{
    public class Slime
    {
        private string Name;
        private int HP;
        private int MP;
        private int damage;
        private int defence;
        private string monsterType;

        public void Print_MonsterInfo()
        {
            Console.WriteLine(" 몬스터 이름 : {0} \n 몬스터 타입 : {1}", Name, monsterType);
            Console.WriteLine(" Hp : {0} \n Mp : {1} \n 데미지 : {2} \n 방어력 {3}", HP, MP, damage, defence);
        }
    }
}
