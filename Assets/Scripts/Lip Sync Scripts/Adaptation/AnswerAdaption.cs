using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script written by Pablo and editted by Oli for Prototype 7

public class AnswerAdaption : MonoBehaviour
{

    public bool isCorrect = false;
    public QuizManagerAdaption quizManager;

    public Color startColor;

    [HideInInspector] public Image buttonImage;


    private void Start()
    {
        buttonImage = GetComponent<Image>();

        startColor = buttonImage.color;
    }
    public void Answer()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("CorrectAnswer");
            quizManager.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }
}
