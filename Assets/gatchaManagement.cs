using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatchaManagement : MonoBehaviour
{

    public shopManagement shopManagement;
    public GameObject GatchaButton;
    public GameObject StickersCommon1;
    public GameObject StickersCommon2;
    public GameObject StickersCommon3;
    public GameObject StickersCommon4;
    public GameObject StickersCommon5;
    public GameObject StickersCommon1Carnet;
    public GameObject StickersCommon2Carnet;
    public GameObject StickersCommon3Carnet;
    public GameObject StickersCommon4Carnet;
    public GameObject StickersCommon5Carnet;
    public GameObject PassButton;
    public GameObject Carnet;
    public GameObject CloseCarnetButton;
    public bool GatchaButtons = false;
    public bool ShowStickers = false;

    // Gestion des taux d'obtentions
    public int RandomLoot;
    public int Minimum = 0;
    public int Maximum = 100;
    public int Price = 30;
    public int NbStickersCommon = 0;
    public int NbStickersCommon2 = 0;
    public int NbStickersCommon3 = 0;
    public int NbStickersCommon4 = 0;
    public int NbStickersCommon5 = 0;

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
            GatchaButtons = true;
            Debug.Log("Upgrade buttons are now available!");
            SetGatchaButtonVisibility(true); // Rendre le bouton visible
        }
        else
        {
            GatchaButtons = false;
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
            //ShowStickers = true;

            {
                //stickerCommon1 = true;
                Debug.Log("Upgrade buttons are now available!");
                SetStickerCommon1Visibility(true); // Rendre le stickers visible
                var vfx = Instantiate(RedParticle,Camera.main.transform);
                vfx.transform.localPosition = new Vector3(0, 1, 10);
                shopManagement.bonus = (shopManagement.bonus - Price);
                shopManagement.bonusUI.text = "" + shopManagement.bonus;
                NbStickersCommon++;
                //ShowStickers = false;
                SetValidationButtonVisibility(true);

            }
        }

        // Gagner un chat commun 2
        if (RandomLoot > MaxRandomStickers1 && RandomLoot <= MaxRandomStickers2)
        {
            //ShowStickers = true;

            {
                Debug.Log("Upgrade buttons are now available!");
                SetStickerCommon2Visibility(true); // Rendre le stickers visible
                var vfx = Instantiate(RedParticle, Camera.main.transform);
                vfx.transform.localPosition = new Vector3(0, 1, 10);
                shopManagement.bonus = (shopManagement.bonus - Price);
                shopManagement.bonusUI.text = "" + shopManagement.bonus;
                NbStickersCommon2++;
                //ShowStickers = false;
                SetValidationButtonVisibility(true);

            }
        }

        // Gagner un chat commun 3
        if (RandomLoot > MaxRandomStickers2 && RandomLoot <= MaxRandomStickers3)
        {
            //ShowStickers = true;

            {
                Debug.Log("Upgrade buttons are now available!");
                SetStickerCommon3Visibility(true); // Rendre le stickers visible
                var vfx = Instantiate(RedParticle, Camera.main.transform);
                vfx.transform.localPosition = new Vector3(0, 1, 10);
                shopManagement.bonus = (shopManagement.bonus - Price);
                shopManagement.bonusUI.text = "" + shopManagement.bonus;
                NbStickersCommon3++;
                //ShowStickers = false;
                SetValidationButtonVisibility(true);

            }
        }

        // Gagner un chat commun 4
        if (RandomLoot > MaxRandomStickers3 && RandomLoot <= MaxRandomStickers4)
        {
            //ShowStickers = true;

            {
                Debug.Log("Upgrade buttons are now available!");
                SetStickerCommon4Visibility(true); // Rendre le stickers visible
                var vfx = Instantiate(RedParticle, Camera.main.transform);
                vfx.transform.localPosition = new Vector3(0, 1, 10);
                shopManagement.bonus = (shopManagement.bonus - Price);
                shopManagement.bonusUI.text = "" + shopManagement.bonus;
                NbStickersCommon4++;
                //ShowStickers = false;
                SetValidationButtonVisibility(true);

            }
        }

        // Gagner un chat commun 5
        if (RandomLoot > MaxRandomStickers3 && RandomLoot <= MaxRandomStickers4)
        {
            //ShowStickers = true;

            {
                Debug.Log("Upgrade buttons are now available!");
                SetStickerCommon5Visibility(true); // Rendre le stickers visible
                var vfx = Instantiate(RedParticle, Camera.main.transform);
                vfx.transform.localPosition = new Vector3(0, 1, 10);
                shopManagement.bonus = (shopManagement.bonus - Price);
                shopManagement.bonusUI.text = "" + shopManagement.bonus;
                NbStickersCommon5++;
                //ShowStickers = false;
                SetValidationButtonVisibility(true);

            }
        }
    }

    public void passVisual()
    {
        //if (ShowStickers == false)
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
        if (NbStickersCommon >= 1)
        {
            SetStickerCommon1CarnetVisibility(true);

            // Position aléatoire
            Vector3 randomPosition = new Vector3(380, 510, 0);
            StickersCommon1Carnet.transform.position = randomPosition;

            // Rotation aléatoire
            //float randomRotationX = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            float randomRotationY = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            Quaternion randomRotation = Quaternion.Euler(0, randomRotationY, 0);
            StickersCommon1Carnet.transform.rotation = randomRotation;

            Debug.Log("Already have stickers");
        }

        if (NbStickersCommon2 >= 1)
        {
            SetStickerCommon2CarnetVisibility(true);

            // Position aléatoire
            Vector3 randomPosition = new Vector3(160, 380, 0);
            StickersCommon2Carnet.transform.position = randomPosition;

            // Rotation aléatoire
            //float randomRotationX = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            float randomRotationY = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            Quaternion randomRotation = Quaternion.Euler(0, randomRotationY, 0);
            StickersCommon2Carnet.transform.rotation = randomRotation;

            Debug.Log("Already have stickers");
        }

        if (NbStickersCommon3 >= 1)
        {
            SetStickerCommon3CarnetVisibility(true);

            // Position aléatoire
            Vector3 randomPosition = new Vector3(220, 610, 0);
            StickersCommon3Carnet.transform.position = randomPosition;

            // Rotation aléatoire
            //float randomRotationX = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            float randomRotationY = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            Quaternion randomRotation = Quaternion.Euler(0, randomRotationY, 0);
            StickersCommon3Carnet.transform.rotation = randomRotation;

            Debug.Log("Already have stickers");
        }

        if (NbStickersCommon4 >= 1)
        {
            SetStickerCommon4CarnetVisibility(true);

            // Position aléatoire
            Vector3 randomPosition = new Vector3(250, 530, 0);
            StickersCommon4Carnet.transform.position = randomPosition;

            // Rotation aléatoire
            //float randomRotationX = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            float randomRotationY = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            Quaternion randomRotation = Quaternion.Euler(0, randomRotationY, 0);
            StickersCommon4Carnet.transform.rotation = randomRotation;

            Debug.Log("Already have stickers");
        }

        if (NbStickersCommon5 >= 1)
        {
            SetStickerCommon5CarnetVisibility(true);

            // Position aléatoire
            Vector3 randomPosition = new Vector3(180, 580, 0);
            StickersCommon5Carnet.transform.position = randomPosition;

            // Rotation aléatoire
            //float randomRotationX = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            float randomRotationY = Random.Range(0f, 45f); // Modifiez les valeurs selon vos besoins
            Quaternion randomRotation = Quaternion.Euler(0, randomRotationY, 0);
            StickersCommon5Carnet.transform.rotation = randomRotation;

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
        if (GatchaButton != null)
        {
            GatchaButton.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon1Visibility(bool isVisible)
    {
        if (StickersCommon1 != null)
        {
            StickersCommon1.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon2Visibility(bool isVisible)
    {
        if (StickersCommon2 != null)
        {
            StickersCommon2.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon3Visibility(bool isVisible)
    {
        if (StickersCommon3 != null)
        {
            StickersCommon3.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon4Visibility(bool isVisible)
    {
        if (StickersCommon4 != null)
        {
            StickersCommon4.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon5Visibility(bool isVisible)
    {
        if (StickersCommon5 != null)
        {
            StickersCommon5.SetActive(isVisible);
        }
        else
        {
        }
    }



    // STICKERS DU CARNET

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon1CarnetVisibility(bool isVisible)
    {
        if (StickersCommon1Carnet != null)
        {
            StickersCommon1Carnet.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon2CarnetVisibility(bool isVisible)
    {
        if (StickersCommon2Carnet != null)
        {
            StickersCommon2Carnet.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon3CarnetVisibility(bool isVisible)
    {
        if (StickersCommon3Carnet != null)
        {
            StickersCommon3Carnet.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon4CarnetVisibility(bool isVisible)
    {
        if (StickersCommon4Carnet != null)
        {
            StickersCommon4Carnet.SetActive(isVisible);
        }
        else
        {
        }
    }

    // Méthode pour définir la visibilité du bouton
    void SetStickerCommon5CarnetVisibility(bool isVisible)
    {
        if (StickersCommon5Carnet != null)
        {
            StickersCommon5Carnet.SetActive(isVisible);
        }
        else
        {
        }
    }


    // Méthode pour définir la visibilité du bouton
    void SetValidationButtonVisibility(bool isVisible)
    {
        if (PassButton != null)
        {
           PassButton.SetActive(isVisible);
        }
        else
        {
        }
    }

    void SetCarnetVisibility(bool isVisible)
    {
        if (Carnet != null)
        {
            Carnet.SetActive(isVisible);
        }
        else
        {
        }
    }

    void SetButtonCloseCarnetVisibility(bool isVisible)
    {
        if(CloseCarnetButton != null)
        {
            CloseCarnetButton.SetActive(isVisible);
        }
        else
        {
        }
    }

}