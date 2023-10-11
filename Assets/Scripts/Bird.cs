using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float jumpSpeed = 5;
    Rigidbody2D rb;
    public int score;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        var currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        score++;

        
    }
}