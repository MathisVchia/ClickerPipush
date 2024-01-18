using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTicketsManager : MonoBehaviour
{
    public shopManagement shopManagement;
    public scoreManager scoreManager;
    public GameObject upgradeTicketsButton; // Faites glisser votre bouton UI dans cette variable dans l'inspecteur Unity
    public bool upgradeTicketsButtons = false;

    public int upgrade = 5;

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
            upgradeTicketsButtons = true;
            Debug.Log("Upgrade buttons are now available!");
            SetUpgradeButtonVisibility(true); // Rendre le bouton visible
        }
        else
        {
            upgradeTicketsButtons = false;
            SetUpgradeButtonVisibility(false); // Rendre le bouton invisible
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetUpgradeButtonVisibility(bool isVisible)
    {
        if (upgradeTicketsButton != null)
        {
            upgradeTicketsButton.SetActive(isVisible);
        }
        else
        {
            Debug.LogWarning("Veuillez faire glisser le bouton UI dans la variable Upgrade Button dans l'inspecteur Unity.");
        }
    }

    public void upgradeTickets()
    {
        shopManagement.bonus = (shopManagement.bonus + upgrade);
        shopManagement.bonusUI.text = "" + shopManagement.bonus;
        scoreManager.score = (scoreManager.score - upgrade);
        scoreManager.scoreUI.text = "Score : " + scoreManager.score;
    }
}
