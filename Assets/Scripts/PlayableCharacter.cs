using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class PlayableCharacter : MonoBehaviour, IDamagable
{
    public Rigidbody2D rigidBody;
    public BoxCollider2D boxCollider;
    float horizontal;
    float vertical;
    public float speed;
    public int currentHP;
    public int maxHP = 10;

    public void Start()
    {
        currentHP = maxHP;
    }

    public void Update()
    {
        Movement();
    }

    public void Movement()
    {
        // Get input from horizontal and vertical axis
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        // Calculate the movement direction
        rigidBody.velocity = new Vector2(horizontal * speed, vertical * speed);
    }

    public void TakeDamage(int howMuch)
    {
        currentHP -= howMuch;
        if (currentHP <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(this);
    }

    // public virtual void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.tag == "Trap")
    //     {
    //         Debug.Log("Collided");
    //         //CollidedWithTrap(collision.gameObject);
    //     }
    // }

    // public abstract void CollidedWithTrap(GameObject trap);
    
    public abstract void SpecialAbility();
    public abstract void ApplyDamage(IDamagable damagable);

}
