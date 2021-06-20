using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public static WeaponManager instance = null;
    public string weapon;
    public GameObject weaponType;
    void Awake()
    {
        if (null == instance)
        {
            instance = this;
        }
    }
    public void ChangeWeapon(string type,GameObject obj)
    {
        weapon = type;
        weaponType = obj;
    }
}
