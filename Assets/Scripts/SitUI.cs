using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitUI : MonoBehaviour
{
    public Canvas _canvas;
    public GameObject _left;
    public GameObject _right;
    public GameObject _on;
    public GameObject _off;
    public Canvas _reviews;
    public Canvas _snacks;

    private bool on;
    // Start is called before the first frame update
    void Start()
    {
        _canvas.enabled = false;
        Off();
        on = false;
        _snacks.enabled = false;
    }

    public void switch_on()
    {
        if (on)
        {
            on = false;
            Off();
        }
        else
        {
            on = true;
            On();
        }
    }

    public void gonext()
    {
        _reviews.enabled = false;
        _snacks.enabled = true;
    }

    public void On()
    {
        _left.SetActive(true);
        _right.SetActive(true);
        _on.SetActive(true);
        _off.SetActive(false);
    }

    public void Off()
    {
        _left.SetActive(false);
        _right.SetActive(false);
        _on.SetActive(false);
        _off.SetActive(true);
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
