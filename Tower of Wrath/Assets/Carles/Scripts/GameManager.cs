using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using TMPro;
using System.Security.Cryptography.X509Certificates;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;



    [Header("===VARIABLES===")]
    public GameObject winConditionTrigger;
    public GameObject puertaWinConditon1;
    public GameObject puertaWinCondition2;
    public GameObject puertaWinCondition3;
    public GameObject puertaWinCondition4;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OpenTheDoor()
    {
        puertaWinCondition2.SetActive(false);
        puertaWinConditon1.SetActive(false);
        puertaWinCondition3.SetActive(false);
        puertaWinCondition4.SetActive(false);
    }
}
