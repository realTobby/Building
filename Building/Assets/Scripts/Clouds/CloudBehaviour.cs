﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBehaviour : MonoBehaviour
{
    private float cloudSpeed = 0.6f;

    // Start is called before the first frame update
    void Start()
    {
        RandomScale();
    }

    void RandomScale()
    {
        this.transform.localScale = new Vector3(Random.Range(1f, 3f), 0.2f, Random.Range(1f, 3f));
    }

    void RandomStartPosition(float startX, float endX)
    {
        this.transform.position = new Vector3(Random.Range(startX, endX), Random.Range(this.transform.position.y-2, this.transform.position.y+1), Random.Range(-20,20));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x - cloudSpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z);

        if(this.transform.position.x <= -10f)
        {
            RandomScale();
            RandomStartPosition(30, 50);
        }
    }

    public void InitMainScreen()
    {
        RandomStartPosition(0, 30);
    }

    public void InitOffScreen()
    {
        RandomStartPosition(30, 50);
    }
}
