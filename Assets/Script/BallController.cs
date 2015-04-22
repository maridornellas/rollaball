using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	// Use this for initialization


	public float moveSpeed;
	public float jumpSpeed;


	bool isGrounded = true;


	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
				float x = Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
				float z = Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;
				Vector3 force = new Vector3 (x, 0f, z);
				if (isGrounded && Input.GetButton ("Jump")) {
						force.y = jumpSpeed;
						isGrounded = false;
				}
				rigidbody.AddForce (force);
		}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.CompareTag("Ground"))
			{
				isGrounded = true;
			}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Coin"))
		other.gameObject.SetActive(false);
		ScoreTracker.Instance.AddScore (10);
	}
}
