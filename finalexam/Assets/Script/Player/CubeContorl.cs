using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeContorl : Commad
{
    void Update()
    {
        if(Input.inputString != "")
        {
            setKey(Input.inputString);
        }
    }
}
