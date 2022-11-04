using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretPlacer : MonoBehaviour
{
    public Transform turret;
    private void OnDrawGizmos()
    {
        if (turret == null)
            return;
        
        //raycast to surface

        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Vector3 yAxis = hit.normal;
            Vector3 xAxis = Vector3.Cross(yAxis, ray.direction).normalized;
            Vector3 zAxis = Vector3.Cross(xAxis, yAxis);
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(hit.point, zAxis);
            Gizmos.color = Color.red;
            Gizmos.DrawRay(hit.point, xAxis);
            Gizmos.color = Color.green;
            Gizmos.DrawRay(hit.point, hit.normal);
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position, hit.point);
            turret.position = hit.point;
            

            turret.rotation = Quaternion.LookRotation(zAxis, yAxis); // x axis 
        }
    } //camera direction X normal surface = perpendicular s(tangent vector to surface)

    
}
