using TMPro;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public TMP_Text text;

    public int health = 100;

    public int damage = 10;

    // Update is called once per frame
    void Update()
    {
        text.text = "Health: " + health.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health = health - damage;
        }

    }
}
