using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shopManagement : MonoBehaviour
{
    public scoreManager scoreManager;
    public TextMeshProUGUI bonusUI;
    public int bonus;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnMouseDown()
    {
        upgradeClick();
    }

    public void upgradeClick()
    {
        if (scoreManager.score >= 10)
        {
            scoreManager.score --;
            scoreManager.scoreUI.text = "Score : " + scoreManager.score;
            bonus++;
            bonusUI.text = "Ticket : " + bonus;
        }
        else
        {

        }
    }
}