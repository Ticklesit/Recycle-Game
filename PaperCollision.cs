using JetBrains.Annotations;
using Leap;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PaperCollision : MonoBehaviour
{

    public List<string> paperList = new List<string>();

    void Start()
    {


    }
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < paperList.Count; i++)
        {

            if (collision.collider.gameObject.name == paperList[i].ToString())
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
