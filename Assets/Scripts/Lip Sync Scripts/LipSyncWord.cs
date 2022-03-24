using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script written by Oli for Prototype 7

[CreateAssetMenu(menuName = "Word")]

public class LipSyncWord : ScriptableObject
{
    public string word;
    public List<LipSyncLetter> lettersInWordList; // << fill in inspector with each letter of the word in order

    public List<float> letterDisplayTimeList; // << fill in inspector with how long each letter should be displayed before showing the next sprite
                                           // must be the same element number as the corresponding letter

}
