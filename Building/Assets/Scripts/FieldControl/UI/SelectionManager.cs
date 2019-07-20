using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public string selectableTag = "baseField";

    public GameObject referenceMarker;
    private Transform _selection;
    private GameObject currentMarker;

    // Start is called before the first frame update
    void Start()
    {
        if(referenceMarker != null)
            currentMarker = Instantiate(referenceMarker, new Vector3(0,0,0), referenceMarker.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(_selection != null)
        {
            if(currentMarker != null)
                currentMarker.transform.position = new Vector3(0,-100,0);
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.transform.CompareTag(selectableTag))
            {
                _selection = hit.transform;

                if (currentMarker != null)
                    currentMarker.transform.position = new Vector3(_selection.position.x, 0.2f, _selection.position.z);
            }
            
        }


    }
}
