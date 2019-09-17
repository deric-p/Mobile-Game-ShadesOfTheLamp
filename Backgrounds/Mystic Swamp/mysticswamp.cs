using UnityEngine;
using System.Collections;

public class mysticswamp : MonoBehaviour {
private Animator mystic;
	bool active = true;

	// Use this for initialization
	void Start () {
		mystic = GetComponent<Animator> ();
	}
	void Awake(){
		
		StartCoroutine ("WaitOneSecond");
		
		
	}
	
	IEnumerator WaitOneSecond(){
		
		while (active) {

			yield return new WaitForSeconds (1);
			mystic.SetInteger ("ms", Random.Range (0, 21));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
