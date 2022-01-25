using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_move : MonoBehaviour
{
    //public Transform platform;
    public int movespeed;
    //public GameObject platform;
    float repos_y = -9.97f;
    int smooth = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();

    }
    void move()
    {  
        transform.position += transform.up * movespeed * Time.deltaTime;
        reposition();
    }
     void reposition()
    {
        if (transform.position.y > 9.93f)
        {
            transform.position = new Vector2(transform.position.x, repos_y);
        }
    }
}
