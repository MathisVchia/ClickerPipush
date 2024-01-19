using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coupure : MonoBehaviour
{

    public float Timer;
    public float TimerCoupure;
    public float Reparation;
    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject Canvas3;
    public GameObject Canvas4;
    public GameObject Canvas5;
    public GameObject ReparationButton;

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
        Timer = Random.Range(15, 20);
    }

    // Update is called once per frame
    void Update()
    {
        // Vérifier si un ennemi n'est pas actif et si le temps est écoulé
        TimerCoupure += Time.deltaTime;
        if (TimerCoupure >= Timer)
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

    public void Reparations()
    {
        Reparation = Reparation +1;
        Debug.Log(Reparation);
        if (Reparation >= 5)
        {
            Debug.Log("Reparation en cours...");
            SetCanvas1Visibility(true);
            SetCanvas2Visibility(true);
            SetCanvas3Visibility(true);
            SetCanvas4Visibility(true);
            SetCanvas5Visibility(true);
            SetButtonReparationVisibility(false);
            TimerCoupure = 0;
            Timer = Random.Range(15, 20);
            Reparation = 0;
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetCanvas1Visibility(bool isVisible)
    {
        if (Canvas1 != null)
        {
            Canvas1.SetActive(isVisible);
            Debug.Log("(^.^)/");

        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetCanvas2Visibility(bool isVisible)
    {
        if (Canvas2 != null)
        {
            Canvas2.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetCanvas3Visibility(bool isVisible)
    {
        if (Canvas3 != null)
        {
            Canvas3.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetCanvas4Visibility(bool isVisible)
    {
        if (Canvas4 != null)
        {
            Canvas4.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetCanvas5Visibility(bool isVisible)
    {
        if (Canvas5 != null)
        {
            Canvas5.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetButtonReparationVisibility(bool isVisible)
    {
        if (ReparationButton != null)
        {
            ReparationButton.SetActive(isVisible);
        }
        else
        {
        }
    }

}
