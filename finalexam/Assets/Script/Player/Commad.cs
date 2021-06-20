using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
public class Commad : MonoBehaviour
{
    public void setKey(string key)
    {
        List<KeyName> data = new List<KeyName>();
        string jdata = File.ReadAllText(Application.dataPath + "/key.cfg");
        data = JsonConvert.DeserializeObject<List<KeyName>>(jdata);

        if(data[0].key == key)
        {
            Up();
        }
        else if(data[1].key == key)
        {
            Down();
        }
        else if (data[2].key == key)
        {
            Left();
        }
        else if (data[3].key == key)
        {
            Right();
        }
        else if (data[4].key == key)
        {
            heal();
        }
        else if (data[5].key == key)
        {
            flesh();
        }
        else if (data[6].key == key)
        {
            Item1();
        }
        else if (data[7].key == key)
        {
            Item2();
        }
        else if (data[8].key == key)
        {
            Item3();
        }
        else if (data[9].key == key)
        {
            Item4();
        }
        else if (data[10].key == key)
        {
            Item5();
        }
        else if (data[11].key == key)
        {
            Item6();
        }
    }
    public void Up()
    {
        GameObject player = GameObject.Find("Player");
        player.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);
    }
    public void Down()
    {
        GameObject player = GameObject.Find("Player");
        player.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.1f);
    }
    public void Left()
    {
        GameObject player = GameObject.Find("Player");
        player.transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
    }
    public void Right()
    {
        GameObject player = GameObject.Find("Player");
        player.transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
    }
    public void heal()
    {
        Debug.Log("회복 사용");
    }
    public void flesh()
    {
        Debug.Log("점멸 사용");
    }
    public void Item1()
    {
        Debug.Log("1번 아이템 사용");
    }
    public void Item2()
    {
        Debug.Log("2번 아이템 사용");
    }
    public void Item3()
    {
        Debug.Log("3번 아이템 사용");
    }
    public void Item4()
    {
        Debug.Log("4번 아이템 사용");
    }
    public void Item5()
    {
        Debug.Log("5번 아이템 사용");
    }
    public void Item6()
    {
        Debug.Log("6번 아이템 사용");
    }
}
