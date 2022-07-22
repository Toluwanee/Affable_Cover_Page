using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changecolour : MonoBehaviour
{

    public Color[] colors;
    public Renderer[] mats;

    public void Purple()
    {
        for (int i = 0; i < mats.Length; i++)
            mats[i].material.color = colors[0];
    }
    
    public void Green()
    {
        for (int i = 0; i < mats.Length; i++)
            mats[i].material.color = colors[1];
    }
    
    public void Blue()
    {
        for (int i = 0; i < mats.Length; i++)
            mats[i].material.color = colors[2];
    }
    
    public void Brown()
    {
        for (int i = 0; i < mats.Length; i++)
            mats[i].material.color = colors[3];
    }

}
