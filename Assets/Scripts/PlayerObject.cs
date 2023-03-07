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
    private Rigidbody2D rigidBody;
    float horizontal;
    float vertical;
    public float speed;
    private Vector2 lastMovementDirection;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;

    [SerializeField] Transform FirePoint;


    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        currentCharacter = playableCharacters[Random.Range(0, playableCharacters.Count)];
        currentCharacter.gameObject.SetActive(true);

        gameoverTextObject.SetActive(false);
        winTextObject.SetActive(false);
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        rigidBody.velocity = new Vector2(horizontal, vertical).normalized * speed;

        if (horizontal != 0)
        {
            lastMovementDirection = new Vector2(horizontal, 0);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject projectile = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();
            projectileRb.velocity = lastMovementDirection * bulletSpeed;
        }

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