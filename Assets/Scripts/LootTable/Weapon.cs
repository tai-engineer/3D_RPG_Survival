using UnityEngine;

namespace TV.LootTable
{
    [CreateAssetMenu(fileName = "New Weapon", menuName = "Items/Weapon", order = 0)]
    public class Weapon : Item
    {
        public uint Damage { get; set; }
    }
}