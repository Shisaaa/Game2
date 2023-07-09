using UnityEngine;

public class NewBehaviourScript : MonoBehaviour 
{
    public int width = 256;
    public int height = 256;
    public float scale = 0.15f;
    public Terrain noiseTerrain;
    private Noise _noise;
    
    private void Start() 
    {
        _noise = new PerlinNoise();
        _GenerateHeights();
    }
    

    private void _GenerateHeights() 
    {
        float[,] heights = new float[width, height];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                heights[y, x] = _noise.GetNoiseMap(x, y, 0.15f);
            }
        }

        _SetNoiseTexture(heights);
    }

    private void _SetNoiseTexture(float[,] noise)
    {
        noiseTerrain.terrainData.SetHeights(0,0, noise);
    }

    // private float CalculateHeight(int x, int y, float scale=1) 
    // {
    //     float xCoord = (float)x * scale ;
    //     float yCoord = (float)y * scale ;

    //     // return Mathf.PerlinNoise(xCoord, yCoord) * ((Mathf.Pow(xCoord, 4) + Mathf.Pow(yCoord, 4)) / 10);
    //     return Mathf.PerlinNoise(xCoord, yCoord);
    // }
}

