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

        delegate bool ItemSelector(Item item);

        static bool IsWeapon(Item item)
        {
            return item.ItemType == ItemType.Weapon;
        }

        static Item FindWeapon(ItemSelector selector)
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

            Item item = FindWeapon(IsWeapon);
        }
    }
}
