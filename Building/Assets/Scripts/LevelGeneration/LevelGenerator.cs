using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public int playfieldSize = 25;

    public int randomTileNumber = 0;
    public GameObject prefabHexagonBaseTile;


    // Start is called before the first frame update
    void Start()
    {
        var parent = GameObject.FindGameObjectWithTag("baseFieldList");
        float cornerY = 0f;

        float realY = 0f;

        for(int row = 0; row < playfieldSize; row++)
        {
            if (row % 2 == 0)
            {
                cornerY = 0f;
            }
            else
            {
                cornerY = -.8f;
            }

            for(float field = cornerY; field < playfieldSize; field+=1.8f)
            {
                Instantiate(prefabHexagonBaseTile, new Vector3(field, prefabHexagonBaseTile.transform.position.y, realY), prefabHexagonBaseTile.transform.rotation, parent.transform);

            }
            realY += 1.6f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
