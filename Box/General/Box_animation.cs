using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;


public class Box_animation : MonoBehaviour {

	private Animator box;
	bool active = true;


	// Use this for initialization
	void Start () {
		box = GetComponent<Animator> ();
	
	}
	void Awake(){

			StartCoroutine ("WaitOneSecond");
	

	}

	IEnumerator WaitOneSecond(){

		while (active) {
			yield return new WaitForSeconds (1);
			box.SetInteger ("box", Random.Range (0, 5));
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
