using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    [SerializeField] private Button _Input_Btn;
    [SerializeField] private InputField _Input_Field;

    public Action<string> OnButtonClicked = null;

    private void Awake()
    {
        Instance = this;
        _Input_Btn.onClick.AddListener(ButtonClick);
    }



    private void ButtonClick()
    {
        if (!string.IsNullOrEmpty(_Input_Field.text))
        {
            OnButtonClicked?.Invoke(_Input_Field.text);
            _Input_Field.text = string.Empty;
        }
        else
            Debug.Log("String is emptyis null or empty.");
    }



}
