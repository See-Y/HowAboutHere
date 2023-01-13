using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitUI : MonoBehaviour
{
    public Canvas _canvas;
    // Start is called before the first frame update
    void Start()
    {
        _canvas.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _canvas.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        _canvas.enabled = false;
    }
}
