using UnityEngine;

public abstract class PlayableCharacter : MonoBehaviour
{
    public void Die()
    {
        Destroy(this);
    }
}
