using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class PlayableCharacter : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public BoxCollider2D boxCollider;
    float horizontal;
    float vertical;
    public float speed;
    public GameObject bullet;
    public float bulletSpeed = 10f;
    private Vector2 shootingDirection;

    [SerializeField] Transform FirePoint;

    public void Start()
    {

    }

    public void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical).normalized;
        rigidBody.velocity = movement * speed;

        if (horizontal != 0 || vertical != 0)
        {
            // Set the shooting direction based on the player's facing direction
            Vector3 facingDirection = transform.localScale;
            if (facingDirection.x > 0) // Facing right
            {
                shootingDirection = Vector2.right;
            }
            else if (facingDirection.x < 0) // Facing left
            {
                shootingDirection = Vector2.left;
            }
            else if (facingDirection.y > 0) // Facing up
            {
                shootingDirection = Vector2.up;
            }
            else if (facingDirection.y < 0) // Facing down
            {
                shootingDirection = Vector2.down;
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject projectile = Instantiate(bullet, FirePoint.position, Quaternion.identity);

            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.velocity = shootingDirection * bulletSpeed;
        }
    }

    public void Die()
    {
        Destroy(this);
    }
}
