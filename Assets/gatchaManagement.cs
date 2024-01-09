using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatchaManagement : MonoBehaviour
{

    public StickersScriptableObject[] allStickersDatas;
    public SpriteRenderer SpriteRenderer;
    private StickersScriptableObject CurrentStickers;

    public bool stickersActiv;

    // Start is called before the first frame update
    void Start()
    {
        stickersActiv = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StickersSpawn()
    {
        CurrentStickers = StickersList[Random.Range(0, StickersList.Lenght)];

        StickersRenderer.sprite = CurrentStickers.Appareance;
        StickersRenderer.enabled = true;
        stickersActiv = true;
    }
}
