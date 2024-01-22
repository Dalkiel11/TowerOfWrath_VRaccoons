using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandController : MonoBehaviour
{
    [SerializeField] private InputActionReference gripInput;

    [SerializeField] private InputActionReference triggerInput;


    //private Variables
    private Animator _animator;
    private float grip;
    private float trigger;

    private void Awake()
    {
        //Obtenemos el Componente animator
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        grip = gripInput.action.ReadValue<float>();
        trigger = triggerInput.action.ReadValue<float>();

        _animator.SetFloat("Grip", grip);
        _animator.SetFloat("Trigger", trigger);
    }
}
