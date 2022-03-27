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

    public void ChooseHiddenWord()
    {
        //QnA.Answers = wordsInSentence

        hiddenWordNumInList = Random.Range(0, wordsInSentence.Count);

        if (wordsInSentence[hiddenWordNumInList].dontMakeHiddenWord)
        {
            hiddenWordNumInList = Random.Range(0, wordsInSentence.Count);
        }
        else hiddenWord = wordsInSentence[hiddenWordNumInList];
    }
}
