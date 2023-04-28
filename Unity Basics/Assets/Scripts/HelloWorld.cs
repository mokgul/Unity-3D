using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
	public Transform sphere;
	
	void Awake()
	{
		Debug.Log("Awake");
	}
		
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.Translate(0f, 0f, 4 * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Translate(0f, 0f, 4 * -1 * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Translate(4 * -1 * Time.deltaTime, 0f, 0f);
		}
		else if(Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Translate(4 * Time.deltaTime, 0f, 0f);
		}
		
		if(sphere != null)
		{
			this.transform.LookAt(sphere);
			if(Vector3.Distance(this.transform.position, sphere.position) > 1024 * Time.deltaTime)
			{
				this.transform.Translate(0f, 0f, 0.50f * Time.deltaTime);
			}
		}
    }
}
