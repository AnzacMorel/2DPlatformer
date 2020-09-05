using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject Heart0, Heart1, Heart2;

    public static int PlayerLives;

    void Start()
    {
        PlayerLives = 3;
        Heart0.gameObject.SetActive(true);
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
    }

    void Update()
    {
        switch (PlayerLives)
        {
            case 3:
                Heart0.gameObject.SetActive(true);
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                break;

            case 2:
                Heart0.gameObject.SetActive(true);
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(false);
                break;

            case 1:
                Heart0.gameObject.SetActive(true);
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                break;
        }
    }
}
