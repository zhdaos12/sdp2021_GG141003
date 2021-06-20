using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
class KeyName
{
    public string name;
    public string key;
    
    public KeyName(string _name,string _key)
    {
        name = _name;
        key = _key;
    }
}
public class Save : MonoBehaviour
{
    KeySetting settingData;
    List<KeyName> data = new List<KeyName>();
    public void save()
    {
        settingData = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        data.Add(new KeyName("up", settingData.TextList[0].text));
        data.Add(new KeyName("down", settingData.TextList[1].text));
        data.Add(new KeyName("left", settingData.TextList[2].text));
        data.Add(new KeyName("right", settingData.TextList[3].text));
        data.Add(new KeyName("heal", settingData.TextList[4].text));
        data.Add(new KeyName("flesh", settingData.TextList[5].text));
        data.Add(new KeyName("item1", settingData.TextList[6].text));
        data.Add(new KeyName("item2", settingData.TextList[7].text));
        data.Add(new KeyName("item3", settingData.TextList[8].text));
        data.Add(new KeyName("item4", settingData.TextList[9].text));
        data.Add(new KeyName("item5", settingData.TextList[10].text));
        data.Add(new KeyName("item6", settingData.TextList[11].text));
        string jdata = JsonConvert.SerializeObject(data);
        File.WriteAllText(Application.dataPath + "/key.cfg",jdata);
    }
    public void initialization()
    {
        settingData = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        settingData.TextList[0].text = "w";
        settingData.TextList[1].text = "s";
        settingData.TextList[2].text = "a";
        settingData.TextList[3].text = "d";
        settingData.TextList[4].text = "g";
        settingData.TextList[5].text = "h";
        settingData.TextList[6].text = "1";
        settingData.TextList[7].text = "2";
        settingData.TextList[8].text = "3";
        settingData.TextList[9].text = "4";
        settingData.TextList[10].text = "5";
        settingData.TextList[11].text = "6";
        data.Add(new KeyName("up", settingData.TextList[0].text));
        data.Add(new KeyName("down", settingData.TextList[1].text));
        data.Add(new KeyName("left", settingData.TextList[2].text));
        data.Add(new KeyName("right", settingData.TextList[3].text));
        data.Add(new KeyName("heal", settingData.TextList[4].text));
        data.Add(new KeyName("flesh", settingData.TextList[5].text));
        data.Add(new KeyName("item1", settingData.TextList[6].text));
        data.Add(new KeyName("item2", settingData.TextList[7].text));
        data.Add(new KeyName("item3", settingData.TextList[8].text));
        data.Add(new KeyName("item4", settingData.TextList[9].text));
        data.Add(new KeyName("item5", settingData.TextList[10].text));
        data.Add(new KeyName("item6", settingData.TextList[11].text));
        string jdata = JsonConvert.SerializeObject(data);
        File.WriteAllText(Application.dataPath + "/key.cfg", jdata);
    }
}
