using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public GameObject obj;
    public WeaponManager manager;
    public void Change()
    {
        manager.ChangeWeapon("Missile", obj);
    }
}
