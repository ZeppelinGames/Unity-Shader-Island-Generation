using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditMap : MonoBehaviour
{
    public Material mapMaterial;

    public static EditMap instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void SetPalette(Texture2D pal)
    {
        mapMaterial.SetTexture("_Palette", pal);
    }

    public void SetMapSize(string size)
    {
        if (float.TryParse(size, out float f))
        {
            mapMaterial.SetFloat("_MapSize", f);
        }
    }

    public void SetIslandSize(string size)
    {
        if (float.TryParse(size, out float f))
        {
            mapMaterial.SetFloat("_IslandSize", f);
        }
    }

    public void SetSeed(string seed)
    {
        if (int.TryParse(seed, out int f))
        {
            mapMaterial.SetInt("_Seed", f);
        }
    }

    public void SetDistortion(float dist)
    {
        mapMaterial.SetFloat("_IslandDistortion", dist);
    }

    public void SetRiverWidth(float width)
    {
        mapMaterial.SetFloat("_RiverWidth", width);
    }
}
