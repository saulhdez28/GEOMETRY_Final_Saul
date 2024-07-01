using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Serializable]
public class CollectibleUI
{
    [SerializeField]
    CollectibleType collectibleType;

    [SerializeField]
    TextMeshProUGUI textbox;

    public CollectibleType GetCollectibleType() 
    { return collectibleType; }

    public TextMeshProUGUI GetTextbox() 
    {  return textbox; }
}
