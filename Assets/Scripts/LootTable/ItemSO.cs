using UnityEngine;
using Sirenix.OdinInspector;

namespace TV.LootTable
{
    [CreateAssetMenu(fileName = "New Item", menuName = "Items/Item")]
    public class ItemSO : ScriptableObject
    {
        [Required, AssetsOnly, ShowInInspector]
        public  GameObject prefab { get; private set; }
        [ShowInInspector]
        public Rarity rarity  { get; private set; }

        [SerializeField,TextArea(10, 10)]
        private string description;
        [ShowInInspector]
        public int damage  { get; private set; }
        [ShowInInspector]
        public int defense  { get; private set; }
        [ShowInInspector]
        public int health  { get; private set; }
        [ShowInInspector]
        public int mana  { get; private set; }
    }
    public enum Rarity
    {
        Common, Uncommon, Rare, Epic, Legendary, Mythic
    }
    public class Item
    {
        private readonly ItemSO itemData;
        /*TODO: this data should be managed by other class*/
        public int amount { get; }
        public int damage => itemData.damage;
        public int defense => itemData.defense;
        public int health => itemData.health;
        public int mana => itemData.mana;
        public Item(ItemSO itemData, int amount)
        {
            this.itemData = itemData;
            this.amount = amount;
        }
    }
    
}
