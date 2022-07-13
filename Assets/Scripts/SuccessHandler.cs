using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessHandler : MonoBehaviour
{
    [SerializeField] Canvas successCanvas;

    private void Start()
    {
       successCanvas.enabled = false;   
    }

    public void HandleSuccess()
    {
        successCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
}
