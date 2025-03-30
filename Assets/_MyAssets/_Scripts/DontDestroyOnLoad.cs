using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    // This will make sure the object doesn't get destroyed on scene load
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
