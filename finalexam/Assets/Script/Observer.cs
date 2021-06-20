using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Observer : MonoBehaviour
{
    [Header("[Time]")]
    public Text timeText;
    public float time;

    [Header("[score]")]
    public Text scoreText;
    public int score;
    void Start()
    {
        scoreText.text = "���� : " + score.ToString();
    }
    void Update()
    {
        GameStop();
    }
    void GameStop()
    {
        time -= Time.deltaTime;
        if (time > 1)
        {
            timeText.text = ((int)time).ToString();
        }
        else
        {
            timeText.text = "�ð��ʰ�";
            GameManager.instance.GameEnd();
        }
    }
    public void GameScore()
    {
        score += 10;
        scoreText.text = "���� : " + score.ToString();
    }
}
