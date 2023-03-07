using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    public List<PlayableCharacter> playableCharacters;
    public PlayableCharacter currentCharacter;
    public PlayableCharacter previousCharacter;
    public GameObject gameoverTextObject;
    public GameObject winTextObject;
    public GameObject MazeEnd;


    private void Start()
    {
        currentCharacter = playableCharacters[Random.Range(0, playableCharacters.Count)];
        currentCharacter.gameObject.SetActive(true);

        gameoverTextObject.SetActive(false);
        winTextObject.SetActive(false);
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
        var myCharacter = playableCharacters[Random.Range(0, playableCharacters.Count)];
        while (myCharacter == currentCharacter || myCharacter == previousCharacter)
        {
            myCharacter = playableCharacters[Random.Range(0, playableCharacters.Count)];
        }
        myCharacter.gameObject.SetActive(true);
        previousCharacter = currentCharacter;
        currentCharacter = myCharacter;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            playableCharacters.Remove(currentCharacter);
            currentCharacter.gameObject.SetActive(false);
            currentCharacter.Die();
            if (playableCharacters.Count == 0)
            {
                gameoverTextObject.SetActive(true);
            }
            else
            {
                currentCharacter = playableCharacters[Random.Range(0, playableCharacters.Count)];
                currentCharacter.gameObject.SetActive(true);
            }
        }

        if (collision.gameObject == MazeEnd)
        {
            winTextObject.SetActive(true);
        }
    }
}
