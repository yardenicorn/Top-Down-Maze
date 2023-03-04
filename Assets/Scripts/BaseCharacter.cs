using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour, IDamagable
{
    public Rigidbody2D rb;
    float horizontal;
    float vertical;
    public float speed;
    public int maxHP;
    public int currentHP;

    public abstract void SpecialAbility();
    public abstract void TakeDamage(int howMuch);
    public abstract void ApplyDamage(IDamagable damagable);

    public void Update()
    {
        Movement();
        if (currentHP == 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(this);
    }

    public void Movement()
    {
        // Get input from horizontal and vertical axis
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        // Calculate the movement direction
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }

}
