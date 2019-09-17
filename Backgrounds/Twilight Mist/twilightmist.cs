using UnityEngine;
using System.Collections;

public class twilightmist : MonoBehaviour {

private Animator twilight;
	bool active = true;

	// Use this for initialization
	void Start () {
		twilight = GetComponent<Animator> ();
	}
	void Awake(){
		
		StartCoroutine ("WaitOneSecond");
		
		
	}
	
	IEnumerator WaitOneSecond(){
		
		while (active) {

			yield return new WaitForSeconds (1);
			twilight.SetInteger ("tm_lte", Random.Range (0, 21));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
