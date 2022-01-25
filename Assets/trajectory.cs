using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trajectory : MonoBehaviour
{
    // Start is called before the first frame update



    [SerializeField] int dotNumber;
    [SerializeField] GameObject dotsParent;
    [SerializeField] GameObject dotsprefab;

    [SerializeField] float dotspacing;
    Vector2 pos;
    float timestamp;
    Transform[] dostlist;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void prepareDots()
    {
        dostlist = new Transform[dotNumber];
        for (int i = 0; i < dotNumber; i++)
        {
            dostlist[i] = Instantiate(dotsprefab, null).transform;
            dostlist[i].parent = dotsParent.transform;


        }

    }
    public void UpdateDots(Vector2 ballpos,Vector2 forceapplied)
    {
        timestamp = dotspacing;
        for(int i = 0;i<0; i++)
        {
            pos.x = (ballpos.x + forceapplied.x * timestamp);
            pos.y = (ballpos.y + forceapplied.y * timestamp) - (Physics2D.gravity.magnitude) / 2f;
            dostlist[i].position = pos;
            timestamp += dotspacing;

        }
    }

    public void show()
    {
        dotsParent.SetActive(true);
    }
    public void Hide()
    {
        dotsParent.SetActive(false);
    }
}
