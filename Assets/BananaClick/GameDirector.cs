using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    [SerializeField] private GameObject timerText ;
    [SerializeField] private GameObject scoreText ;
    float timeLeft = 30.0f;
    int score = 0;
    public static int finalScore = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.timerText = GameObject.Find("Timer");
        this.scoreText = GameObject.Find("CurrentScore");
    }

    public void ClickYellowBanana()
    {
        score += 1;
    }

    public void ClickGreenBanana()
    {
        score -= 2;
    }

    public void ClickGoldenBanana()
    {
        score += 5;
    }

    public void FinalizeScore()
    {
        GameDirector.finalScore = score;
        Debug.Log("Final Score: " + GameDirector.finalScore.ToString("D2"));
    }

    // Update is called once per frame
    public void Update()
    {
        timeLeft -= Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text = timeLeft.ToString("F0");
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + score.ToString("D2");

        if (timeLeft < 0)
        {
            FinalizeScore();
            SceneManager.LoadScene("ScoreScene");
            
        }
    }
    
}