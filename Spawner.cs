using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> itemlist = new List<GameObject>();

    public void ShowObject()
    {
        int someNum = Random.Range(0, itemlist.Count);
        GameObject showMe = itemlist[someNum];
        showMe.SetActive(true);


    }



    // Start is called before the first frame update
    void Start()
    {
        ShowObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
