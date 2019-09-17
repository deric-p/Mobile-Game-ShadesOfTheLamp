using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HauntedIsle : GeneralControls {

	private GameObject one;
	private GameObject two;
	private GameObject four;
	private GameObject three;
	private GameObject five;
	private GameObject six;
	private GameObject arrow;
	private GameObject levelz;
	private Animator ones;
	private Animator twos;
	private Animator threes;
	private Animator fours;
	private Animator fives;
	private Animator sixes;
	private GameObject temp;
	public GUIText loading;
	private GameObject loader;
	private GameObject [] loaderArray;
	private GameObject arrow_right;

	int loadprogress = 0;
	

	// Use this for initialization
	void Start () {
		Sound.instance.hi();
		StartCoroutine("delaystart");
	}

	void Awake(){

		loaderArray = GameObject.FindGameObjectsWithTag("loading");

		levelz = GameObject.FindGameObjectWithTag("levels").gameObject;
		

		one = GeneralControls.ReturnNumber(levelz,"one");
		two = GeneralControls.ReturnNumber(levelz,"two");
		three = GeneralControls.ReturnNumber(levelz,"three");
		four = GeneralControls.ReturnNumber(levelz,"four");
		five = GeneralControls.ReturnNumber(levelz,"five");
		six = GeneralControls.ReturnNumber(levelz,"six");
		arrow = transform.FindChild("arrow").gameObject;
		arrow_right = transform.FindChild("arrow_right").gameObject;
		loader = transform.FindChild("loadbar").gameObject;


		ones = one.GetComponent<Animator>();
		twos = two.GetComponent<Animator>();
		threes = three.GetComponent<Animator>();
		fours = four.GetComponent<Animator>();
		fives = five.GetComponent<Animator>();
		sixes = six.GetComponent<Animator>();


		
	}
	
	
	
	// Update is called once per frame
	void Update () {

		if(Input.touchCount > 0){

			if(Input.GetTouch(0).phase == TouchPhase.Began){

				temp = GeneralControls.checkTouch(Input.GetTouch(0).position);

			}
		}

		if(Input.GetMouseButtonDown(0)){

			temp = GeneralControls.checkTouch(Input.mousePosition);

		}
		if(temp == one){
			temp = null;
			Sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level13story"));

		}
		if(temp == two){
			temp = null;
			Sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level14"));

		}
		if(temp == three){
			temp = null;
			Sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level15"));

		}
		if(temp == four){
			temp = null;
			Sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level16"));

		}
		if(temp == five){
			temp = null;
			Sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level17"));

		}
		if(temp == six){
			temp = null;
			Sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level18"));

		}
		if(temp == arrow_right){
			temp = null;
			Sound.instance.buttonclick();
			StartCoroutine(loadinglevel("LevelSelectorDesolateOasis"));
		}
		if(temp == arrow){
			temp = null;
			Sound.instance.buttonclick();
			StartCoroutine(loadinglevel("LevelSelectorMysticSwamp"));
		}



	}
	  IEnumerator loadinglevel(string level){

	  	loader.SetActive(true);
	  	levelz.SetActive(false);
	  	arrow.SetActive(false);
	  	arrow_right.SetActive(false);
	  

	  	for(int i=0;i<loaderArray.Length;i++){
	  		loaderArray[i].SetActive(false);
	  	}
	  	loading.fontSize = (Screen.width)/19;
	  	loading.text = "Loading "+ loadprogress +"%";
	  	AsyncOperation async = SceneManager.LoadSceneAsync(level);

	  	while(!async.isDone){
	  		loadprogress = (int)(async.progress * 100);
	  		loading.text = "Loading "+ loadprogress +"%";
	  		yield return null;
	  	}


	  }
	  IEnumerator delaystart(){
	  	if(PlayerPrefs.GetInt("level13complete") != 1){
			one.SetActive(true);
			ones.SetBool("complete",false);
		}
		if(PlayerPrefs.GetInt("level13complete") == 1){
			one.SetActive(true);
			ones.SetBool("complete",true);
			two.SetActive(true);
			
			
		}
		if(PlayerPrefs.GetInt("level14complete") == 1){
			twos.SetBool("complete",true);
			three.SetActive(true);
			
			
		}
		if(PlayerPrefs.GetInt("level15complete") == 1){
			threes.SetBool("complete",true);
			four.SetActive(true);
			
			
		}
		if(PlayerPrefs.GetInt("level16complete") == 1){
			fours.SetBool("complete",true);
			five.SetActive(true);
			
			
		}
		if(PlayerPrefs.GetInt("level17complete") == 1){
			fives.SetBool("complete",true);
			six.SetActive(true);
			
			
		}
		if(PlayerPrefs.GetInt("level18complete") == 1){
			sixes.SetBool("complete",true);
			arrow.SetActive(true);
			
		}
		yield return new WaitForSeconds(0.2f);
	  }

}