using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Image img_darah;
    public float max_health = 10;
    public int health = 10;
    public GameObject soul;
    public int penalty = 0;
    public int damage = 0;
    public int score = 0;
    public void takeDamage()
    {
        health -= 1;
        img_darah.GetComponent<RectTransform>().sizeDelta = new Vector2(health/max_health * 10, 1);
        if (health <= 0)
        {
            Instantiate(soul, transform.position, Quaternion.identity);
            Destroy(gameObject);
            GameObject.FindObjectOfType<PlayerManager>().addScore(score*10);
        }
        else
        {
            GameObject.FindObjectOfType<PlayerManager>().addScore(score);
        }
    }
}
