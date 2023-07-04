using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private Vector3 tempos;
    [SerializeField]
    private float minx , maxX;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
        {
           return; 
        }
        tempos = transform.position;
        tempos.x = player.position.x;
        if (tempos.x< minx)
        {
            tempos.x = minx;
            
        }
        if (tempos.x> maxX)
            {
                            tempos.x = maxX;

            }
        transform.position = tempos;
    }
}
