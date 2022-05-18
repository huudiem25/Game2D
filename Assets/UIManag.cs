using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    static public UImanager instance;
    public GameObject bnGameOver;

    private void Awake()
    {
        UImanager.instance = this;
        this.bnGameOver = GameObject.Find("bnGameOver");
        this.bnGameOver.SetActive(false);
    }
}