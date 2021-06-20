using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;

public class KeySetting : MonoBehaviour
{
    public Button[] buttonList = new Button[12];
    public Text[] TextList = new Text[12];

    private int selectNnumber;
    void Start()
    {
        selectNnumber = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if(selectNnumber != -1)
        {
            if (Input.inputString != "")
            {
                for (int i = 0; i < 12; i++)
                {
                    if(TextList[i].text == Input.inputString)
                    {
                        TextList[i].text = "";
                    }
                }
                TextList[selectNnumber].text = Input.inputString;
            }
        }
    }
    public void SelectButton(int number)
    {
        if(selectNnumber != -1)
        {
            buttonList[selectNnumber].GetComponent<Image>().color = Color.white;
        }
        if(selectNnumber == number)
        {
            selectNnumber = -1;
        }
        else
        {
            selectNnumber = number;
            buttonList[selectNnumber].GetComponent<Image>().color = Color.green;
        }
    }
    public void Init()
    {
        selectNnumber = -1;

        for(int i = 0; i < 12; i++)
        {
            buttonList[i].GetComponent<Image>().color = Color.white; 
        }

        List<KeyName> data = new List<KeyName>();
        string jdata = File.ReadAllText(Application.dataPath + "/key.cfg");
        data = JsonConvert.DeserializeObject<List<KeyName>>(jdata);

        TextList[0].text = data[0].key;
        TextList[1].text = data[1].key;
        TextList[2].text = data[2].key;
        TextList[3].text = data[3].key;
        TextList[4].text = data[4].key;
        TextList[5].text = data[5].key;
        TextList[6].text = data[6].key;
        TextList[7].text = data[7].key;
        TextList[8].text = data[8].key;
        TextList[9].text = data[9].key;
        TextList[10].text = data[10].key;
        TextList[11].text = data[11].key;
    }
}
