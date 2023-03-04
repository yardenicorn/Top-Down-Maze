using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ChooseRandomChar : MonoBehaviour
{
    public PlayableCharacter[] playableCharacters;
    public GameObject currentCharacter;
    //public List<GameObject> characterList;
    //public int playerIndex = 0;
    //public Transform PlayerStartPoint;


    // Start is called before the first frame update
    //void Start()
    //{
    //    // Select a random player
    //    int index = Random.Range(0, characters.Length);
    //    GameObject selectedPlayer = characterList[index];
    //
    //    // Disable all players except the selected one
    //    foreach (PlayableCharacter character in characters)
    //    {
    //        if (character != selectedPlayer)
    //        {
    //            character.SetActive(false);
    //        }
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Switch();
        }
    }

    //public void ChooseRandom()
    //{
    //    // Disable the current character
    //    characterList[playerIndex].SetActive(false);
    //
    //    // Increment the character index or wrap around to the beginning of the list
    //    playerIndex = (playerIndex + 1) % characterList.Count;
    //
    //    // Enable the next character at the updated spawn point
    //    characterList[playerIndex].SetActive(true);
    //
    //    // Update the position of the PlayerStartPoint object to the new active player's position
    //    PlayerStartPoint.transform.position = characterList[playerIndex].transform.position;
    //
    //    // Set the PlayerStartPoint object as the parent of the active player object
    //    characterList[playerIndex].transform.parent = PlayerStartPoint.transform;
    //}

    public void Switch()
    {
        var myCharacter = playableCharacters[Random.Range(0, playableCharacters.Length)];
        myCharacter.gameObject.SetActive(true);
        currentCharacter.SetActive(false);
        currentCharacter = myCharacter.gameObject;
    }
}
