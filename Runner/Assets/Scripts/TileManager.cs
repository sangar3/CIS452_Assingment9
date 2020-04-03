﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tileprefabs;
    public float zSpawn = 0;
    public float tileLength = 30;
    public int numberOfTiles = 6;
    private List<GameObject> activeTiles = new List<GameObject>();
    public Transform playerTransform;

    void Start()
    {
        for(int i=0; i< numberOfTiles; i++)
        {
            if(i==0)
            {
                SpawnTile(0);
            }
            else 
                SpawnTile(Random.Range(0, tileprefabs.Length));
        }

    }

   
    void Update()
    {
        if(playerTransform.position.z - 35 > zSpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tileprefabs.Length));
            DeleteTile();

        }
    }

    public void SpawnTile(int tileIndex)
    {
        GameObject go = Instantiate(tileprefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);

        zSpawn += tileLength;

    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
