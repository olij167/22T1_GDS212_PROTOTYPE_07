using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script written by Oli for Prototype 7

[CreateAssetMenu (menuName = "Letter")]

//  SET UP INSTRUCTIONS
// 1. In project window > right click > Create > Letter (top of menu)
// 2. Name it after the letter
// 3. set letter and mouth sprite in the inspector
// 4. create for every letter of the alphabet
public class LipSyncLetter : ScriptableObject
{
    public string letter;
    public Sprite mouthSprite;
}
