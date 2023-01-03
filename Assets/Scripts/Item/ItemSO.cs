using UnityEngine;
using Sirenix.OdinInspector;

namespace TV
{
    [CreateAssetMenu(fileName = "New Item", menuName = "Items/Item")]
    public class ItemSO : ScriptableObject
    {
        #region General
        [TabGroup("General"), PropertyOrder(-1)]
        [ShowInInspector]
        public int id { get; private set; }
        
        [TabGroup("General"), PropertyOrder(0)]
        [ShowInInspector, AssetsOnly, PreviewField]
        public Sprite icon { get; private set; }
        
        [TabGroup("General"), PropertyOrder(1)]
        [SerializeField,TextArea(10, 10)]
        private string description;
        
        [TabGroup("General"), PropertyOrder(2)]
        [ShowInInspector]
        public string displayName { get; private set; }
        
        [TabGroup("General"), PropertyOrder(3)]
        [ShowInInspector]
        public Rarity rarity  { get; private set; }
        #endregion

        #region Stats
        [ShowInInspector, TabGroup("Stats")]
        public int damage  { get; private set; }
        [ShowInInspector, TabGroup("Stats")]
        public int defense  { get; private set; }
        [ShowInInspector, TabGroup("Stats")]
        public int health  { get; private set; }
        [ShowInInspector, TabGroup("Stats")]
        public int mana  { get; private set; }
        #endregion
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
