using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float jumpSpeed = 5;
    Rigidbody2D rb;
    public int score;

    public TMP_Text scoreText;
    public GameObject endScreen;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && speed > 0)
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }

        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * 3f);
        Pipe.speed = speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }


    public void Die()
    {
        speed = 0;
        Invoke("ShowMenu",1f); // calls function after 1 second

        //var currentScene = SceneManager.GetActiveScene().name;
        //SceneManager.LoadScene(currentScene);
    }

    void ShowMenu()
    {
        scoreText.text = ""; // arba scoreText.gameObject.SetActive(false);
        endScreen.SetActive(true);
        print("end screen");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        scoreText.text = score.ToString();
    }
}