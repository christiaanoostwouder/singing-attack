using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
    public Transform[] Waypoint;
    public float MoveSpeed;
    int WaypointIndex = 0;
    void Start()
    {
       transform.position = Waypoint[WaypointIndex].transform.position;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, Waypoint[WaypointIndex].transform.position, MoveSpeed * Time.deltaTime);

        if(transform.position == Waypoint[WaypointIndex].transform.position)
        {
            WaypointIndex = WaypointIndex + 1;
        }
        
        if(WaypointIndex == Waypoint.Length)
        {
            Destroy(gameObject);
        }
    }
}
