using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posterScaleup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scaleup()
    {
        this.transform.localScale = new Vector3(3.8f, 3.8f, 3.8f);
    }

    public void scaledown()
    {
        this.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
        
    }
}
