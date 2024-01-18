using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatchaManagement : MonoBehaviour
{

    public shopManagement shopManagement;
    public GameObject gatchaButton;
    public GameObject stickersCommon1;
    public GameObject stickersCommon2;
    public GameObject stickersCommon3;
    public GameObject stickersCommon4;
    public GameObject stickersCommon5;
    public GameObject stickersCommon1Carnet;
    public GameObject stickersCommon2Carnet;
    public GameObject stickersCommon3Carnet;
    public GameObject stickersCommon4Carnet;
    public GameObject stickersCommon5Carnet;
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
    public int nbStickersCommon = 0;
    public int nbStickersCommon2 = 0;
    public int nbStickersCommon3 = 0;
    public int nbStickersCommon4 = 0;
    public int nbStickersCommon5 = 0;

    public int MaxRandomStickers1;
    public int MaxRandomStickers2;
    public int MaxRandomStickers3;
    public int MaxRandomStickers4;
    public int MaxRandomStickers5;

    public GameObject RedParticle;

    // Start is called before the first frame update
    void Start()
    {
        SetGatchaButtonVisibility(false);
        SetStickerCommon1Visibility(false);
        SetStickerCommon2Visibility(false);
        SetStickerCommon3Visibility(false);
        SetStickerCommon4Visibility(false);
        SetStickerCommon5Visibility(false);
        SetStickerCommon1CarnetVisibility(false);
        SetStickerCommon2CarnetVisibility(false);
        SetStickerCommon3CarnetVisibility(false);
        SetStickerCommon4CarnetVisibility(false);
        SetStickerCommon5CarnetVisibility(false);
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

        // Gagner un chat commun
        if (RandomLoot <= MaxRandomStickers1)
        {
            //showStickers = true;

            {
                //stickerCommon1 = true;
                Debug.Log("Upgrade buttons are now available!");
                SetStickerCommon1Visibility(true); // Rendre le stickers visible
                var vfx = Instantiate(RedParticle,Camera.main.transform);
                vfx.transform.localPosition = new Vector3(0, 1, 10);
                shopManagement.bonus = (shopManagement.bonus - Price);
                shopManagement.bonusUI.text = "" + shopManagement.bonus;
                nbStickersCommon++;
                //showStickers = false;
                SetValidationButtonVisibility(true);

            }
        }

        // Gagner un chat commun 2
        if (RandomLoot > MaxRandomStickers1 && RandomLoot <= MaxRandomStickers2)
        {
            //showStickers = true;

            {
                Debug.Log("Upgrade buttons are now available!");
                SetStickerCommon2Visibility(true); // Rendre le stickers visible
                var vfx = Instantiate(RedParticle, Camera.main.transform);
                vfx.transform.localPosition = new Vector3(0, 1, 10);
                shopManagement.bonus = (shopManagement.bonus - Price);
                shopManagement.bonusUI.text = "" + shopManagement.bonus;
                nbStickersCommon2++;
                //showStickers = false;
                SetValidationButtonVisibility(true);

            }
        }

        // Gagner un chat commun 3
        if (RandomLoot > MaxRandomStickers2 && RandomLoot <= MaxRandomStickers3)
        {
            //showStickers = true;

            {
                Debug.Log("Upgrade buttons are now available!");
                SetStickerCommon3Visibility(true); // Rendre le stickers visible
                var vfx = Instantiate(RedParticle, Camera.main.transform);
                vfx.transform.localPosition = new Vector3(0, 1, 10);
                shopManagement.bonus = (shopManagement.bonus - Price);
                shopManagement.bonusUI.text = "" + shopManagement.bonus;
                nbStickersCommon3++;
                //showStickers = false;
                SetValidationButtonVisibility(true);

            }
        }

        // Gagner un chat commun 4
        if (RandomLoot > MaxRandomStickers3 && RandomLoot <= MaxRandomStickers4)
        {
            //showStickers = true;

            {
                Debug.Log("Upgrade buttons are now available!");
                SetStickerCommon4Visibility(true); // Rendre le stickers visible
                var vfx = Instantiate(RedParticle, Camera.main.transform);
                vfx.transform.localPosition = new Vector3(0, 1, 10);
                shopManagement.bonus = (shopManagement.bonus - Price);
                shopManagement.bonusUI.text = "" + shopManagement.bonus;
                nbStickersCommon4++;
                //showStickers = false;
                SetValidationButtonVisibility(true);

            }
        }

        // Gagner un chat commun 5
        if (RandomLoot > MaxRandomStickers3 && RandomLoot <= MaxRandomStickers4)
        {
            //showStickers = true;

            {
                Debug.Log("Upgrade buttons are now available!");
                SetStickerCommon5Visibility(true); // Rendre le stickers visible
                var vfx = Instantiate(RedParticle, Camera.main.transform);
                vfx.transform.localPosition = new Vector3(0, 1, 10);
                shopManagement.bonus = (shopManagement.bonus - Price);
                shopManagement.bonusUI.text = "" + shopManagement.bonus;
                nbStickersCommon5++;
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
            SetStickerCommon2Visibility(false);
            SetStickerCommon3Visibility(false);
            SetStickerCommon4Visibility(false);
            SetStickerCommon5Visibility(false);
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
        if (nbStickersCommon >= 1)
        {
            SetStickerCommon1CarnetVisibility(true);

            // Position aléatoire
            Vector3 randomPosition = new Vector3(380, 510, 0);
            stickersCommon1Carnet.transform.position = randomPosition;

            // Rotation aléatoire
            //float randomRotationX = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            float randomRotationY = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            Quaternion randomRotation = Quaternion.Euler(0, randomRotationY, 0);
            stickersCommon1Carnet.transform.rotation = randomRotation;

            Debug.Log("Already have stickers");
        }

        if (nbStickersCommon2 >= 1)
        {
            SetStickerCommon2CarnetVisibility(true);

            // Position aléatoire
            Vector3 randomPosition = new Vector3(160, 380, 0);
            stickersCommon2Carnet.transform.position = randomPosition;

            // Rotation aléatoire
            //float randomRotationX = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            float randomRotationY = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            Quaternion randomRotation = Quaternion.Euler(0, randomRotationY, 0);
            stickersCommon2Carnet.transform.rotation = randomRotation;

            Debug.Log("Already have stickers");
        }

        if (nbStickersCommon3 >= 1)
        {
            SetStickerCommon3CarnetVisibility(true);

            // Position aléatoire
            Vector3 randomPosition = new Vector3(220, 610, 0);
            stickersCommon3Carnet.transform.position = randomPosition;

            // Rotation aléatoire
            //float randomRotationX = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            float randomRotationY = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            Quaternion randomRotation = Quaternion.Euler(0, randomRotationY, 0);
            stickersCommon3Carnet.transform.rotation = randomRotation;

            Debug.Log("Already have stickers");
        }

        if (nbStickersCommon4 >= 1)
        {
            SetStickerCommon4CarnetVisibility(true);

            // Position aléatoire
            Vector3 randomPosition = new Vector3(250, 530, 0);
            stickersCommon4Carnet.transform.position = randomPosition;

            // Rotation aléatoire
            //float randomRotationX = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            float randomRotationY = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            Quaternion randomRotation = Quaternion.Euler(0, randomRotationY, 0);
            stickersCommon4Carnet.transform.rotation = randomRotation;

            Debug.Log("Already have stickers");
        }

        if (nbStickersCommon5 >= 1)
        {
            SetStickerCommon5CarnetVisibility(true);

            // Position aléatoire
            Vector3 randomPosition = new Vector3(180, 580, 0);
            stickersCommon5Carnet.transform.position = randomPosition;

            // Rotation aléatoire
            //float randomRotationX = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            float randomRotationY = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            Quaternion randomRotation = Quaternion.Euler(0, randomRotationY, 0);
            stickersCommon5Carnet.transform.rotation = randomRotation;

            Debug.Log("Already have stickers");
        }
    }


    public void closeCarnet()
    {
        SetCarnetVisibility(false);
        SetButtonCloseCarnetVisibility(false);
        SetStickerCommon1CarnetVisibility(false);
        SetStickerCommon2CarnetVisibility(false);
        SetStickerCommon3CarnetVisibility(false);
        SetStickerCommon4CarnetVisibility(false);
        SetStickerCommon5CarnetVisibility(false);
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
    void SetStickerCommon2Visibility(bool isVisible)
    {
        if (stickersCommon2 != null)
        {
            stickersCommon2.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon3Visibility(bool isVisible)
    {
        if (stickersCommon3 != null)
        {
            stickersCommon3.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon4Visibility(bool isVisible)
    {
        if (stickersCommon4 != null)
        {
            stickersCommon4.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon5Visibility(bool isVisible)
    {
        if (stickersCommon5 != null)
        {
            stickersCommon5.SetActive(isVisible);
        }
        else
        {
        }
    }



    // STICKERS DU CARNET

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon1CarnetVisibility(bool isVisible)
    {
        if (stickersCommon1Carnet != null)
        {
            stickersCommon1Carnet.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon2CarnetVisibility(bool isVisible)
    {
        if (stickersCommon2Carnet != null)
        {
            stickersCommon2Carnet.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon3CarnetVisibility(bool isVisible)
    {
        if (stickersCommon3Carnet != null)
        {
            stickersCommon3Carnet.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon4CarnetVisibility(bool isVisible)
    {
        if (stickersCommon4Carnet != null)
        {
            stickersCommon4Carnet.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon5CarnetVisibility(bool isVisible)
    {
        if (stickersCommon5Carnet != null)
        {
            stickersCommon5Carnet.SetActive(isVisible);
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