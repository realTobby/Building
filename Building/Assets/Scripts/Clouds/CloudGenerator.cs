using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
    private int cloudCount = 50;
    public GameObject cloudPrefab;

    // Start is called before the first frame update
    void Start()
    {
        var parentObject = GameObject.FindGameObjectWithTag("baseCloudList");


        for (int i = 0; i < cloudCount / 2; i++)
        {
            Instantiate(cloudPrefab, cloudPrefab.transform.position, cloudPrefab.transform.rotation, parentObject.transform).GetComponent<CloudBehaviour>().InitOffScreen();
        }

        for (int i = 0; i < cloudCount / 2; i++)
        {
            Instantiate(cloudPrefab, cloudPrefab.transform.position, cloudPrefab.transform.rotation, parentObject.transform).GetComponent<CloudBehaviour>().InitMainScreen();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
