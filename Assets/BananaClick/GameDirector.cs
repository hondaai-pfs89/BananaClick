using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    [SerializeField] private GameObject timerText ;
    float timeLeft = 30.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.timerText = GameObject.Find("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text = timeLeft.ToString("F0");

        if (timeLeft < 0)
        {
            Debug.Log("タイムアップ");
            SceneManager.LoadScene("ScoreScene");
        }
    }
}
