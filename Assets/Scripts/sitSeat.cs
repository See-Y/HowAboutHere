using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sitSeat : MonoBehaviour
{
    private Collider _collider = null;
    private Rigidbody _rigidbody = null;
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
        transform.rotation = Quaternion.identity;
    }

    public void getup()
    {
        transform.position += new Vector3(1.0f, 0.0f, 0.0f);
        
        _collider.enabled = true;
        _rigidbody.isKinematic = false;
        _rigidbody.detectCollisions = true;
    }
}
