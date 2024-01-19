using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public int Score;
    public upgradeManager upgradeManager;

    public TextMeshProUGUI ScoreUI;

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
        addScore();
    }

    public void addScore()
    {
        Score++;
        ScoreUI.text = "Score : " + Score;
    }

}