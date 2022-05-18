using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static public UIManager instance;
    public GameObject Panel;

    private void Awake()
    {
        UIManager.instance = this;
        this.Panel = GameObject.Find("Panel");
        this.Panel.SetActive(false);
    }
}