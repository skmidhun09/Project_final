using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake : MonoBehaviour {
    public GameObject cube;
    public GameObject cylind;
    public GameObject sphere;
    public GameObject winner;
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;
    public GameObject s6;
    float a,b,start=0.0f;
	// Use this for initialization
	void Start () {
        a = Time.deltaTime * 360;
        b = 2.0f;
        cylind.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        //dice randomization
        transform.Rotate(a, 0, 0);
        transform.Rotate(0, 0, a);
        a = a + 0.1f;
        //dice condition
        if (Input.GetKeyDown(KeyCode.A))
        {
            cube.GetComponent<Rigidbody>().useGravity = true; 
        }
        if (transform.position.y < 2)
        {
            a = 0;
        }
        //cylinder position cotrl
        if (Input.GetKeyDown(KeyCode.R))
        {
            cube.GetComponent<Rigidbody>().useGravity = false; //dice respawn
            cube.transform.position = sphere.transform.position;
            a = Time.deltaTime * 360;
            if (start == 0)
            {
                if (s1.transform.position.y > s2.transform.position.y && s1.transform.position.y > s3.transform.position.y && s1.transform.position.y > s4.transform.position.y && s1.transform.position.y > s5.transform.position.y && s1.transform.position.y > s6.transform.position.y)
                {
                    cylind.transform.Translate(2, 0, 0);
                    start = 1;
                }
            }
            else
            {
                if (cylind.transform.position.z < 9)
                {
                    if (s1.transform.position.y > s2.transform.position.y && s1.transform.position.y > s3.transform.position.y && s1.transform.position.y > s4.transform.position.y && s1.transform.position.y > s5.transform.position.y && s1.transform.position.y > s6.transform.position.y)
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
                                cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
                                b = b + 2.0f;
                            }
                        }
                        b = 2.0f;
                    }
                }
                else
                {
                    if(cylind.transform.position.x==-9||cylind.transform.position.x==-7||cylind.transform.position.x==-5||cylind.transform.position.x==-3)
                    {
                        if (s1.transform.position.y > s2.transform.position.y && s1.transform.position.y > s3.transform.position.y && s1.transform.position.y > s4.transform.position.y && s1.transform.position.y > s5.transform.position.y && s1.transform.position.y > s6.transform.position.y)
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
                                    b = b + 2.0f;
                                }
                            }
                            b = 2.0f;
                        }
                    }
                    else if(cylind.transform.position.x==-1)
                    {
                        if (s1.transform.position.y > s2.transform.position.y && s1.transform.position.y > s3.transform.position.y && s1.transform.position.y > s4.transform.position.y && s1.transform.position.y > s5.transform.position.y && s1.transform.position.y > s6.transform.position.y)
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
                                    b = b + 2.0f;
                                }
                            }
                            b = 2.0f;
                        }
                    }
                    else if(cylind.transform.position.x==1)
                    {
                        if (s1.transform.position.y > s2.transform.position.y && s1.transform.position.y > s3.transform.position.y && s1.transform.position.y > s4.transform.position.y && s1.transform.position.y > s5.transform.position.y && s1.transform.position.y > s6.transform.position.y)
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
                                    b = b + 2.0f;
                                }
                            }
                            b = 2.0f;
                        }
                    }
                    else if(cylind.transform.position.x==3)
                    {
                        if (s1.transform.position.y > s2.transform.position.y && s1.transform.position.y > s3.transform.position.y && s1.transform.position.y > s4.transform.position.y && s1.transform.position.y > s5.transform.position.y && s1.transform.position.y > s6.transform.position.y)
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
                                    b = b + 2.0f;
                                }
                            }
                            b = 2.0f;
                        }
                    }
                    else if(cylind.transform.position.x==5)
                    {
                        if (s1.transform.position.y > s2.transform.position.y && s1.transform.position.y > s3.transform.position.y && s1.transform.position.y > s4.transform.position.y && s1.transform.position.y > s5.transform.position.y && s1.transform.position.y > s6.transform.position.y)
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
                                    b = b + 2.0f;
                                }
                            }
                            b = 2.0f;
                        }
                    }
                    else if(cylind.transform.position.x==7)
                    {
                        if (s1.transform.position.y > s2.transform.position.y && s1.transform.position.y > s3.transform.position.y && s1.transform.position.y > s4.transform.position.y && s1.transform.position.y > s5.transform.position.y && s1.transform.position.y > s6.transform.position.y)
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
                                    cylind.transform.position = new Vector3(-9, 1, cylind.transform.position.z + 2);
                                    b = b + 2.0f;
                                }
                            }
                            b = 2.0f;
                        }
                    }
                }
            }
           
        }
        if (cylind.transform.position.x == 9&&cylind.transform.position.z==9)
        {
            winner.transform.position = new Vector3(-7.56f, 8, 0);
            Application.Quit();
        }
        //ladder from here
        if (cylind.transform.position.x == -5 && cylind.transform.position.z == -9)
            cylind.transform.position=new Vector3(-9, 1, 1);
        if (cylind.transform.position.x == 1 && cylind.transform.position.z == -9)
            cylind.transform.position = new Vector3(3, 1, -5);
        if (cylind.transform.position.x == 9 && cylind.transform.position.z == -7)
            cylind.transform.position = new Vector3(-9, 1, 3);
        if (cylind.transform.position.x == -5 && cylind.transform.position.z == 3)
            cylind.transform.position = new Vector3(-1, 1, 9);
        if (cylind.transform.position.x == 5 && cylind.transform.position.z == 3)
            cylind.transform.position = new Vector3(5, 1, 9);
        if (cylind.transform.position.x == -1 && cylind.transform.position.z == -5)
            cylind.transform.position = new Vector3(-1, 1, -9);
        //snake from now
        if (cylind.transform.position.x == -3 && cylind.transform.position.z == -3)
            cylind.transform.position = new Vector3(-9, 1, -9);
        if (cylind.transform.position.x == 3 && cylind.transform.position.z == -1)
            cylind.transform.position = new Vector3(7, 1, -7);
        if (cylind.transform.position.x == -1 && cylind.transform.position.z == 3)
            cylind.transform.position = new Vector3(-7, 1, 1);
        if (cylind.transform.position.x == 3 && cylind.transform.position.z == 7)
            cylind.transform.position = new Vector3(3, 1, 1);
        if (cylind.transform.position.x == -9 && cylind.transform.position.z == 9)
            cylind.transform.position = new Vector3(-9, 1, 3);
        if (cylind.transform.position.x == 7 && cylind.transform.position.z == 9)
            cylind.transform.position = new Vector3(7, 1, 3);
    }
      
}
