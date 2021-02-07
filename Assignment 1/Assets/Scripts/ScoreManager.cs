using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager: MonoBehaviour
{
    [SerializeField]
    private TextMesh text;
    public static ScoreManager instance;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore(int cherryValue)
    {
        score += cherryValue;
        text.text = "X" + score.ToString();
    }
}
