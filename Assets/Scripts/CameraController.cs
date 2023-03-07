using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public List<PlayableCharacter> playableCharacters;
    public PlayableCharacter currentCharacter;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - currentCharacter.transform.position;
    }

    void LateUpdate()
    {
        transform.position = currentCharacter.transform.position + offset;
    }
}
