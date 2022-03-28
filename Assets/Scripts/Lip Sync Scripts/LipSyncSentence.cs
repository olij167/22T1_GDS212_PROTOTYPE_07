using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sentence")]

//Script written by Oli for Prototype 7

public class LipSyncSentence : ScriptableObject
{
    public string sentence;

    public List<LipSyncWord> wordsInSentence;

    public LipSyncWord hiddenWord;

    public int hiddenWordNumInList;

    //public QnAAdaption QnA;

    
}
