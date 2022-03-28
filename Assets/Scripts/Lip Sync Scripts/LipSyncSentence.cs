using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sentence")]

public class LipSyncSentence : ScriptableObject
{
    public string sentence;

    public List<LipSyncWord> wordsInSentence;

    public LipSyncWord hiddenWord;

    public int hiddenWordNumInList;

    //public QnAAdaption QnA;

    
}
