using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    [SerializeField] private int nextWaypointIndex = 1;
    [SerializeField] private float reachedWaypointIndex = 0.25f;
    [SerializeField] private Path path;
    private void Start()
    {
        transform.position = path.waypoints[0].position;
        Awake();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, path.waypoints[nextWaypointIndex].position, Time.deltaTime * speed);
        if (Vector3.Distance(transform.position, path.waypoints[nextWaypointIndex].position) <= reachedWaypointIndex )
        {
            nextWaypointIndex= nextWaypointIndex + 1;
        }
        if(nextWaypointIndex >= path.waypoints.Length)
        {
            nextWaypointIndex = 0;
            Destroy(gameObject);
        }
    }

    private void Awake()
    {
        path = FindAnyObjectByType<Path>();
    }
}
