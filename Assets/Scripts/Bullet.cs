using UnityEngine;

public class Bullet : MonoBehaviour
{
    public PlayableCharacter currentCharacter;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.layer == 7)
        {
            Destroy(gameObject);
        }
    }
}
