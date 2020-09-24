using System;
using UnityEngine;
using UnityEngine.Events;

public class Hovered : MonoBehaviour
{
    public float startScale = 0.6f;
    public float scale = 1f;
    private void OnMouseEnter()
    {
        transform.position += new Vector3(0,0,-1);
        transform.localScale = new Vector3(scale, scale);
    }

    private void OnMouseExit()
    {
        transform.position += new Vector3(0,0,1);
        transform.localScale = new Vector3(startScale,startScale);
    }
}