using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StickersManager", menuName = "Stickers", order = 0)]

public class ScriptableObjectStickers : ScriptableObject
{
    // D�finir les diff�rentes caract�ristiques des ennemis
    public Sprite Appareance;
    public int Percentage;
    public string StickersName;
}