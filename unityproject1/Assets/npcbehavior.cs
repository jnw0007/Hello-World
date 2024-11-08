using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcbehavior : MonoBehaviour
{
    public float speed;
    public List<Transform> waypoints;
    private Transform Targetwaypoints;
    private int targetindex = 0; 
    // Start is called before the first frame update
    void Start()
    {
        Targetwaypoints = waypoints[targetindex];

    }

    // Update is called once per frame
    void Update()
    {
        followWaypoint(Targetwaypoints);
        checkArrival();
    }
    private void checkArrival()
    {
        float distance = Vector3.Distance(transform.position, Targetwaypoints.position);
        if (distance < 0.3f)
        {
            Targetwaypoints = getNextTargetWaypoint();
        }
    }
    private void followWaypoint(Transform Waypoint)
    {
        Vector3 direction = Waypoint.position - transform.position;
        Vector3 newdirection = Vector3.RotateTowards(transform.forward, direction, Mathf.PI * 2 / 36, Mathf.PI * 2);
        transform.rotation = Quaternion.LookRotation(newdirection);
        transform.position += transform.forward * speed * Time.deltaTime; 
    }
    private Transform getNextTargetWaypoint()
    {
        if (targetindex < waypoints.Count - 1)
        {
            targetindex++;
        }
        else
        {
            targetindex = 0;
        }
        return waypoints[targetindex];
    }
}
