using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class autoclickManagement : MonoBehaviour
{
    public int bonus;
    private float _timeAutoClick = 1f;
    public TextMeshProUGUI bonusUI;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator MyCoroutine()
    {
        while (true)
        {
            autoclick();
            yield return new WaitForSeconds(_timeAutoClick);
        }
    }

    void autoclick()
    {
        bonus++;
        bonusUI.text = "Bonus : " + bonus;
    }
}

