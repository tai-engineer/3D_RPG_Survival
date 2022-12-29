using UnityEngine;

namespace TV.LootTable
{
    [CreateAssetMenu(fileName = "New Potion", menuName = "Item/Potion", order = 0)]
    public class Potion : Item
    {
        public uint Health { get; set; }
        public uint Mana { get; set; }
    }
}