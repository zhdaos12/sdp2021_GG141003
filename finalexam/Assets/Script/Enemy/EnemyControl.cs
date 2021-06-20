using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    Observer observer;
    void Start()
    {
        observer = GameObject.Find("Observer").GetComponent<Observer>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Weapon")
        {
            observer.GameScore();
            gameObject.SetActive(false);
        }
    }
}
