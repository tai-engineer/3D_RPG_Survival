using System;
using UnityEngine;
using Sirenix.OdinInspector;
namespace TV
{
    public class Collectible : MonoBehaviour
    {
        [Required]
        public ItemSO itemData;
        [ShowInInspector]
        private bool interacted = false;
        public ItemSO Pickup()
        {
            interacted = true;
            return itemData;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!interacted) return;
            
            gameObject.SetActive(false);
        }
    }
}