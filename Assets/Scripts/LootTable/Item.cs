using UnityEngine;
using Sirenix.OdinInspector;
namespace TV.LootTable
{
    public class Item : ScriptableObject
    {
        [Required]
        public GameObject prefab;
        public uint probability;
        public Rarity rarity;
        public uint min;
        public uint max;
        public string description;
    }
    public enum Rarity
    {
        Common, Uncommon, Rare, Epic, Legendary, Mythic
    }
}
