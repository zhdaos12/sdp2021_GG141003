using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : EnemyCreate
{
    public override void CreateEnemy(GameObject obj)
    {
        obj.SetActive(true);
    }
}
