using System;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Random = UnityEngine.Random;

namespace TV.LootTable
{
    public class LootTable : MonoBehaviour
    {
        public enum Rarity
        {
            Common, Uncommon, Rare, Epic, Legendary, Mythic
        }
        [System.Serializable]
        public class Item
        {
            public GameObject prefab;
            public int probability;
            public Rarity rarity;
        }
        public List<Item> itemList = new List<Item>();
        [Button]
        public Item DropItem()
        {
            int roll = Random.Range(0, 100);
            Debug.Log(roll);
            foreach (var item in itemList)
            {
                if (roll <= item.probability)
                {
                    Debug.Log($"Instantiate Item {item.probability}");
                    return item;
                }
            }

            return null;
        }
    }
}