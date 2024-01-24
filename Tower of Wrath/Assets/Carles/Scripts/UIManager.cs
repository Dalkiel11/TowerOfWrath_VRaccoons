using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [Header("===VARIABLES===")]
    public GameObject puerta1;
    public GameObject puerta2;
    public GameObject puerta3;
    public GameObject puerta4;

    public GameObject rayCastR;
    public GameObject rayCastL;

    public GameObject directionalR;
    public GameObject directionalL;


    public GameObject initialCanva;



    public void PlayBton()
    {
        puerta1.SetActive(false);
        puerta2.SetActive(false);
        puerta3.SetActive(false);
        puerta4.SetActive(false);

        rayCastL.SetActive(false);
        rayCastR.SetActive(false);

        directionalR.SetActive(true);
        directionalL.SetActive(true);

        initialCanva.SetActive(false);
    }


}
