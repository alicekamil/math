using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class TurretDetector : MonoBehaviour
{
    public Transform target;

    public float _radius = 1;
    public float height = 1;
    [Range(0, 1)]
    public float angTresh = 0.5f;

    public void OnDrawGizmos()
    {
        Vector3 origin = transform.position;
        Vector3 up = transform.up;
        Vector3 right = transform.right;
        Vector3 forward = transform.forward;

        Vector3 top = origin + up * height; //offsetting by height

        Handles.DrawWireDisc(origin, up, _radius);
        Handles.DrawWireDisc(top, up, _radius);

        float p = angTresh;
        float x = Mathf.Sqrt(1 - p * p);

        Vector3 vRight = forward * p + right * x; //worldspace vector
        Gizmos.DrawRay(origin, vRight);
        Vector3 vLeft = forward * p + right * (-x);
    }
  //  bool Contains(Vector3 position)
  

    //forward direction trigger, direction to target(normalize it) (what number of dot should be outside/inside trigger)
    //d dot forward = p
}
