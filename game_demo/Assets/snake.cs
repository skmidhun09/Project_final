using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake : MonoBehaviour {
    public GameObject cube;
    public GameObject cylind;
    public GameObject sphere;
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;
    public GameObject s6;
    float a,b;
	// Use this for initialization
	void Start () {
        a = Time.deltaTime * 360;
        b = 2.0f;
        cylind.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(a, 0, 0);
        transform.Rotate(0, 0, a);
        a = a + 0.1f;
        if (Input.GetKeyDown(KeyCode.A))
        {
            cube.GetComponent<Rigidbody>().useGravity = true; 
        }
        if (transform.position.y < 2)
        {
            a = 0;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            cube.GetComponent<Rigidbody>().useGravity = false;
            cube.transform.position = sphere.transform.position;
            a = Time.deltaTime * 360;
            if(s1.transform.position.y > s2.transform.position.y && s1.transform.position.y > s3.transform.position.y && s1.transform.position.y > s4.transform.position.y && s1.transform.position.y > s5.transform.position.y && s1.transform.position.y > s6.transform.position.y)
            {
                while (b <= 2)
                {
                    if (cylind.transform.position.x != 9)
                    {
                        cylind.transform.Translate(2, 0, 0);
                        b = b + 2.0f;
                    }
                    else
                    {
                        cylind.transform.position=new Vector3(-9, 1, cylind.transform.position.z + 2);
                        b = b + 2.0f;
                    }
                }
                b = 2.0f;
            }
            else if (s2.transform.position.y > s1.transform.position.y && s2.transform.position.y > s3.transform.position.y && s2.transform.position.y > s4.transform.position.y && s2.transform.position.y > s5.transform.position.y && s2.transform.position.y > s6.transform.position.y)
            {
                while (b <= 4)
                {
                    if (cylind.transform.position.x != 9)
                    {
                        cylind.transform.Translate(2, 0, 0);
                        b = b + 2.0f;
                    }
                    else
                    {
                        cylind.transform.position=new Vector3(-9, 1, cylind.transform.position.z + 2);
                        b = b + 2.0f;
                    }
                }
                b = 2.0f;
            }
            else if (s3.transform.position.y > s2.transform.position.y && s3.transform.position.y > s1.transform.position.y && s3.transform.position.y > s4.transform.position.y && s3.transform.position.y > s5.transform.position.y && s3.transform.position.y > s6.transform.position.y)
            {
                while (b <= 6)
                {
                    if (cylind.transform.position.x != 9)
                    {
                        cylind.transform.Translate(2, 0, 0);
                        b = b + 2.0f;
                    }
                    else
                    {
                        cylind.transform.position=new Vector3(-9, 1, cylind.transform.position.z + 2);
                        b = b + 2.0f;
                    }
                }
                b = 2.0f;
            }
            else if (s4.transform.position.y > s2.transform.position.y && s4.transform.position.y > s3.transform.position.y && s4.transform.position.y > s1.transform.position.y && s4.transform.position.y > s5.transform.position.y && s4.transform.position.y > s6.transform.position.y)
            {
                while (b <= 8)
                {
                    if (cylind.transform.position.x != 9)
                    {
                        cylind.transform.Translate(2, 0, 0);
                        b = b + 2.0f;
                    }
                    else
                    {
                        cylind.transform.position=new Vector3(-9, 1, cylind.transform.position.z + 2);
                        b = b + 2.0f;
                    }
                }
                b = 2.0f;
            }
            else if (s5.transform.position.y > s2.transform.position.y && s5.transform.position.y > s3.transform.position.y && s5.transform.position.y > s4.transform.position.y && s5.transform.position.y > s1.transform.position.y && s5.transform.position.y > s6.transform.position.y)
            {
                while (b <= 10)
                {
                    if (cylind.transform.position.x != 9)
                    {
                        cylind.transform.Translate(2, 0, 0);
                        b = b + 2.0f;
                    }
                    else
                    {
                        cylind.transform.position=new Vector3(-9, 1, cylind.transform.position.z + 2);
                        b = b + 2.0f;
                    }
                }
                b = 2.0f;
            }
            else
            {
                while (b <= 12)
                {
                    if (cylind.transform.position.x != 9)
                    {
                        cylind.transform.Translate(2, 0, 0);
                        b = b + 2.0f;
                    }
                    else
                    {
                        cylind.transform.position=new Vector3(-9, 1, cylind.transform.position.z + 2);
                        b = b + 2.0f;
                    }
                }
                b = 2.0f;
            }
        }
    }
      
}
