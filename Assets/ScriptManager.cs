using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class ScriptManager : MonoBehaviour
{
    public List<QA> QnA;
    public GameObject[] options;
    public int currentQuestion;


    public TMP_Text QuestionTxt;
    public TMP_Text ScoreTxt;

    public GameObject Quizpanel;
    public GameObject GoPanel;

    int totalQuestions = 0;
    public int score;

    private void Start()
    {
        totalQuestions = QnA.Count;
        Quizpanel.SetActive(true);
        GoPanel.SetActive(false);
        genQ();
    }
    public void retry()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadSceneAsync(currentScene.buildIndex);
    }
    public void mainmenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    void GameOver()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
        ScoreTxt.text = score + "/" + totalQuestions;
    }
    public void correct() 
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        genQ();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        genQ();
    }

    void setA() 
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AS>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1) 
            {
                options[i].GetComponent<AS>().isCorrect = true;
            }
        }
    }
    void genQ() 
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            setA();
        }
        else
        {
            Debug.Log("That's All");
            GameOver();
        }
    }
}
