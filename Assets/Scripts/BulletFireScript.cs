using UnityEngine;
using UnityEngine.InputSystem;

public class BulletScript : MonoBehaviour
{
    public GameObject Bullet;

    public float bulletSpeed = 2f;

    public Transform BulletSpawnPoint;

    public float fireDelay = 0.1f;

    public float nextFireTime = 0f;


    // Update is called once per frame
    void Update()
    {
        var kb = Keyboard.current;

        if (kb != null && kb.eKey.isPressed && Time.time >= nextFireTime)
        {
            FireBullet();
            nextFireTime = Time.time + fireDelay;
        }
    }


    void FireBullet()
    {
     GameObject SpawnedBullet = Instantiate(Bullet, BulletSpawnPoint.position, transform.rotation);
        Destroy(SpawnedBullet, 3f);

        Rigidbody2D rb2D = SpawnedBullet.GetComponent<Rigidbody2D>();
        if (rb2D != null)
        {
            rb2D.linearVelocity = transform.up * bulletSpeed; // Moves in object's forward/up direction
        }
    }
}