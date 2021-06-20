using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject start;
    void Awake()
    {
        if (null == instance)
        {
            instance = this;
        }
    }
    private void Start()
    {
        start.SetActive(true);
        Time.timeScale = 0;
    }
    public void GameStart()
    {
        start.SetActive(false);
        Time.timeScale = 1;
    }
    public void GameEnd()
    {
        Time.timeScale = 0;
    }
}
