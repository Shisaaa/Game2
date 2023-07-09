using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoiseImage : MonoBehaviour
{
    public RawImage noiseTextureImage;

    private Noise _noise;

    public int width = 256;
    public int height = 256;
    
    private void Awake()
    {
        _noise = new PerlinNoise();
        _RecomputeNoise();
    }

    private void _RecomputeNoise()
    {
        float[,] noise = new float[width, height];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                noise[x, y] = _noise.GetNoiseMap(x, y, 0.15f);
            }
        }
        _SetNoiseTexture(noise);
    }

    private void _SetNoiseTexture(float[,] noise)
    {
        Color[] pixels = new Color[width * height];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                
                Color s = Color.Lerp(Color.black, Color.white, noise[x, y]);
                pixels[x + width * y] = s;
            }
        }
        Texture2D texture = new Texture2D(width, height);
        texture.SetPixels(pixels);
        texture.Apply();
        noiseTextureImage.texture = texture;
    }
}
