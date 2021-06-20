using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject obj;
    public WeaponManager manager;
    public void Change()
    {
        manager.ChangeWeapon("Arrow", obj);
    }
}
