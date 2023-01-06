using UnityEngine;
using Sirenix.OdinInspector;
using Random = UnityEngine.Random;
namespace TV
{
    public class LootBox: MonoBehaviour
    {
        [Required]
        public LootTableSO lootTable;
        
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