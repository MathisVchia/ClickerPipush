using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coupure : MonoBehaviour
{

    public float timer;
    public float TimerCoupure;
    public float reparation;
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;
    public GameObject canvas5;
    public GameObject reparationButton;

    // Start is called before the first frame update
    void Start()
    {
        SetCanvas1Visibility(true);
        SetCanvas2Visibility(true);
        SetCanvas3Visibility(true);
        SetCanvas4Visibility(true);
        SetCanvas5Visibility(true);
        SetButtonReparationVisibility(false);

        // Définir un premier temps de spawn alétoire
        timer = Random.Range(15, 20);
    }

    // Update is called once per frame
    void Update()
    {
        // Vérifier si un ennemi n'est pas actif et si le temps est écoulé
        TimerCoupure += Time.deltaTime;
        if (TimerCoupure >= timer)
        {
            CoupureCourant();
        }
    }

    public void CoupureCourant()
    {
        SetCanvas1Visibility(false);
        SetCanvas2Visibility(false);
        SetCanvas3Visibility(false);
        SetCanvas4Visibility(false);
        SetCanvas5Visibility(false);
        SetButtonReparationVisibility(true);
    }

    public void Reparation()
    {
        reparation = reparation +1;
        Debug.Log(reparation);
        if (reparation >= 5)
        {
            Debug.Log("Reparation en cours...");
            SetCanvas1Visibility(true);
            SetCanvas2Visibility(true);
            SetCanvas3Visibility(true);
            SetCanvas4Visibility(true);
            SetCanvas5Visibility(true);
            SetButtonReparationVisibility(false);
            TimerCoupure = 0;
            timer = Random.Range(15, 20);
            reparation = 0;
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetCanvas1Visibility(bool isVisible)
    {
        if (canvas1 != null)
        {
            canvas1.SetActive(isVisible);
            Debug.Log("(^.^)/");

        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetCanvas2Visibility(bool isVisible)
    {
        if (canvas2 != null)
        {
            canvas2.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetCanvas3Visibility(bool isVisible)
    {
        if (canvas3 != null)
        {
            canvas3.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetCanvas4Visibility(bool isVisible)
    {
        if (canvas4 != null)
        {
            canvas4.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetCanvas5Visibility(bool isVisible)
    {
        if (canvas5 != null)
        {
            canvas5.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetButtonReparationVisibility(bool isVisible)
    {
        if (reparationButton != null)
        {
            reparationButton.SetActive(isVisible);
        }
        else
        {
        }
    }

}
