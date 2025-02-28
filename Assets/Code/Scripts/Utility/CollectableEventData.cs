using System;
using UnityEngine;

namespace Code.Scripts.Utility
{
    [CreateAssetMenu(fileName = "CollectableEventData", menuName = "SOs/CollectableEventData", order = 0)]
    public class CollectableEventData : ScriptableObject
    {
        public event Action<int> Collected;
        public void Collect(int value) => Collected?.Invoke(value);
    }
}