using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public int randomTileNumber = 0;
    public GameObject prefabHexagonBaseTile;


    // Start is called before the first frame update
    void Start()
    {
        var parent = GameObject.FindGameObjectWithTag("baseFieldList");

        randomTileNumber = Random.Range(10, 25);


        Instantiate(prefabHexagonBaseTile, new Vector3(0,0,0), prefabHexagonBaseTile.transform.rotation, parent.transform);
        Instantiate(prefabHexagonBaseTile, new Vector3(-1.75f, 0, 0), prefabHexagonBaseTile.transform.rotation, parent.transform);
        Instantiate(prefabHexagonBaseTile, new Vector3(1.75f, 0, 0), prefabHexagonBaseTile.transform.rotation, parent.transform);


        Instantiate(prefabHexagonBaseTile, new Vector3(.9f, 0, -1.55f), prefabHexagonBaseTile.transform.rotation, parent.transform);
        Instantiate(prefabHexagonBaseTile, new Vector3(.9f, 0, 1.55f), prefabHexagonBaseTile.transform.rotation, parent.transform);

        Instantiate(prefabHexagonBaseTile, new Vector3(-.9f, 0, -1.55f), prefabHexagonBaseTile.transform.rotation, parent.transform);
        Instantiate(prefabHexagonBaseTile, new Vector3(-.9f, 0, 1.55f), prefabHexagonBaseTile.transform.rotation, parent.transform);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
