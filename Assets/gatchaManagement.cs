using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatchaManagement : MonoBehaviour
{

    public shopManagement shopManagement;
    public GameObject gatchaButton;
    public GameObject stickersCommon1;
    public bool gatchaButtons = false;

    // Gestion des taux d'obtentions
    public int RandomLoot;
    public int Minimum = 0;
    public int Maximum = 100;

    public int MaxRandomNormal;
    public int MaxRandomGold;

    // Start is called before the first frame update
    void Start()
    {
        SetGatchaButtonVisibility(false);
        SetStickerCommon1Visibility(false);
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
        // D�finir un nombre al�toire lors d'un clic
        RandomLoot = Random.Range(Minimum, Maximum + 1);

        // Gagner un coeur normal
        if (RandomLoot <= MaxRandomNormal)
        {
            //stickerCommon1 = true;
            Debug.Log("Upgrade buttons are now available!");
            SetStickerCommon1Visibility(true); // Rendre le stickers visible
            shopManagement.bonus--;
            shopManagement.bonusUI.text = "Ticket : " + shopManagement.bonus;
        }

    }

    // M�thode pour d�finir la visibilit� du bouton
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

    // M�thode pour d�finir la visibilit� du bouton
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

}