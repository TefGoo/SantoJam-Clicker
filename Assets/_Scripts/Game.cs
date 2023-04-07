using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    //Clicks
    public TMP_Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasePerSecond;
    public float x;

    //Shop
    public int shop1prize;
    public TMP_Text shop1text;

    public int shop2prize;
    public TMP_Text shop2text;

    public int shop3prize;
    public TMP_Text shop3text;

    public int shop4prize;
    public TMP_Text shop4text;

    public int shop5prize;
    public TMP_Text shop5text;

    //Amount
    public TMP_Text amount1text;
    public int amount1;
    public float amount1profit;

    public TMP_Text amount2text;
    public int amount2;
    public float amount2profit;

    public TMP_Text amount3text;
    public int amount3;
    public float amount3profit;

    public TMP_Text amount4text;
    public int amount4;
    public float amount4profit;

    public TMP_Text amount5text;
    public int amount5;
    public float amount5profit;

    //Upgrade
    public int upgradePrize;
    public TMP_Text UpgradeText;

    //Achievement
    public bool achievementScore;
    public bool achievementShop;

    public Image image1;
    public Image image2;

    //Highscore
    public int bestScore;
    public TMP_Text bestScoreText;

    //Random Event
    public bool nowIsEvent;
    public GameObject goldButton;

    //Hit
    public GameObject plusObject;
    public TMP_Text plusText;


    // Start is called before the first frame update
    void Start()
    {
        //Clicks
        currentScore = 0;
        hitPower = 1;
        scoreIncreasePerSecond = 1;
        x = 0;

        //Default variables
        shop1prize = 25;
        shop2prize = 125;
        shop3prize = 300;
        shop4prize = 550;
        shop5prize = 1000;
        amount1 = 0;
        amount1profit = 1;
        amount2 = 0;
        amount2profit = 5;
        amount3 = 0;
        amount3profit = 10;
        amount4 = 0;
        amount4profit = 20;
        amount5 = 0;
        amount5profit = 40;


        //Load
        currentScore = PlayerPrefs.GetInt("currentScore", 0);
        hitPower = PlayerPrefs.GetInt("hitPower", 1);
        x = PlayerPrefs.GetInt("x", 0);
        shop1prize = PlayerPrefs.GetInt("shop1prize", 25);
        shop2prize = PlayerPrefs.GetInt("shop2prize", 125);
        shop3prize = PlayerPrefs.GetInt("shop3prize", 300);
        shop4prize = PlayerPrefs.GetInt("shop4prize", 550);
        shop5prize = PlayerPrefs.GetInt("shop5prize", 1000);
        amount1 = PlayerPrefs.GetInt("amount1", 0);
        amount1profit = PlayerPrefs.GetInt("amount1profit", 0);
        amount2 = PlayerPrefs.GetInt("amount2", 0);
        amount2profit = PlayerPrefs.GetInt("amount2profit", 0);
        amount3 = PlayerPrefs.GetInt("amount3", 0);
        amount3profit = PlayerPrefs.GetInt("amount3profit", 0);
        amount4 = PlayerPrefs.GetInt("amount4", 0);
        amount4profit = PlayerPrefs.GetInt("amount4profit", 0);
        amount5 = PlayerPrefs.GetInt("amount5", 0);
        amount5profit = PlayerPrefs.GetInt("amount5profit", 0);
        upgradePrize = PlayerPrefs.GetInt("upgradePrize", 50);

        //New
        bestScore = PlayerPrefs.GetInt("bestScore", 0);

    }

    // Update is called once per frame
    void Update()
    {
        //Clicks
        scoreText.text = (int)currentScore + "$";
        scoreIncreasePerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasePerSecond;

        //Shop
        shop1text.text = "Rompope: " + "$" + shop1prize;
        shop2text.text = "Pepian: " + "$" + shop2prize;
        shop3text.text = "Quitapenas: " + "$" + shop3prize;
        shop4text.text = "Tikal: " + "$" + shop4prize;
        shop5text.text = "Quetzal: " + "$" + shop5prize;

        //Amount
        amount1text.text = "Rompope: " + amount1 + " | " + " $" + amount1profit + " /s";
        amount2text.text = "Pepian: " + amount2 + " | " + " $" + amount2profit + " /s";
        amount3text.text = "Quitapenas: " + amount3 + " | " + " $" + amount3profit + " /s";
        amount4text.text = "Tikal: " + amount4 + " | " + " $" + amount4profit + " /s";
        amount5text.text = "Quetzal: " + amount5 + " | " + " $" + amount5profit + " /s";

        //Upgrade
        UpgradeText.text = "+ Click: " + upgradePrize + " $";

        //Save
        PlayerPrefs.SetInt("currentScore", (int)currentScore);
        PlayerPrefs.SetInt("hitPower", (int)hitPower);
        PlayerPrefs.SetInt("x", (int)x);
        PlayerPrefs.SetInt("shop1prize", (int)shop1prize);
        PlayerPrefs.SetInt("shop2prize", (int)shop2prize);
        PlayerPrefs.SetInt("shop3prize", (int)shop3prize);
        PlayerPrefs.SetInt("shop4prize", (int)shop4prize);
        PlayerPrefs.SetInt("shop5prize", (int)shop5prize);
        PlayerPrefs.SetInt("amount1", (int)amount1);
        PlayerPrefs.SetInt("amount1profit", (int)amount1profit);
        PlayerPrefs.SetInt("amount2", (int)amount2);
        PlayerPrefs.SetInt("amount2profit", (int)amount2profit);
        PlayerPrefs.SetInt("amount3", (int)amount3);
        PlayerPrefs.SetInt("amount3profit", (int)amount3profit);
        PlayerPrefs.SetInt("amount4", (int)amount4);
        PlayerPrefs.SetInt("amount4profit", (int)amount4profit);
        PlayerPrefs.SetInt("amount5", (int)amount5);
        PlayerPrefs.SetInt("amount5profit", (int)amount5profit);
        PlayerPrefs.SetInt("upgradePrize", (int)upgradePrize);

        //Achievement
        if (currentScore >= 1000)
        {
            achievementScore = true;
        }

        if (amount1 >= 2)
        {
            achievementShop = true;
        }

        if (achievementScore == true)
        {
            image1.color = new Color(1f, 1f, 1f, 1f);
        }
        else
        {
            image1.color = new Color(0.2f, 0.2f, 0.2f, 0.2f);
        }

        if (achievementShop == true)
        {
            image2.color = new Color(1f, 1f, 1f, 1f);
        }
        else
        {
            image2.color = new Color(0.2f, 0.2f, 0.2f, 0.2f);
        }

        //New
        PlayerPrefs.SetInt("bestScore", bestScore);

        //Highscore
        if (currentScore > bestScore)
        {
            bestScore = (int)currentScore;
        }

        bestScoreText.text = "Record: " + bestScore + "$";

        //Random Event
        if (nowIsEvent == false && goldButton.activeSelf == true)
        {
            goldButton.SetActive(false);
            StartCoroutine(WaitForEvent());
        }
        if (nowIsEvent == true && goldButton.activeSelf == false)
        {
            goldButton.SetActive(true);
            goldButton.transform.position = new Vector3(Random.Range(0, 751), Random.Range(0, 401), 0);
        }


        //Hit
        plusText.text = "+ " + hitPower;

    }

    //Hit

    public void Hit()
    {
        currentScore += hitPower;
        plusObject.SetActive(false);
        int screenWidth = Screen.width;
        int screenHeight = Screen.height;
        int xMin = screenWidth / 4;
        int xMax = 3 * screenWidth / 4;
        int yMin = screenHeight / 4;
        int yMax = 3 * screenHeight / 4;
        plusObject.transform.position = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
        plusObject.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(Fly());
    }


    //Shop
    public void Shop1()
    {
        if (currentScore >= shop1prize)
        {
            currentScore -= shop1prize;
            amount1 += 1;
            amount1profit += 1;
            x += 1;
            shop1prize += 25;
        }
    }

    public void Shop2()
    {
        if (currentScore >= shop2prize)
        {
            currentScore -= shop2prize;
            amount2 += 1;
            amount2profit += 5;
            x += 5;
            shop2prize += 125;
        }
    }

    public void Shop3()
    {
        if (currentScore >= shop3prize)
        {
            currentScore -= shop3prize;
            amount3 += 1;
            amount3profit += 10;
            x += 10;
            shop3prize += 300;
        }
    }

    public void Shop4()
    {
        if (currentScore >= shop4prize)
        {
            currentScore -= shop4prize;
            amount4 += 1;
            amount4profit += 20;
            x += 20;
            shop4prize += 550;
        }
    }

    public void Shop5()
    {
        if (currentScore >= shop5prize)
        {
            currentScore -= shop5prize;
            amount5 += 1;
            amount5profit += 40;
            x += 40;
            shop5prize += 1000;
        }
    }

    //Upgrade
    public void Upgrade()
    {
        if (currentScore >= upgradePrize)
        {
            currentScore -= upgradePrize;
            hitPower *= 2;
            upgradePrize *= 3;
        }
    }

    //Random Event
    public void GetReward()
    {
        currentScore = currentScore + Random.Range(1, 2500);
        nowIsEvent = false;
        StartCoroutine(WaitForEvent());
    }

    //Random Event
    IEnumerator WaitForEvent()
    {
        yield return new WaitForSeconds(5f);

        int x = 0;
        x = Random.Range(1, 4);

        if (x == 3)
        {
            nowIsEvent = true;

        }
        else
        {
            goldButton.SetActive(true);
        }

    }

    //Hit
    IEnumerator Fly()
    {
        for (int i = 0; i <= 19; i++)
        {
            yield return new WaitForSeconds(0.01f);
            plusObject.transform.position = new Vector3(plusObject.transform.position.x, plusObject.transform.position.y + 2, 0);
        }
        plusObject.SetActive(false);
    }

}