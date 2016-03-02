using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class SimpleController : MonoBehaviour {
    public float move = 1f;

    Rigidbody body;

	void Awake () {
        body = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        body.velocity = move * new Vector3(h, 0, v);
	}
}
