using UnityEngine;

public class GameLoopLogger : MonoBehaviour
{
    void Awake()
    {
        //Debug.Log($"Awake {gameObject.name}");
    }

    void Start()
    {
        // Debug.Log($"Start {gameObject.name}");
    }

    void Update()
    {
        // Debug.Log($"Update {gameObject.name}");
    }

    void FixedUpdate()
    {
        // Debug.Log($"Fixed Update {gameObject.name}");
    }

    public void SetName(string name)
    {
        gameObject.name = name;
    }
}
