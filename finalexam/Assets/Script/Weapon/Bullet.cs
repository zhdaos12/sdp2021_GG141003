using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject obj;
    public WeaponManager manager;
    public void Change()
    {
        manager.ChangeWeapon("Bullet", obj);
    }
}
