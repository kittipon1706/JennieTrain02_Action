using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayManager : MonoBehaviour
{
    [SerializeField] private Text _ShowText;
    private void Start()
    {
        InputManager.Instance.OnButtonClicked += ShowText;
    }

    private void ShowText(string text)
    {
        _ShowText.text = text;
    }
}
