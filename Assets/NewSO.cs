using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewSO : MonoBehaviour
{
    [SerializeField]
    private TMP_Text Right;
    [SerializeField]
    private TMP_Text Wrong;
    [SerializeField]
    private TMP_Text Questions;


    [SerializeField]
    private FloatSO scoreSO;
    [SerializeField]
    private NotScore notScoreSO;
    [SerializeField]
    private QuestionsAnswerSO questionsSO;



    private void Start()
    {
        Right.text = scoreSO.Value + "";
        Questions.text = questionsSO.Value2 + "";
        Wrong.text = notScoreSO.Value1 + "";
    }
}
