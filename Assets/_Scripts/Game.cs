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

    // Start is called before the first frame update
    void Start()
    {
        //Clicks
        currentScore = 0;
        hitPower = 1;
        scoreIncreasePerSecond = 1;
        x = 0;
        
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

}
