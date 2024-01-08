using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public shopManagement shopManagement;
    public GameObject upgradeButton; // Faites glisser votre bouton UI dans cette variable dans l'inspecteur Unity
    public bool upgradeButtons = false;

    // Start is called before the first frame update
    void Start()
    {
        // Assurez-vous que le bouton est initialement invisible au démarrage
        SetUpgradeButtonVisibility(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (shopManagement.bonus > 10)
        {
            upgradeButtons = true;
            Debug.Log("Upgrade buttons are now available!");
            SetUpgradeButtonVisibility(true); // Rendre le bouton visible
        }
        else
        {
            upgradeButtons = false;
            SetUpgradeButtonVisibility(false); // Rendre le bouton invisible
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetUpgradeButtonVisibility(bool isVisible)
    {
        if (upgradeButton != null)
        {
            upgradeButton.SetActive(isVisible);
        }
        else
        {
            Debug.LogWarning("Veuillez faire glisser le bouton UI dans la variable Upgrade Button dans l'inspecteur Unity.");
        }
    }
}
