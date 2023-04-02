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

    //Amount
    public TMP_Text amount1text;
    public int amount1;
    public float amount1profit;

    public TMP_Text amount2text;
    public int amount2;
    public float amount2profit;

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
        amount1 = 0;
        amount1profit = 1;
        amount2 = 0;
        amount2profit = 5;

        //Reset
        //PlayerPrefs.DeleteAll();

        //Load
        currentScore = PlayerPrefs.GetInt("currentScore", 0);
        hitPower = PlayerPrefs.GetInt("hitPower", 1);
        x = PlayerPrefs.GetInt("x", 0);
        shop1prize = PlayerPrefs.GetInt("shop1prize", 25);
        shop2prize = PlayerPrefs.GetInt("shop2prize", 125);
        amount1 = PlayerPrefs.GetInt("amount1", 0);
        amount1profit = PlayerPrefs.GetInt("amount1profit", 0);
        amount2 = PlayerPrefs.GetInt("amount2", 0);
        amount2profit = PlayerPrefs.GetInt("amount2profit", 0);
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
        shop1text.text = "Tier 1: " + shop1prize + " $";
        shop2text.text = "Tier 2: " + shop2prize + " $";

        //Amount
        amount1text.text = "Tier 1: " + amount1 + "arts $: " + amount1profit + "/s";
        amount2text.text = "Tier 2: " + amount2 + "arts $: " + amount2profit + "/s";

        //Upgrade
        UpgradeText.text = "Cost: " + upgradePrize + " $";

        //Save
        PlayerPrefs.SetInt("currentScore", (int)currentScore);
        PlayerPrefs.SetInt("hitPower", (int)hitPower);
        PlayerPrefs.SetInt("x", (int)x);
        PlayerPrefs.SetInt("shop1prize", (int)shop1prize);
        PlayerPrefs.SetInt("shop2prize", (int)shop2prize);
        PlayerPrefs.SetInt("amount1", (int)amount1);
        PlayerPrefs.SetInt("amount1profit", (int)amount1profit);
        PlayerPrefs.SetInt("amount2", (int)amount2);
        PlayerPrefs.SetInt("amount2profit", (int)amount2profit);
        PlayerPrefs.SetInt("upgradePrize", (int)upgradePrize);

        //Achievement
        if(currentScore >= 50)
        {
            achievementScore = true;
        }

        if(amount1 >= 2)
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
        if(currentScore > bestScore)
        {
            bestScore = (int)currentScore;
        }

        bestScoreText.text = bestScore + "Best Score";

        //Random Event
        if(nowIsEvent == false && goldButton.active == true)
        {
            goldButton.SetActive(false);
            StartCoroutine(WaitForEvent());
        }
        if(nowIsEvent == true && goldButton.active == false)
        {
            goldButton.SetActive(true);
            goldButton.transform.position = new Vector3(Random.Range(0, 751), Random.Range(0, 401), 0);
        }

    }

    //Hit
    public void Hit()
    {
        currentScore += hitPower;
    }

    //Shop
    public void Shop1()
    {
        if(currentScore>=shop1prize)
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

    //Upgrade
    public void Upgrade()
    {
        if(currentScore >= upgradePrize)
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
        yield return new WaitForSeconds(60f);

        int x = 0;
        x = Random.Range(1, 3);

        if(x == 2)
        {
            nowIsEvent = true;  

        }
        else
        {
            goldButton.SetActive(true);
        }

    }

}
