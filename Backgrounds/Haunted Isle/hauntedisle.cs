using UnityEngine;
using System.Collections;

public class hauntedisle : MonoBehaviour {

private Animator haunted;
	bool active = true;

	// Use this for initialization
	void Start () {
		haunted = GetComponent<Animator> ();
	}
	void Awake(){
		
		StartCoroutine ("WaitOneSecond");
		
		
	}
	IEnumerator WaitOneSecond(){
		
		while (active) {

			yield return new WaitForSeconds (1);
			haunted.SetInteger ("hi", Random.Range (0, 10));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
