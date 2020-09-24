using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListCardController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject [] list;
    public GameObject start;
    public float rotate;
    public float width;
	public float height;

    void Start()
    {
        for (int i = 0; i < list.Length; i++)
        {
			var d = (i - list.Length / 2); 
            list[i] = Instantiate(start);
            Debug.Log(height * d);
            list[i].transform.position += new Vector3(d * width,  transform.position.y + height * (list.Length / 2 - Math.Abs(d)) , 0);
            list[i].transform.Rotate(0, 0, rotate * d);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
