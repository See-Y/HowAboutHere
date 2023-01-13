using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SeatInteract : MonoBehaviour
{
    public GameObject player;
    public GameObject _on;

    private sitSeat _seat;
    
    // Start is called before the first frame update
    void Start()
    {
        _seat = player.GetComponent<sitSeat>();
        _on.SetActive(false);
    }

    public void move2seat()
    {
        player.transform.position = transform.position + new Vector3(0.0f,0.2f,0.2f);
        
    }

    public void sit2seat()
    {
        Debug.Log("Activated");
        _seat.sit(transform.position + new Vector3(0.0f, -0.1f, 0.0f));
        _on.SetActive(true);
        //Disable other moving controlls
    }
}
