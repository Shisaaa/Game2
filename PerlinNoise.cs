using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise : Noise
{
    public override float GetNoiseMap(float x, float y, float scale = 1f)
    {

        float xCoord = (float)x * scale ;
        float yCoord = (float)y * scale ;

        return Mathf.PerlinNoise(xCoord, yCoord) * ((xCoord * yCoord) / 501);
        // return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
