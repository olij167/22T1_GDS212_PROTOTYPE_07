using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerAdaption : MonoBehaviour
{

    public bool isCorrect = false;
    public QuizManagerAdaption quizManager;

    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("CorrectAnswer");
            quizManager.correct();
        } else
        {
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    } 
}
