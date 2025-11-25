using System;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] private string itemName;

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"Item collected: {itemName}");
        Destroy(gameObject);
    }
}
