using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveNumber : MonoBehaviour
{

    [Header("======Variables=======")]
    public GameObject activeObject;


    public void Awake()
    {
        activeObject.SetActive(false);
    }


    public void ActivarNumero()
    {
        activeObject.SetActive(true);
    }
}
