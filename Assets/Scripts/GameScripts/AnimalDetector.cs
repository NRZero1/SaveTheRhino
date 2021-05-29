using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimalDetector : MonoBehaviour
{
    public UnityEvent animal_entered;
    public PlayerManager playerManager;
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Animal")
        {
            playerManager.addScore(-other.GetComponent<HealthManager>().penalty);
            playerManager.takeDamage(other.GetComponent<HealthManager>().damage);
            animal_entered.Invoke();

            Destroy(other.gameObject);
        }
    }
}
