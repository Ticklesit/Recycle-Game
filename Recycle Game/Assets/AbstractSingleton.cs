using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractSingleton<T> : MonoBehaviour where T:MonoBehaviour
{
    // The T above is a type to be set
    // Start is called before the first frame update
    // intenral means this is accerssible from other class
    internal static T instance;
    private static T instanceNoAccess;

    public static T GetInstance
    {
        get { return instance; }
        internal set
        {
            if (instance == null)
            {
                instance = value;
            }
            else if (instance != value)
            {
                Destroy(value);
            }
        }
    }

    public void Awake()
    {
        GetInstance = GetComponent<T>();
    }
}
