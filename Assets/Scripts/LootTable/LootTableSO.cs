using UnityEngine;
using System.Collections.Generic;
using Sirenix.OdinInspector;

namespace TV.LootTable
{
    [CreateAssetMenu(fileName = "New Loot Table", menuName = "Loot Table", order = 0)]
    public class LootTableSO : ScriptableObject
    {
        public List<DroppableItem> dropList;

    }
    
    [System.Serializable]
    public class DroppableItem
    {
        public ItemSO item;
        [MinValue(0)]
        public int probability;
        [MinValue(0)]
        public int min;
        [MinValue(0)]
        public int max;
    }
}