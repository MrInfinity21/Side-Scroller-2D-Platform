using System;
using Code.Scripts.Player;
using UnityEngine;

namespace Code.Scripts.Utility
{
    public class Collectable : MonoBehaviour
    {
        [SerializeField] protected CollectableEventData _data;
        [SerializeField] protected int _value = 1;
        private void OnTriggerEnter2D(Collider2D other)
        {
            
            if (other.TryGetComponent<PlayerController>(out PlayerController player))
            {
                _data.Collect(_value);
                Destroy(this.gameObject);
            }
        }
    }
}