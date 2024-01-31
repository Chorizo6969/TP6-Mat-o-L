using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI text_score;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Score")
        {
            Debug.Log("+1");
            score ++ ;
            text_score.text = score.ToString();
        }
    }
}
