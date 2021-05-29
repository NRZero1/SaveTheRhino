using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShootComponent : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent on_shoot;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            on_shoot.Invoke();
            RaycastHit hit;
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform.tag == "Animal")
                {
                    hit.transform.GetComponent<HealthManager>().takeDamage();
                }
            }
        }
    }
}
