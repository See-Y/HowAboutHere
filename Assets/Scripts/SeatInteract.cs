using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatInteract : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void move2seat()
    {
        player.transform.position = transform.position + new Vector3(1.0f,0.0f,0.0f);
        Debug.Log("position change");
    }
}
