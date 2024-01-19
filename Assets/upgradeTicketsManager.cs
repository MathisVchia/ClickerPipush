using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTicketsManager : MonoBehaviour
{
    public shopManagement shopManagement;
    public scoreManager scoreManager;
    public GameObject UpgradeTicketsButton; // Faites glisser votre bouton UI dans cette variable dans l'inspecteur Unity
    public bool UpgradeTicketsButtons = false;

    public int Upgrade = 5;

    // Start is called before the first frame update
    void Start()
    {
        // Assurez-vous que le bouton est initialement invisible au démarrage
        SetUpgradeButtonVisibility(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (shopManagement.bonus > 25)
        {
            UpgradeTicketsButtons = true;
            Debug.Log("Upgrade buttons are now available!");
            SetUpgradeButtonVisibility(true); // Rendre le bouton visible
        }
        else
        {
            UpgradeTicketsButtons = false;
            SetUpgradeButtonVisibility(false); // Rendre le bouton invisible
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetUpgradeButtonVisibility(bool isVisible)
    {
        if (UpgradeTicketsButton != null)
        {
            UpgradeTicketsButton.SetActive(isVisible);
        }
        else
        {
            Debug.LogWarning("Veuillez faire glisser le bouton UI dans la variable Upgrade Button dans l'inspecteur Unity.");
        }
    }

    public void upgradeTickets()
    {
        shopManagement.bonus = (shopManagement.bonus + Upgrade);
        shopManagement.bonusUI.text = "" + shopManagement.bonus;
        scoreManager.score = (scoreManager.score - Upgrade);
        scoreManager.scoreUI.text = "Score : " + scoreManager.score;
    }
}
