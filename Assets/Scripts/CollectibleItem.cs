using System;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] private string itemName;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Item collected: {itemName}");
        Managers.Inventory.AddItem(itemName);
        Destroy(gameObject);
    }
}
