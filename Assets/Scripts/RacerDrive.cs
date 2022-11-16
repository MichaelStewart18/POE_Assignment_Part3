using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacerDrive : MonoBehaviour
{
    [SerializeField] private Waypoints waypoints;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float dist = 0.1f;
    private Transform currentWapoint;
    public SFXManager sfxManager;

    void Start()
    {
        currentWapoint = waypoints.NextWaypoint(currentWapoint);
        transform.position = currentWapoint.position;

        currentWapoint = waypoints.NextWaypoint(currentWapoint);

        transform.LookAt(currentWapoint);

        sfxManager.PlaySound("Engine");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentWapoint.position, moveSpeed * Time.deltaTime);
        if(Vector3.Distance(transform.position, currentWapoint.position) < dist)
        {
            currentWapoint = waypoints.NextWaypoint(currentWapoint);
            transform.LookAt(currentWapoint);
        }
    }
}
