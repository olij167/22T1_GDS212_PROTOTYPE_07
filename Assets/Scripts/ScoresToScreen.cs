using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoresToScreen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text ScoreText;
    [SerializeField] private TMP_Text NotScoreText;
    [SerializeField] private TMP_Text QuestionsText;

    [SerializeField] private ScoreSO score;
    [SerializeField] private NotScoreSO notscore;
    [SerializeField] private Questions questionsSO;


    private void Start()
    {
        NotScoreText.text = score.Value + "";
        ScoreText.text = notscore.Value1 + "";
        QuestionsText.text = questionsSO.Value2 + "";
    }


}
