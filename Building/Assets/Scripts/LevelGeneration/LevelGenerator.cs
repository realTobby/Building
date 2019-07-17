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

        float cornerX = 0f;
        float cornerY = 0f;

        float realY = 0f;

        for(int row = 0; row < 10; row++)
        {
            if (row % 2 == 0)
            {
                cornerX = 0f;
                cornerY = 0f;
                
            }
            else
            {
                cornerX = -1.7f;
                cornerY = -.8f;
            }
            for(float field = cornerY; field < 10; field+=1.8f)
            {
                Instantiate(prefabHexagonBaseTile, new Vector3(field, 0, realY), prefabHexagonBaseTile.transform.rotation, parent.transform);

            }
            realY += 1.7f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
