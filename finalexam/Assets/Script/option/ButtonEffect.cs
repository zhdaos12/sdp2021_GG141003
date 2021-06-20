using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEffect : MonoBehaviour
{
    public GameObject settingView;

    KeySetting setting;
    public void open()
    {
        settingView.SetActive(true);
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.Init();
    }
    public void close()
    {
        settingView.SetActive(false);
    }
    public void up()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(0);
    }
    public void dwon()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(1);
    }
    public void left()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(2);
    }
    public void right()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(3);
    }
    public void heal()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(4);
    }
    public void flesh()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(5);
    }
    public void item1()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(6);
    }
    public void item2()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(7);
    }
    public void item3()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(8);
    }
    public void item4()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(9);
    }
    public void item5()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(10);
    }
    public void item6()
    {
        setting = GameObject.Find("KeySetting").GetComponent<KeySetting>();
        setting.SelectButton(11);
    }
}
