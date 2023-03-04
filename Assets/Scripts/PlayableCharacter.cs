using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableCharacter : MonoBehaviour, IDamagable
{
    public Rigidbody2D rb;
    public float speed;
    public int maxHP;
    public int currentHP;

    public abstract void Die();
    public abstract void SpecialAbility();
    public abstract void TakeDamage(int howMuch);

    public void Movement()
    {
        // Get input from horizontal and vertical axis
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontal, vertical, 0f);

        // Normalize the movement direction to prevent diagonal movement from being faster
        movement = movement.normalized * speed * Time.deltaTime;

        // Move the player
        transform.position += movement;
    }

    void ApplyDamage(IDamagable damagable)
    {

    }

    void Update()
    {
        Movement();
    }
}
