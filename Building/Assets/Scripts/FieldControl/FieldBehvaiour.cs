using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldBehvaiour : MonoBehaviour
{
    public GameObject fieldPrefabList;
    public FieldPrefabs prefabList;

    public GameObject placedObject;

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
        RefreshBuilding();
    }

    public void RefreshBuilding()
    {
        if(placedObject != null)
        {
            // delete child object
            if (this.transform.childCount > 0)
                Destroy(this.transform.GetChild(0));
            Instantiate(placedObject, new Vector3(this.transform.position.x, 2.3f, this.transform.position.z), placedObject.transform.rotation, this.transform);
        }
        
    }

    void GenerateVegetation()
    {
        int veggieIndex = Random.Range(0, 4);
        switch(veggieIndex)
        {
            case 1:
                placedObject = prefabList.tree1;
                break;
            case 2:
                placedObject = prefabList.tree2;
                break;
            case 3:
                placedObject = prefabList.tree3;
                break;
            case 4:
                placedObject = prefabList.plant1;
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

        var texture = GetComponent<Texture>();
        GetComponent<Material>().mainTextureOffset = GetComponent<Material>().mainTextureOffset + Vector2.up * Time.deltaTime;


    }
}
