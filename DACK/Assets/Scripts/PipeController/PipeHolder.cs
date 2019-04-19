using UnityEngine;
using System.Collections;

public class PipeHolder : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (BirdController.instance != null) {
			if (BirdController.instance.flag == 1) {
				Destroy (GetComponent<PipeHolder> ());
			}
		}
		_PipeMovement ();
	}

	void _PipeMovement(){
		Vector3 temp = transform.position;
		temp.x -= speed * Time.deltaTime;
		transform.position = temp;
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Destroy") {
			Destroy (gameObject);
		}
	}
}
