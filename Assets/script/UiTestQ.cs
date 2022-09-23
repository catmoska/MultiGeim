using System;
using UnityEngine;

public class UiTestQ : MonoBehaviour
{
    public GameObject go;
    private void Start()
    {
        go.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))go.SetActive(!go.activeSelf);
        
    }
}