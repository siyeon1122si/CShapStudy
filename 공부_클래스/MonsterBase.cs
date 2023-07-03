using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230612
{
    public class MonsterBase
    {
        // 캡슐화 -> 필드를 private 로 처리해서 외부에서 접근 불가능하도록 하겠다는 의미
        // protected 는 상속받은 자식 클래스에서는 쓸 수 있도록 하겠다는 의미
        private string Name;
        private int HP;
        private int MP;
        private int damage;
        private int defence;
        private string monsterType;

        public virtual void Initilize( string Name , int HP , int MP , int damage , int defence, string monsterType)
        {
            // 초기화라는 의미
            this.Name = Name;
            this.HP = HP;
            this.MP = MP;
            this.damage = damage;
            this.defence = defence;
            this.monsterType = monsterType;
        } // Initilize

        public virtual void Print_MonsterInfo()
        {
            Console.WriteLine(" 몬스터 이름 : {0} \n 몬스터 타입 : {1}", Name, monsterType);
            Console.WriteLine(" Hp : {0} \n Mp : {1} \n 데미지 : {2} \n 방어력 {3}", HP, MP, damage, defence);
        }
    }
}
