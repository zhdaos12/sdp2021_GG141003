using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> enemy = new List<GameObject>();
    EnemyFactory create = new EnemyFactory();
    float time;
    int random;
    private void Start()
    {
        time = 2.0f;
        random = 0;
    }
    private void Update()
    {
        time -= Time.deltaTime;
        if(time < 0)
        {
            random = Random.Range(0, 5);
            if(enemy[random].activeSelf == false)
            {
                create.CreateEnemy(enemy[random]);
            }
            time = 2.0f;
        }
    }
}
