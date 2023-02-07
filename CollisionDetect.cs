using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.gameObject.name);
        GameObject searchObject = collision.collider.gameObject;
        if (searchObject.name == "Glass")
        {
            Debug.Log("Glass");
        }
        if (searchObject.name == "Paper" || searchObject.name == "Cardboard")
        {
            Debug.Log("Paper/Cardboard");
        }
        if (searchObject.name == "Batteries")
        {
            Debug.Log("Batteries");
        }
        if (searchObject.name == "Trash")
        {
            Debug.Log("Trash");
        }
    
    
    
    
    }


}
