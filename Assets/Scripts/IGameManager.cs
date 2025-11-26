using UnityEngine;

public interface IGameManager
{    
    ManagerStatus status { get; }

    void Startup();
}

public enum ManagerStatus
{
    Shutdown,
    Initializing,
    Started
}
