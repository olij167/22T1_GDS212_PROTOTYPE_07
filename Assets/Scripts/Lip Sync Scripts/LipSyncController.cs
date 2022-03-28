using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script written by Oli for Prototype 7
public class LipSyncController : MonoBehaviour
{
    public LipSyncWord word;

    public LipSyncSentence sentence;
    
    Image lipsImage;

    public float spriteDisplayTimer;

    //public List<LipSyncWord> wordsList;
    public List<LipSyncSentence> sentenceList;


    public int count;
    void Start()
    {
        lipsImage = GetComponent<Image>();


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
        sentence.ChooseHiddenWord();

        word = sentence.hiddenWord;

        lipsImage.sprite = word.lettersInWordList[0].mouthSprite;
        spriteDisplayTimer = word.letterDisplayTime;
    }

}
