using UnityEngine;

namespace TV.LootTable
{
    [CreateAssetMenu(fileName = "New Armor", menuName = "Item/Armor", order = 0)]
    public class Armor : Item
    {
        public uint Defense { get; set; }
    }
}