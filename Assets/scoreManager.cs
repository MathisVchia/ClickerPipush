using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public int score;
    public upgradeManager upgradeManager;

    public TextMeshProUGUI scoreUI;

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
        score++;
        scoreUI.text = "Score : " + score;
    }

}