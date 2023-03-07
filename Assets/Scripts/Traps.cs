using UnityEngine;

public abstract class Traps : MonoBehaviour
{
    public enum TrapType
    {
        Trap1,
        Trap2,
        Trap3
    }

    public TrapType trapType;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
                Destroy(gameObject);
        }
    }
}