using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score_manager : MonoBehaviour
{
    public static score_manager instance;
    public TMP_Text score_text;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score_text.text = score.ToString() + "/100 Points";  
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 100)
        {
            score_text.text = "YOU WON";
        }
    }
    public void addPoints()
    {
        score += 1;
        score_text.text = score.ToString() + "/100 Points";
    }
}
