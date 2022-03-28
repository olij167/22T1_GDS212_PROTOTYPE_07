using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script written by Oli for Prototype 7
public class LipSyncController : MonoBehaviour
{
    public LipSyncWord word;

    public LipSyncSentence sentence;
    
    public Image lipsImage;

    public float spriteDisplayTimer;

    //public List<LipSyncWord> wordsList;
    public List<LipSyncSentence> sentenceList;
    public List<LipSyncWord> potentialAnswersList;


    public int count, hiddenWordIndex;
    void Start()
    {
        lipsImage = GetComponent<Image>();
        potentialAnswersList = new List<LipSyncWord>();


        //word = wordsList[Random.Range(0, wordsList.Count)];
        //lipsImage.sprite = word.lettersInWordList[0].mouthSprite;
        //spriteDisplayTimer = word.letterDisplayTimeList[0];


    }

    void Update()
    {
        spriteDisplayTimer -= Time.deltaTime;

        if (spriteDisplayTimer <= 0)
        {
            count++;

            if (count >= word.lettersInWordList.Count)
            {
                count = 0;
            }


            lipsImage.sprite = word.lettersInWordList[count].mouthSprite;
            spriteDisplayTimer = word.letterDisplayTime;

        }
    }

    public void SetNewSentence()
    {
        sentence = sentenceList[Random.Range(0, sentenceList.Count)];

        ChooseHiddenWord();

        //word = sentence.hiddenWord;

        lipsImage.sprite = word.lettersInWordList[0].mouthSprite;
        spriteDisplayTimer = word.letterDisplayTime;
    }

    public void ChooseHiddenWord()
    {
        //QnA.Answers = wordsInSentence

        //foreach (LipSyncWord word in sentence.wordsInSentence)
        //{
        //    if (word.dontMakeHiddenWord)
        //    {
        //        sentence.wordsInSentence.Remove(word);
        //    }
        //}


        potentialAnswersList.Clear();

       // potentialAnswersList.AddRange(sentence.wordsInSentence);

        foreach (LipSyncWord answer in sentence.wordsInSentence)
        {
            if (!answer.dontMakeHiddenWord)
            {
                potentialAnswersList.Add(answer);
            }
        }

        hiddenWordIndex = Random.Range(0, potentialAnswersList.Count);

        //if (sentence.wordsInSentence[hiddenWordIndex].dontMakeHiddenWord)
        //{
        //    hiddenWordIndex = Random.Range(0, potentialAnswersList.Count);
        //}


        word = potentialAnswersList[hiddenWordIndex];
        
    }

}
