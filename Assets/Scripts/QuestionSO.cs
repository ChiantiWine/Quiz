using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string Question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion() // Void가 들어갈 때는 반환 x 
    {
        return Question;
    }
     public string GetAnswer(int index) 
    {
    
        return answers[index];
    }
    public int GetCorrentAnswerIndex()
    {

        return correctAnswerIndex;
    }
   
}
