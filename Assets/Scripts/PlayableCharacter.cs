using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayableCharacter : MonoBehaviour
{
    public BaseCharacter[] playableCharacters;
    public BaseCharacter currentCharacter;

    private void Start()
    {
        currentCharacter = playableCharacters[Random.Range(0, playableCharacters.Length)];
        currentCharacter.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Switch();
        }
    }

    public void Switch()
    {
        currentCharacter.gameObject.SetActive(false);
        var myCharacter = playableCharacters[Random.Range(0, playableCharacters.Length)];
        while (myCharacter == currentCharacter)
        {
            myCharacter = playableCharacters[Random.Range(0, playableCharacters.Length)];
        }
        myCharacter.gameObject.SetActive(true);
        currentCharacter = myCharacter;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            currentCharacter.ApplyDamage(collision.gameObject.GetComponent<IDamagable>());
        }
    }
}
