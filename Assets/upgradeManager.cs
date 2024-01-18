using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeManager : MonoBehaviour
{
    public shopManagement shopManagement;
    public autoclickManagement autoclickManagement;
    public scoreManager scoreManager;
    public int price = 10;
    public GameObject upgradeButton; // Faites glisser votre bouton UI dans cette variable dans l'inspecteur Unity
    public bool upgradeButtons = false;
    public bool upgradeAutoClick = false;

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
        }
    }

    public void onClick()
    {
        upgradeAutoClick = true;
        autoclickManagement._timeAutoClick = .5f;
        Debug.Log("Upgrade Activated");
        shopManagement.bonus = (shopManagement.bonus - price);
        shopManagement.bonusUI.text = "" + shopManagement.bonus;
    }
}
