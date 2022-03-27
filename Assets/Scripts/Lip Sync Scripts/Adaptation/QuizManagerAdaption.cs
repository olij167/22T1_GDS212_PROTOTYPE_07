using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManagerAdaption : MonoBehaviour
{
    //public List<QnAAdaption> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject quizPanel;
    public GameObject GOPanel;


    public TextMeshProUGUI QuestionTxt;
    public TextMeshProUGUI scoreText;

    public int totalQuestions;
    public int score;

    public LipSyncController lipSyncController;

    public List<LipSyncWord> answersList;


    private void Start()
    {
        //foreach (LipSyncWord word in answersList)
        //{
        //    if (word.dontMakeHiddenWord)
        //    {
        //        answersList.Remove(word);
        //    }
        //}

        
        totalQuestions = lipSyncController.sentenceList.Count;
        GOPanel.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        quizPanel.SetActive(false);
        GOPanel.SetActive(true);
        scoreText.text = score + "/" + totalQuestions;
    }

    public void correct()
    {
        score += 1;
        lipSyncController.sentenceList.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        lipSyncController.sentenceList.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        int randButtonIndex = Random.Range(0, options.Length);

        options[randButtonIndex].GetComponent<AnswerAdaption>().isCorrect = true;

        options[randButtonIndex].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = lipSyncController.sentence.hiddenWord.word;

        
        foreach (GameObject button in options)
        {
            if (button != options[randButtonIndex])
            {
                button.GetComponent<AnswerAdaption>().isCorrect = false;

                int randomWrongAnswer = Random.Range(0, answersList.Count);

                if (answersList[randomWrongAnswer] == lipSyncController.word)
                {
                    randomWrongAnswer = Random.Range(0, answersList.Count);
                }

                for (int i = 0; i < options.Length; i++)
                {
                    if (options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text != answersList[randomWrongAnswer].word)
                    {

                        button.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = answersList[randomWrongAnswer].word;

                    }
                    else randomWrongAnswer = Random.Range(0, answersList.Count);
                }



            }
        }
        


        //for (int i = 0; i < options.Length; i++)
        //{
            
            //if (i != randButtonIndex)
            //{

            //}


            //options[i].GetComponent<AnswerScript>().isCorrect = false;
            //options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].answer.word;

            //if(QnA[currentQuestion].CorrectAnswers == i+1)
            //{
            //    options[i].GetComponent<AnswerScript>().isCorrect = true;
            //}
        //}
    }
    void generateQuestion()
    {
        if(lipSyncController.sentenceList.Count > 0)
        {
            lipSyncController.SetNewSentence();
            
            //currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = lipSyncController.sentence.sentence.Replace(lipSyncController.word.word, " _?_ ");
            //QuestionTxt.

            SetAnswers();
        } else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }

    }

    //void SetSentenceUI()
    //{
    //    sentenceText = lipSyncController.sentence.sentence;

    //    hiddenWord = lipSyncController.sentence.hiddenWord.word;

    //    sentenceUIText.text = sentenceText.Replace(hiddenWord, " _?_ ");
    //}

    //public void SetNewSentence()
    //{
    //    sentence = sentenceList[Random.Range(0, sentenceList.Count)];
    //    sentence.ChooseHiddenWord();

    //    word = sentence.hiddenWord;

    //    lipsImage.sprite = word.lettersInWordList[0].mouthSprite;
    //    spriteDisplayTimer = word.letterDisplayTime;
    //}
}