using UnityEngine;
using System.Collections;

public class Box_position : MonoBehaviour {

	float box_float=-0.5f;
	float cameralength  = 0.3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 box_position = transform.localPosition;
		Vector3 box_scale = transform.localScale;
		box_scale.x = (cameralength) * (Camera.main.aspect);
		box_scale.y = (cameralength) * (Camera.main.aspect);
		box_position.x = (box_float)*(Camera.main.aspect);
		transform.localPosition = box_position;
		transform.localScale = box_scale;
	}
}
