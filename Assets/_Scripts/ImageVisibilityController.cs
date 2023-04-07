using UnityEngine;

public class ImageVisibilityController : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;

    private Game game;

    private void Awake()
    {
        game = FindObjectOfType<Game>();
        if (game == null)
        {
            Debug.LogError("Game object not found!");
        }
    }

    private void Update()
    {
        if (game.amount1 >= 3)
        {
            image1.SetActive(false);
        }
        else
        {
            image1.SetActive(true);
        }

        if (game.amount2 >= 5)
        {
            image2.SetActive(false);
        }
        else
        {
            image2.SetActive(true);
        }

        if (game.amount3 >= 10)
        {
            image3.SetActive(false);
        }
        else
        {
            image3.SetActive(true);
        }

        if (game.amount4 >= 20)
        {
            image4.SetActive(false);
        }
        else
        {
            image4.SetActive(true);
        }
    }
}
