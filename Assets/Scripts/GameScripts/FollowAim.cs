using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAim : MonoBehaviour
{
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            Vector3 arah = hit.point - transform.position;
            float alpha = Mathf.Atan2(arah.x, arah.z);
            float tetha = Mathf.Atan2(arah.z, arah.y) + Mathf.Deg2Rad * -90;

            transform.rotation = Quaternion.EulerAngles(tetha, alpha, 0);
        }
        else
        {
            float tetha = Mathf.Atan2(ray.direction.z, ray.direction.y) + Mathf.Deg2Rad * -90;
            float alpha = Mathf.Atan2(ray.direction.x, ray.direction.z);

            transform.rotation = Quaternion.EulerAngles(tetha, alpha, 0);
        }
    }
}
