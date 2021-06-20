using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public WeaponManager manager;
    public GameObject player;
    private GameObject obj;
    public void Attack()
    {
        obj = Instantiate(manager.weaponType, player.transform.position,manager.weaponType.transform.rotation);
        Destroy(obj, 2.0f);
    }
}
