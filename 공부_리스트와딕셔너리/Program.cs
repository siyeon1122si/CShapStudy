using _230614;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



public class Program
{
    static void Main(string[] args)
    {
        
    }     // main()



    public static void Desc001()
    {
        //Print1 printClass = new Print1();
        //printClass.PrintMessage();

        Print1.staticMessage = " 여기에 값이 들어가나 ?";
        Console.WriteLine(Print1.staticMessage);


        // List
        List<int> numbers = new List<int>();
        Console.WriteLine(" 내 리스트의 크기는 몇일까? -> {0}", numbers.Count);

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(i + 1);
        }
        foreach (int n in numbers)
        {
            Console.Write("{0} ", n);
        }
        Console.WriteLine();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 1)
            {
                Console.WriteLine("내가 지우려는 데이터 -> {0}", numbers[i]);
                Console.WriteLine("내 리스트의 크기 -> {0}", numbers.Count);
                numbers.Remove(i);
            }
        }
    }
    public static void Desc002()
    {
        // Dictionary
        Dictionary<string, int> myInventory = new Dictionary<string, int>();
        myInventory.Add("빨간 포션", 5);
        myInventory.Add("골드", 500);
        myInventory.Add("몰락한 왕의 검", 1);

        ItemInfo redPotion = new ItemInfo();
        redPotion.InitItem(" 빨간 포션 ", 5, 100);
        ItemInfo goid = new ItemInfo();
        goid.InitItem(" 골드 ", 500, 1);
        ItemInfo sword = new ItemInfo();
        sword.InitItem(" 몰락한 왕의 검 ", 1, 39800);

        Dictionary<string, ItemInfo> myInventory2 = new Dictionary<string, ItemInfo>();
        myInventory2.Add(" 빨간 포션 ", redPotion);
        myInventory2.Add(" 골드 ", goid);
        myInventory2.Add(" 몰락한 왕의 검 ", sword);

        foreach (var item in myInventory2)
        {
            Console.WriteLine("아이템 이름 : {0} , 아이템 갯수 : {1} , 아이템 가격 : {2} ",
            item.Value.itemName, item.Value.itemCount, item.Value.ItemPrice);
        }


        //foreach (KeyValuePair<string, int> item in myInventory) // 방법 1
        //{
        //    Console.WriteLine("아이템 이름 : {0} , 아이템 갯수 {1} ", item.Key, item.Value);
        //}
        //Console.WriteLine(" 아이템 갯수 : {0}", myInventory["빨간 포션"]); // 방법 2 : 갯수를 가져온다 대신 빨간 포션 이라는 이름을 가져올 수는 없다


    }

    public static void Desc003()
    {
        // 내가 정의한 enum 타입 변수를 선언해 볼 것임
        ItemType_SY itemType;

        itemType = ItemType_SY.POTION;
        Console.WriteLine("enum type은 무엇이라고 출력이 될까?? -> {0}", (int)itemType);

        if ((int)itemType == 0)
        {
            Console.WriteLine("itemType을 int로 형변환 한 값은 0과 같은 값이 맞다.");

        }

        switch (itemType)
        {
            case ItemType_SY.POTION:
                Console.WriteLine("이 아이템의 타입은 포션입니다.");
                break;
            case ItemType_SY.GOLD:
                Console.WriteLine("이 아이템의 타입은 골드입니다.");
                break;
            case ItemType_SY.WEAPON:
                Console.WriteLine("이 아이템의 타입은 총입니다.");
                break;
            case ItemType_SY.ARMOR:
                Console.WriteLine("이 아이템의 타입은 갑바입니다.");
                break;
            default:
                Console.WriteLine("이 아이템은 정의되지 않았습니다 ");
                break;
        }
    }  //enum
}



