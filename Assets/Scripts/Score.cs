using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textScoreCounter;
    int actualScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textScoreCounter.text = actualScore.ToString();
    }
    public void ShowScore(int points)
    {
        actualScore += points;
    }
}
