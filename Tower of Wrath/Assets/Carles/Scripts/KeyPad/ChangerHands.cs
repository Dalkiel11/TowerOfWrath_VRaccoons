using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerHands : MonoBehaviour
{
    [Header("======VARIABLES======")]
    public GameObject leftHandDefault;
    public GameObject rightHandDefault;

    public GameObject leftHandUI;
    public GameObject rightHandUI;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            leftHandDefault.SetActive(false);
            rightHandDefault.SetActive(false);

            leftHandUI.SetActive(true);
            rightHandUI.SetActive(true);
        }
    }


    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            leftHandDefault.SetActive(true);
            rightHandDefault.SetActive(true);

            leftHandUI.SetActive(false);
            rightHandUI.SetActive(false);
        }
    }
}
