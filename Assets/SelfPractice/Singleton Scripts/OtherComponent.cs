using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherComponent : MonoBehaviour
{
    void Start()
    {
        var newGameObject = new GameObject().AddComponent<SingletonComponent>();
    }

    void Update()
    {
        
    }
}
