using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemynewShip : EnemyShip
{
    Transform[] waypoints;
    bool isinitialize;
    float Times = 0f;

    private void Start()
    {
       
    }

    public void Init(Transform planetTransform, Transform[] _waypoints)
    {
        base.Init(planetTransform);

        waypoints = _waypoints;
        isinitialize = true;
    }


   /* public override void Update()
    {
        base.Update();


        if (isinitialize == false)
        {
            return;
        }
        
        var waypoint = waypoints[Random.Range(0, waypoints.Length)];


        if (Vector3.Distance(transform.position, waypoint.position) < 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoint.position, Time.deltaTime * MovementSpeed);
        }

    }*/

    public override void FixedUpdate()
    {
        base.FixedUpdate();

        
            if (isinitialize == false)
            {
                return;
            }

            var waypoint = waypoints[Random.Range(0, waypoints.Length)];


            if (Vector3.Distance(transform.position, waypoint.position) < 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, waypoint.position, Time.deltaTime * MovementSpeed);
            }
        
    }
}
