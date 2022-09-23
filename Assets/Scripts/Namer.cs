using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Namer : MonoBehaviour
{
    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject child;

    public void SetName(int index)
    {
        parent.name = $"GameObject{index}";
        child.name = $"GameObjectChild{index}";
    }
}
