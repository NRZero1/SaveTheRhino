using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApproachTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float kecepatan = 10;

    Rigidbody rigidbody;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 arah = target.position - transform.position;
        float alpha = Mathf.Atan2(arah.x, arah.z);

        transform.rotation = Quaternion.EulerAngles(0, alpha, 0);
        rigidbody.MovePosition(transform.position + arah.normalized * kecepatan * Time.deltaTime);
    }
}
