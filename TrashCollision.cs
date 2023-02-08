using JetBrains.Annotations;
using Leap;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrashCollision : MonoBehaviour
{

    public List<string> trashList = new List<string>();

    void Start()
    {


    }
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < trashList.Count; i++)
        {

            if (collision.collider.gameObject.name == trashList[i].ToString())
            {
                collision.collider.gameObject.SetActive(false);
                collision.collider.gameObject.transform.position = new Vector3(0, 0, 2);
            }
            else
            {

                collision.collider.gameObject.transform.position = new Vector3(0, 0, 2);



            }

        }



    }


}
