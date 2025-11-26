using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public ManagerStatus status { get; private set; }

    public void Startup()
    {
        Debug.Log("Invetory manager starting.!.");
        status = ManagerStatus.Started;
    }
}
