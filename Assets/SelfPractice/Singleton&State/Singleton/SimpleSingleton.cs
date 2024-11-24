using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSingleton : MonoBehaviour
{
    private static SimpleSingleton instance;
    public static SimpleSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                SetupInstance();
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private static void SetupInstance()
    {
        instance = FindObjectOfType<SimpleSingleton>();

        if (instance == null)
        {
            GameObject gameObj = new GameObject();
            gameObj.name = "Singleton";
            instance = gameObj.AddComponent<SimpleSingleton>();
            DontDestroyOnLoad(gameObj);
        }
    }
}
