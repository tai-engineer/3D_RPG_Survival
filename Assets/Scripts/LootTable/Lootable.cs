using UnityEngine;
using Sirenix.OdinInspector;
using Random = UnityEngine.Random;

namespace TV.LootTable
{
    public class Lootable: MonoBehaviour
    {
        [Required]
        public LootTable lootTable;
        
        [Button]
        public Item GetDrop()
        {
            int roll = Random.Range(0, 100);
            foreach (var drop in lootTable.dropList)
            {
                if (roll <= drop.probability)
                {
                    int amount = Mathf.RoundToInt(Random.Range(drop.min, drop
                    .max));
                    return new Item(drop.item, amount);
                }
            }

            return null;
        }
    }
    
    
}