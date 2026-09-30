using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform player;

    public float moveSpeed = 2f;

    public Rigidbody2D body;

    private Vector2 _movementDelta;

    private float _rotation;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        _rotation = body.rotation;
    }

    private void Update()
    {
        var directionToTarget = ((Vector2)player.position - body.position).normalized;
        _rotation = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg - 90f; //Kan behöva ändra till + 90f
        _movementDelta = directionToTarget * moveSpeed;
    }


    private void FixedUpdate()
    {
        body.MovePosition(body.position + _movementDelta * Time.fixedDeltaTime);
        body.SetRotation(_rotation);
    }
}
