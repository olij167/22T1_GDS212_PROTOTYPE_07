using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            buttonImage.color = Color.green;
            Debug.Log("CorrectAnswer");
            quizManager.correct();
        }
        else
        {
            buttonImage.color = Color.red;
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }
}
