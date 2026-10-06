using System;
using UnityEngine;

public class RandomSphereColors : MonoBehaviour
{
    public Color[] colors = new Color[3];

    private Renderer[] childRenderers;

    void Start()
    {
        childRenderers = GetComponentsInChildren<Renderer>();

        InvokeRepeating("UpdateColors", 0f, 2f);
    }

    void UpdateColors()
    {
        for (int i = 0; i < childRenderers.Length; i++)
        {
            int b = Random.Range(0, colors.Length);

            childRenderers[i].material.color = colors[b];
        }
    }
}
