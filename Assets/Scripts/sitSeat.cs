using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class sitSeat : MonoBehaviour
{
    public ActionBasedContinuousMoveProvider _left;
    public ActionBasedContinuousTurnProvider _right;
    private Collider _collider = null;
    private Rigidbody _rigidbody = null;

    public AudioSource voka;
    // Start is called before the first frame update
    void Start()
    {
        _collider = gameObject.GetComponent<Collider>();
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    public void sit(Vector3 position)
    {
        Debug.Log("sit");
        _collider.enabled = false;
        _rigidbody.isKinematic = true;
        _rigidbody.detectCollisions = false;
        transform.position = position;
        transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
        _left.enabled = false;
        _right.enabled = false;
        voka.Play();
    }

    public void getup()
    {
        transform.position += new Vector3(1.0f, 0.0f, 0.0f);
        
        _collider.enabled = true;
        _rigidbody.isKinematic = false;
        _rigidbody.detectCollisions = true;
        _left.enabled = true;
        _right.enabled = true;
    }
}
