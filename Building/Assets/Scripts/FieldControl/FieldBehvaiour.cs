using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldBehvaiour : MonoBehaviour
{
    public GameObject fieldPrefabList;
    public FieldPrefabs prefabList;


    // Start is called before the first frame update
    void Start()
    {
        prefabList = fieldPrefabList.GetComponent<FieldPrefabs>();

        int randomMaterialIndex = Random.Range(1, 4);
        switch(randomMaterialIndex)
        {
            case 1:
                GetComponent<Renderer>().material = prefabList.fieldMaterialGras;
                GenerateVegetation();
                break;
            case 2:
                GetComponent<Renderer>().material = prefabList.fieldMaterialSand;
                GenerateDessert();
                break;
            case 3:
                GetComponent<Renderer>().material = prefabList.fieldMaterialStone;
                GenerateRocks();
                break;
        }



    }

    void GenerateVegetation()
    {
        int veggieIndex = Random.Range(0, 4);
        switch(veggieIndex)
        {
            case 0:
                // nothing :)
                break;
            case 1:
                Instantiate(prefabList.tree1, new Vector3(this.transform.position.x, 2.3f, this.transform.position.z), prefabList.tree1.transform.rotation, this.transform);
                break;
            case 2:
                Instantiate(prefabList.tree2, new Vector3(this.transform.position.x, 2.3f, this.transform.position.z), prefabList.tree2.transform.rotation, this.transform);
                break;
            case 3:
                Instantiate(prefabList.tree3, new Vector3(this.transform.position.x, 2.3f, this.transform.position.z), prefabList.tree3.transform.rotation, this.transform);
                break;
            case 4:
                Instantiate(prefabList.plant1, new Vector3(this.transform.position.x, 2.3f, this.transform.position.z), prefabList.plant1.transform.rotation, this.transform);
                break;
        }
    }

    void GenerateDessert()
    {

    }

    void GenerateWildlife()
    {
        // mob enties
    }

    void GenerateRocks()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
