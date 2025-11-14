using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Unity.Mathematics;
public class Character : MonoBehaviour
{
    public float speed;
    private Waypoints Wpoints;

    private int waypointsindex;

    void start()
    {
        Wpoints = GameObject.FindGameObjectsWithTag("Waypoints").<Waypoints>();
    }

    void update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Wpoints.WayPoints[waypointsindex].position, speed * Time.deltaTime);
        Vector3 dir = Wpoints.WayPoints[waypointsindex].position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (Vector3.Distance(transform.position, Wpoints.WayPoints[waypointsindex].position) < 0.1f)
        {
            if (waypointsindex < Wpoints.WayPoints.Length - 1)
            {
                waypointsindex++;
            } else
           
            {
                Destroy(gameObject);
            }
            
        } 
    }
}
