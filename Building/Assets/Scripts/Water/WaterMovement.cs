﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour
{
    public float power = 3;
    public float scale = 1;
    public float timeScale = 1;

    private float offsetX;
    private float offsetY;
    private MeshFilter waterFilter;

    // Start is called before the first frame update
    void Start()
    {
        waterFilter = GetComponent<MeshFilter>();
        DoNoise();
    }

    // Update is called once per frame
    void Update()
    {
        DoNoise();

        offsetX += Time.deltaTime * timeScale;
        if (offsetY <= 0.1) offsetY += Time.deltaTime * timeScale;
        if (offsetY >= power) offsetY -= Time.deltaTime * timeScale;

        var texture = GetComponent<Texture>();
        GetComponent<Material>().mainTextureOffset = GetComponent<Material>().mainTextureOffset + Vector2.up * Time.deltaTime;

    }

    private void DoNoise()
    {
        Vector3[] verticies = waterFilter.mesh.vertices;
        for(int i = 0; i < verticies.Length; i++)
        {
            verticies[i].y = CalculateHeigth(verticies[i].x, verticies[i].z) * power;
        }
        waterFilter.mesh.vertices = verticies;
    }

    private float CalculateHeigth(float x, float y)
    {
        float xCoord = x * scale * offsetX;
        float yCoord = y * scale * offsetY;
        return Mathf.PerlinNoise(xCoord, yCoord);
    }

}
