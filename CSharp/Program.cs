using System;
using System.Collections.Generic;

namespace CSharp
{


    enum ItemType
    {
        Weapon, 
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare,
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    
    }


    // Lambda : 일회용 함수를 만드는데 사용하는 문법이다.
    class Program
    {

        static List<Item> _items = new List<Item>();

        static Item FindItem(Func<Item, bool> selector) // 아이템 찾기
        {
            foreach(Item item in _items)
            {
                if (selector(item)) // true인경우 item을 리턴
                    return item;
            }
            return null;
        }



        static void Main(string[] args)
        {

            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            // delegate를 직접 선언하지 않아도, 이미 만드러진 애들이 존재한다.
            // -> 반환 타입이 있을 경우 Func
            // -> 반환 타입이 없으면 Action
            
            
            // Anonoymous Function : 무명 함수 / 익명 함수 
            // 방법 1. delegate 일회성
            //Item item = FindItem(delegate (Item itm){ return itm.ItemType == ItemType.Weapon; });
            // 방법 2. 람다식
            Item item = FindItem((Item itm) => { return itm.ItemType == ItemType.Weapon; });


        }
    }
}
