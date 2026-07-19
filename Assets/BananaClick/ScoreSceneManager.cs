using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreSceneDirector : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI finalScoreText;

    public void OnRetryButtonClicked()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnBackToTitleButtonClicked()
    {
        SceneManager.LoadScene("TitleScene");
    }
    
    void Start()
    {
        finalScoreText.text = "スコア: " + GameDirector.finalScore.ToString("D2");
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
}
