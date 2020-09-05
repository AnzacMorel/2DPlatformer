using UnityEngine;

public class Character2dController : MonoBehaviour
{

    public float MovementSpeed = 5;
    public float JumpForce = 5;

    private Rigidbody2D _rigidBody;

    public GameObject Character;

    public GameObject Heart0, Heart1, Heart2;

    private int PlayerLives;

    private bool PlayerStarted;

    private void Start()
    {
        this.PlayerLives = 3;
        this.PlayerStarted = false;
        Character.gameObject.SetActive(true);
        _rigidBody = GetComponent<Rigidbody2D>();
        Heart0.gameObject.SetActive(true);
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
    }

    private void Update()
    {   
        if (Input.anyKeyDown && this.PlayerStarted == false)
        {
            this.PlayerStarted = true;
        }

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidBody.velocity.y) < 0.001f)
        {
            _rigidBody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if (!Character.GetComponent<Renderer>().isVisible && this.PlayerStarted == true)
        {
            this.PlayerLives -= 1;

            switch (this.PlayerLives)
            {
                case 3:
                    Heart0.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(true);
                    Heart2.gameObject.SetActive(true);
                    transform.position = new Vector3(-10f, -2.635f, 0f);
                    break;

                case 2:
                    Heart0.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(true);
                    Heart2.gameObject.SetActive(false);
                    transform.position = new Vector3(-10f, -2.635f, 0f);
                    break;

                case 1:
                    Heart0.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(false);
                    Heart2.gameObject.SetActive(false);
                    transform.position = new Vector3(-10f, -2.635f, 0f);
                    break;

                case 0:
                    Heart0.gameObject.SetActive(false);
                    Heart1.gameObject.SetActive(false);
                    Heart2.gameObject.SetActive(false);
                     break;
            }
        }
    }
}
