using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script written by Oli for Prototype 7
public class LipSyncController : MonoBehaviour
{
    public string word; // << will be used to check the answer
    
    public Image lipsImage;

    public float spriteDisplayTimer;

    public List<LipSyncLetter> lettersInWordList; // << fill in inspector with each letter of the word in order
    public List<float> letterDisplayTime; // << fill in inspector with how long each letter should be displayed before showing the next sprite
                                          // must be the same element number as the letter

    public int count;
    void Start()
    {
        lipsImage.sprite = lettersInWordList[0].mouthSprite;
        spriteDisplayTimer = letterDisplayTime[0];
    }

    // Update is called once per frame
    void Update()
    {
        spriteDisplayTimer -= Time.deltaTime;

        if (spriteDisplayTimer <= 0)
        {
            count++;

            if (count >= lettersInWordList.Count)
            {
                count = 0;
            }


            lipsImage.sprite = lettersInWordList[count].mouthSprite;
            spriteDisplayTimer = letterDisplayTime[count];

        }
    }
}
