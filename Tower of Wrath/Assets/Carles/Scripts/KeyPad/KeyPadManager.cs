using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class KeyPadManager : MonoBehaviour
{

    [Header("======VARIABLES======")]
    public List<int> correctPassword = new List<int>();
    private List<int> inputPasswordList = new List<int>();
    [SerializeField] private TMP_InputField codeDisplay;
    [SerializeField] private string successText;
    [SerializeField] private float resetTime = 2f;

    [Space(5f)]
    [Header("======Keypad Entry Events======")]
    public UnityEvent onCorrectPassword;
    public UnityEvent onIncorrectPassword;

    public bool allowMultipleActivations = false;
    private bool hasUsedCorrectCode = false;

    public bool HasUsedCorrectCode { get { return hasUsedCorrectCode; } }



    public void UserNumberEntry(int selectedNum)
    {

        if (inputPasswordList.Count >= 3)
        {
            return;
        }

        inputPasswordList.Add(selectedNum);

        UpdateDisplay();

        if (inputPasswordList.Count >= 3)
        {
            CheckPassword();
        }

    }


    private void CheckPassword()
    {
        for (int i = 0; i < correctPassword.Count; i++)
        {
            if (inputPasswordList[i] != correctPassword[i])
            {
                IncorrectPassword();
                return;
            }
        }

        CorrectPassword();

    }


    private void CorrectPassword()
    {
        if (allowMultipleActivations)
        {
            onCorrectPassword.Invoke();
            codeDisplay.text = successText;
            StartCoroutine(ResetKeycode());
        }
        else if (!allowMultipleActivations && !hasUsedCorrectCode)
        {
            onCorrectPassword.Invoke();
            hasUsedCorrectCode = true;
            codeDisplay.text = successText;
        }
    }


    private void IncorrectPassword()
    {
        onIncorrectPassword.Invoke();
        StartCoroutine(ResetKeycode());
    }



    private void UpdateDisplay()
    {

        codeDisplay.text = null;
        for (int i = 0; i < inputPasswordList.Count; i++)
        {
            codeDisplay.text += inputPasswordList[i];
        }

    }


    public void DeleteEntry()
    {
        if (inputPasswordList.Count <= 0)
        {
            return;
        }

        var listposition = inputPasswordList.Count - 1;
        inputPasswordList.RemoveAt(listposition);

        UpdateDisplay();
    }



     IEnumerator ResetKeycode()
   {
        yield return new WaitForSeconds(resetTime);

        inputPasswordList.Clear();

      codeDisplay.text = "EnterCode...";
   }



}
