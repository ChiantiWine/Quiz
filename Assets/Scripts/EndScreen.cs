using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;
    void Awake()
    {
        scoreKeeper = FindAnyObjectByType<ScoreKeeper>();
    }

   public void ShowFinalScore()
    {
        finalScoreText.text = "축하해!\n 너의 점수는 " + scoreKeeper.CalculateScore() + "%";
    }


}
;