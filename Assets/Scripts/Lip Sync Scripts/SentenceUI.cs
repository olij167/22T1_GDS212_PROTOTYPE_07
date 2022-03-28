using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Script written by Oli for Prototype 7

public class SentenceUI : MonoBehaviour
{
    public LipSyncController lipSyncController;

    public TextMeshProUGUI sentenceUIText;

    public string sentenceText, hiddenWord;


    void Start()
    {
        lipSyncController.SetNewSentence();

        
        SetSentenceUI();
    }

    
    void Update()
    {
        
    }

    void SetSentenceUI()
    {
        sentenceText = lipSyncController.sentence.sentence;

        hiddenWord = lipSyncController.sentence.hiddenWord.word;

        sentenceUIText.text = sentenceText.Replace(hiddenWord, " _?_ ");
    }
}
