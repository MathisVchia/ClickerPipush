using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatchaManagement : MonoBehaviour
{

    public StickersScriptableObject[] allStickersDatas;
    public StickersScriptableObject stickersData;

    // Start is called before the first frame update
    void Start()
    {
        stickersData = allStickersDatas[Random.Range(0, allStickersDatas.Lenght)];
        gameObject.GetComponent<Image>().sprite = stickersData.spriteStickers;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
