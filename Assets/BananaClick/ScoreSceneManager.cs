using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreSceneDirector : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI finalScoreText;

    public void Retry()
    {
        SceneManager.LoadScene("GameScene");
    }
    
    void Start()
    {
        finalScoreText.text = "Score: " + GameDirector.finalScore.ToString("D2");
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
}
