using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance;
    public ball_jump ball;
    public trajectory traj;
     Camera cam;

    Vector2 startpoint;
    Vector2 endpoint;
    Vector2 direction;
    Vector2 force;
    float distance;
    public float pushforce = 4.0f;
    

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        cam = Camera.main;
        ball.DeactivateRigidbody();
    }

    // Update is called once per frame
    void Update()
    {   if(Input.GetMouseButtonDown(0))
        {
            OnDragStart();
        }
    if(Input.GetMouseButtonUp(0))
        {
            OnDragEnd();
        }
    if(Input.GetMouseButton(0))
        {
            OnDrag();
            //print("this");
        }
        
    }
    void OnDragStart()
    {
        ball.DeactivateRigidbody();
        startpoint = cam.ScreenToWorldPoint(Input.mousePosition);
        traj.show();


    }
    void OnDrag()
    {
        endpoint = cam.ScreenToWorldPoint(Input.mousePosition);
        distance = Vector2.Distance(startpoint, endpoint);
        direction = (startpoint - endpoint).normalized;

        force = direction * distance * pushforce;

        Debug.DrawLine(startpoint, endpoint);
        traj.UpdateDots(ball.Humanpose, force);
    }
    void OnDragEnd()
    {
        ball.activateRigidbody();
        ball.push(force);
        traj.Hide();
    }

}
