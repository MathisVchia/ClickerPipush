using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatchaManagement : MonoBehaviour
{

    public shopManagement shopManagement;
    public GameObject gatchaButton;
    public GameObject stickersCommon1;
    public GameObject passButton;
    public GameObject carnet;
    public GameObject closeCarnetButton;
    public bool gatchaButtons = false;
    public bool showStickers = false;

    // Gestion des taux d'obtentions
    public int RandomLoot;
    public int Minimum = 0;
    public int Maximum = 100;
    public int Price = 30;
    public int nbStickersCommon;

    public int MaxRandomNormal;
    public int MaxRandomGold;

    public GameObject RedParticle;

    // Start is called before the first frame update
    void Start()
    {
        SetGatchaButtonVisibility(false);
        SetStickerCommon1Visibility(false);
        SetValidationButtonVisibility(false);
        SetCarnetVisibility(false);
        SetButtonCloseCarnetVisibility(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (shopManagement.bonus > 30)
        {
            gatchaButtons = true;
            Debug.Log("Upgrade buttons are now available!");
            SetGatchaButtonVisibility(true); // Rendre le bouton visible
        }
        else
        {
            gatchaButtons = false;
            SetGatchaButtonVisibility(false); // Rendre le bouton invisible
        }

    }

    public void OnMouseDown()
    {
        gatchaClick();
    }

    public void gatchaClick()
    {
        // Définir un nombre alétoire lors d'un clic
        RandomLoot = Random.Range(Minimum, Maximum + 1);

        // Gagner un coeur normal
        if (RandomLoot <= MaxRandomNormal)
        {
            //showStickers = true;

            {
                //stickerCommon1 = true;
                Debug.Log("Upgrade buttons are now available!");
                SetStickerCommon1Visibility(true); // Rendre le stickers visible
                var vfx = Instantiate(RedParticle,Camera.main.transform);
                vfx.transform.localPosition = new Vector3(0, 1, 10);
                shopManagement.bonus = (shopManagement.bonus - Price);
                shopManagement.bonusUI.text = "Ticket : " + shopManagement.bonus;
                nbStickersCommon = nbStickersCommon++;
                //showStickers = false;

                SetValidationButtonVisibility(true);
            }
        }

    }

    public void passVisual()
    {
        //if (showStickers == false)
        //{
            SetStickerCommon1Visibility(false);
            SetValidationButtonVisibility(false);
        //}
        //else
        //{

        //}
    }

    public void showCarnet()
    {
        SetCarnetVisibility(true);
        SetButtonCloseCarnetVisibility(true);
    }


    public void closeCarnet()
    {
        SetCarnetVisibility(false);
        SetButtonCloseCarnetVisibility(false);
    }
    // Méthode pour définir la visibilité du bouton
    void SetGatchaButtonVisibility(bool isVisible)
    {
        if (gatchaButton != null)
        {
            gatchaButton.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon1Visibility(bool isVisible)
    {
        if (stickersCommon1 != null)
        {
            stickersCommon1.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetValidationButtonVisibility(bool isVisible)
    {
        if (passButton != null)
        {
           passButton.SetActive(isVisible);
        }
        else
        {
        }
    }

    void SetCarnetVisibility(bool isVisible)
    {
        if (carnet != null)
        {
            carnet.SetActive(isVisible);
        }
        else
        {
        }
    }

    void SetButtonCloseCarnetVisibility(bool isVisible)
    {
        if(closeCarnetButton != null)
        {
            closeCarnetButton.SetActive(isVisible);
        }
        else
        {
        }
    }

}