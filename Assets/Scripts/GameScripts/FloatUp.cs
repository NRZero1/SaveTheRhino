using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{
    public float kecepatan = 7;

    // Update is called once per frame
    void Start()
    {
        Destroy(gameObject, 3);
    }
    void Update()
    {
        transform.position += Vector3.up * kecepatan * Time.deltaTime;
    }
}
