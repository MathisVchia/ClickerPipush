using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class autoClick : MonoBehaviour
{
    public scoreManager score;
    public bool autoActiv = false;
    public int bonus;

    public TextMeshProUGUI UI;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(testCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void autoclick()
    {
        if (score > 10)
        {
            autoActiv = true;
            bonus++;
            scoreUI.text = "Bonus : " + bonus;
        }
        else
        {
            autoActiv = false;
        }
}