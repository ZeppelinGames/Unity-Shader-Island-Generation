using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Tilemap))]
public class GenerateWorld : MonoBehaviour
{
    public Material mapGenMat;
    public Texture2D mapTex;
    private Tilemap tileMap;

    private void Start()
    {
        tileMap = GetComponent<Tilemap>();

        GenerateMap();
    }

    void GenerateMap(int mapSize = 50, int seed = 0)
    {
        Debug.Log("Generating map");
        mapGenMat.SetInt("_MapSize", mapSize);
        mapGenMat.SetInt("_Seed", seed);

        mapTex = new Texture2D(1024, 1024);

        RenderTexture rendTexture = new RenderTexture(1024, 1024,1);
        Graphics.Blit(Texture2D.whiteTexture, null, mapGenMat);

        /*        var old_rt = RenderTexture.active;

                RenderTexture.active = rendTexture;
                mapTex.ReadPixels(new Rect(0, 0, rendTexture.width, rendTexture.height), 0, 0);
                mapTex.Apply();

                RenderTexture.active = old_rt;*/
    }
}
