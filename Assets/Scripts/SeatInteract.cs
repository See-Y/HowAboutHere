using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatInteract : MonoBehaviour
{
    public GameObject player;

    private sitSeat _seat;
    // Start is called before the first frame update
    void Start()
    {
        _seat = player.GetComponent<sitSeat>();
    }

    public void move2seat()
    {
        player.transform.position = transform.position + new Vector3(-1.0f,0.0f,0.0f);
        
    }

    public void sit2seat()
    {
        Debug.Log("Activated");
        _seat.sit(player.transform.position);
    }
}
