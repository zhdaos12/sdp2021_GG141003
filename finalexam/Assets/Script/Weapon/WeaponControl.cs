using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Translate(new Vector3(0, 0, Time.deltaTime * 30f));
    }

}
