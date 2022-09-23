using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Namer prefab;
    public int numLoops;

    void Start()
    {
        for (int i = 0; i < numLoops; i++)
        {
            var instance = Instantiate(prefab);
            // instance.SetName(i);

            instance.GetComponent<GameLoopLogger>().SetName($"GameObject{i}");
            instance.transform.GetChild(0).GetComponent<GameLoopLogger>().SetName($"GameObject{i}");
        }
    }
}
