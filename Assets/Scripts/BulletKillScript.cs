using Unity.VisualScripting;
using UnityEngine;

public class BulletKillScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
            {
            Destroy(gameObject);
            Destroy(collision.gameObject);

            }

        if(collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);

        }
    }
}
