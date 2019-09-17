using UnityEngine;
using System.Collections;

public class lamp_position_DarkAbyss : MonoBehaviour {

float lamp_positionx = -6f;
	float cameralength  = 0.276f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 lamp_position = transform.localPosition;
		lamp_position.x = (Camera.main.aspect)*(lamp_positionx);
		transform.localPosition = lamp_position;
		Vector3 lampscale = transform.localScale;
		lampscale.x = (cameralength)*(Camera.main.aspect);
		lampscale.y = (cameralength)*(Camera.main.aspect);
		transform.localScale = lampscale;
	}
}

