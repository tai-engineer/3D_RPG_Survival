using System;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Random = UnityEngine.Random;

namespace TV.LootTable
{
    public class LootTable : MonoBehaviour
    {
        public List<Item> itemList = new List<Item>();
        [Button]
        public void DropItem()
        {
            int roll = Random.Range(0, 100);
            foreach (var item in itemList)
            {
                if (roll <= item.probability)
                {
                    var quantity = Random.Range(item.min, item.max);
                    for (int i = 0; i < quantity; i++)
                    {
                        Instantiate(item.prefab);
                    }
                    return;
                }
            }
        }
    }
}