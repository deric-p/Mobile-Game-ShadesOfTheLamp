using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class level14 : GeneralControls {

	
	private bool levelcheck;
    private GameObject[] boxArray;
    private bool active1;
    private bool active2;
    private bool active3;
    private GameObject active1box;
    private GameObject active2box;
    private GameObject active3box;
    private GameObject active1boxchild;
    private GameObject active2boxchild;
    private GameObject active3boxchild;
    private GameObject tempbox;
    GameObject victory;
    GameObject defeated1;
    GameObject mainmenu1;
    GameObject mainmenu2;
    GameObject levelz;
    GameObject loadbar;
    bool victory1;
    private int count;
    public GUIText loading;
    int loadprogress = 0;

    Animator lampanime;
	string[] lamp = {"red","red","blue","teal","teal","yellow","yellow"};
	GameObject lamp_color;
    private int randomcolor;
    private int currentLampColor;
    string currentcolor;
    private bool defeated;
    private int Timeremaining;
    public GUIText remaining;
    private GameObject trying;
    private GameObject [] boxes;
    private GameObject zerodefeated;
    private GameObject zeromainmenu;
    private int oneTime;
    GameObject [] BoxArray;
    GameObject temp1;
    GameObject temp2;
    GameObject temp3;
    string levelcomplete = "level14complete";
    string nextlevel = "level15";
    string currentlevel = "level14";
    string levelselector = "LevelSelectorHauntedIsle";

      void Awake(){

        levelz = GameObject.FindGameObjectWithTag("loading").gameObject;
        

    
        victory = GeneralControls.ReturnNumber(levelz,"victory");
        defeated1 = GeneralControls.ReturnNumber(levelz,"defeated");
        mainmenu1 = GeneralControls.ReturnNumber(victory,"mainmenu");
        mainmenu2 = GeneralControls.ReturnNumber(defeated1,"mainmenu");
        loadbar= GeneralControls.ReturnNumber(levelz,"loadbar");
        zerodefeated = GeneralControls.ReturnNumber(levelz,"zero");
        zeromainmenu = GeneralControls.ReturnNumber(zerodefeated,"mainmenu");
        

        //intailize lamp animation
         lamp_color = GameObject.FindGameObjectWithTag("lamp").gameObject;
         trying = GameObject.FindGameObjectWithTag("tries").gameObject;
          

         randomcolor = Random.Range(0,lamp.Length-1);
         currentcolor = lamp[randomcolor];

         lampanime = lamp_color.GetComponent<Animator>();
        
         currentLampColor = GeneralControls.LampColorNum(currentcolor);

         lampanime.SetInteger("lampcolor",currentLampColor);

    }

    // Use this for initialization
    void Start () {
        //intailize all varibles
        active1 = false;
        active2 = false;
        active3 = false;
        active1box = null;
        active2box = null;
        active3box = null;
        active1boxchild = null;
        active2boxchild = null;
        active3boxchild = null;
        boxArray = null;
        Sound.instance.hi();
        temp1 = null;
        temp2 = null;
        temp3 = null;

        tempbox = null;
        count = 0;
        oneTime = 0;
        
        levelcheck = false;
        defeated = false;
        victory1 = false;
        Timeremaining = 23;
        remaining.text = "Remaining Time: "+Timeremaining+"s";
        remaining.fontSize = (Screen.width)/35;
        StartCoroutine("Timeremains");
        


        
        

       
    }
  
    
    // Update is called once per frame
    void Update () {

        remaining.text = "Remaining Time: "+Timeremaining+"s";

        if(Input.touchCount > 0){

            if(Input.GetTouch(0).phase == TouchPhase.Began){
                //temp box
                 tempbox = GeneralControls.checkTouch(Input.GetTouch(0).position);
                 
            }
        }
        if(Input.GetMouseButtonDown(0)) {
            //same as above
             tempbox = GeneralControls.checkTouch(Input.mousePosition);          
        }
        if((!active1)&&
           (tempbox !=null)&&
           (!levelcheck)&&
           (!defeated)&&
           (tempbox !=temp1)&&
           (tempbox !=temp2)&&
           (tempbox !=temp3)){
            active1 = true;
            active1box = tempbox;
            tempbox = null;
            active1boxchild = GeneralControls.TurnOnBox(active1box,active1,false,false);
            count = 1;
                 
            //if star and completes stage
            if(GeneralControls.LampOne(active1boxchild,currentcolor)){
                active2 = true;
                active3 = true;
               count = 0;
               StartCoroutine("Lamp1");
                        
            }
           //checks if the box is with in the lamp colors
           if((!GeneralControls.CheckBox(currentcolor,active1box))&&(count !=0)&&
             (!GeneralControls.LampOne(active1boxchild,currentcolor))) {
               count = 0;
               
              
               StartCoroutine("ResetActive1");

                }
               
            }
                if ((active1)&&
                    (!active2)&&
                     (tempbox != active1box)&&
                     (tempbox !=null)&&
                    (!levelcheck)&&
                    (!defeated)&&
                    (tempbox !=temp1)&&
                    (tempbox !=temp2)&&
                    (tempbox !=temp3)){
                      active2 = true;
                      active2box = tempbox;
                      tempbox = null;
                      active2boxchild = GeneralControls.TurnOnBox(active2box,active1,active2,false);
                      count = 2;

                if ((!GeneralControls.CheckBox(currentcolor,active2box))||
                    (GeneralControls.DuplicateBox(active1boxchild,active2boxchild))||
                      active2box == null){
                      count = 0;
                      
                     
                      
                      StartCoroutine("ResetActive2");
                      
                            
                    }
                }
                if ((active1)&&
                    (active2)&&
                    (!active3)&&
                     (tempbox != active1box)&&
                     (tempbox != active2box)&&
                     (tempbox !=null)&&
                    (!levelcheck)&&
                    (!defeated)&&
                    ((GeneralControls.Lampinteger(currentcolor) == 3)||
                     (active2boxchild.layer == 20))&&
                    (tempbox !=temp1)&&
                    (tempbox !=temp2)&&
                    (tempbox !=temp3)) {
                      active3 = true;
                      active3box = tempbox;
                      tempbox = null;
                      active3boxchild = GeneralControls.TurnOnBox(active3box,active1,active2,active3);
                      count = 3;

                    if ((!GeneralControls.CheckBox(currentcolor,active3box))||
                        (GeneralControls.DuplicateBox(active1boxchild,active2boxchild))||
                        (GeneralControls.DuplicateBox(active3boxchild,active2boxchild))||
                        (GeneralControls.DuplicateBox(active3boxchild,active1boxchild))||
                          active3box == null){
                          count = 0;
                          
                          
                          
                          StartCoroutine("ResetActive3");
                                
                        }
                } 
       if((active1boxchild == null)&&
            (active2boxchild != null)){

            BoxArray = GameObject.FindGameObjectsWithTag("boxes");

            for(int i=0;i<BoxArray.Length;i++){
                if((BoxArray[i]!=null)&&
                   (BoxArray[i]!=temp1)&&
                   (BoxArray[i]!=temp2)&&
                   (BoxArray[i]!=temp3)){
                 GeneralControls.ResetBox(BoxArray[i]);
                }
            }
            active1box = null;
            active1boxchild = null;
            active1 = false;
            active2box = null;
            active2boxchild = null;
            active2 = false;
            count = 0;
            oneTime =0;
            }
            if(((active1boxchild == null)&&
            (active2boxchild != null)&&
            (active3boxchild !=null))||
            ((active1boxchild != null)&&
            (active2boxchild == null)&&
            (active3boxchild !=null))||
            ((active1boxchild == null)&&
            (active2boxchild == null)&&
            (active3boxchild !=null))) {
                BoxArray = GameObject.FindGameObjectsWithTag("boxes");

            for(int i=0;i<BoxArray.Length;i++){
                if((BoxArray[i]!=null)&&
                   (BoxArray[i]!=temp1)&&
                   (BoxArray[i]!=temp2)&&
                   (BoxArray[i]!=temp3)){
                 GeneralControls.ResetBox(BoxArray[i]);
                }
            }
            active1box = null;
            active1boxchild = null;
            active1 = false;
            active2box = null;
            active2boxchild = null;
            active2 = false;
            active3box = null;
            active3boxchild = null;
            active3 = false;
            count = 0;
            oneTime =0;
        }
        if(count != 0){
            //checks to see if lamp is complete
            if(GeneralControls.Finalchecklamp(currentcolor,count,active2boxchild))    {

                if((count==2)&&
                    (GeneralControls.LampTwo(active1boxchild,active2boxchild,currentcolor))){
                    count = 0;
                    StartCoroutine("Lamp2");
                }
                
                if((count==3)&&
                    (GeneralControls.LampThree(active1boxchild,active2boxchild,active3boxchild,currentcolor))){
                    count = 0;
                    StartCoroutine("Lamp3");
                }
            }
        }
        if((lamp.Length == 0)&&(levelcheck != true)){
            victory1 = true;
            levelcheck = true;
            if(levelcheck){
                StartCoroutine("LampDies");
            }
            
        }
        if((tempbox == victory)&&
            (victory1)){
           Sound.instance.buttonclick();
           StartCoroutine(loadinglevel(nextlevel));
            tempbox = null;
        }
         
        if((tempbox == defeated1)&&
            (defeated)){
            Sound.instance.buttonclick();
           StartCoroutine(loadinglevel(currentlevel));
           tempbox = null;

        }
        if((tempbox == mainmenu1)||(tempbox == mainmenu2)||
            (tempbox == zeromainmenu)){
            tempbox = null;
            Sound.instance.buttonclick();
            StartCoroutine(loadinglevel(levelselector));

        }
         if(tempbox == zerodefeated){
            tempbox = null;
            Sound.instance.buttonclick();
           StartCoroutine(loadinglevel(currentlevel));

        }
        if((Timeremaining == 0)&&
            (!defeated)&&
            (!victory1)){
            defeated = true;
            oneTime =1 ;
            boxes = GameObject.FindGameObjectsWithTag("boxes");
            StartCoroutine("zeroremains");

        }
      
        if((!defeated)&&
           (!victory1)&&
           (oneTime == 0)&&
           (temp1 == null)&&
           (temp2 == null)&&
           (temp3 == null)){
            oneTime = 1;
            boxArray = GameObject.FindGameObjectsWithTag("boxes");
            if((!GeneralControls.CheckCombination(boxArray,currentcolor))) {
                defeated = true;
                StartCoroutine("defeat");
            }
        }

        
    }

    IEnumerator ResetActive1(){

        yield return new WaitForSeconds(.2f);
        if(active1box !=null){
            GeneralControls.ResetBox(active1box);
        }
        active1box = null;
        active1boxchild = null;
        active1 = false;
        
    }

    IEnumerator ResetActive2(){

        yield return new WaitForSeconds(.2f);
        if(active1box !=null){
            GeneralControls.ResetBox(active1box);
        }
        
        active1box = null;
        active1boxchild = null;
        active1 = false;
        if(active2box !=null){
            GeneralControls.ResetBox(active2box);
        }
        active2box = null;
        active2boxchild = null;
        active2 = false;
        
    }
     IEnumerator ResetActive3(){

        yield return new WaitForSeconds(0.2f);
        if(active1box !=null){
            GeneralControls.ResetBox(active1box);
        }
        active1box = null;
        active1boxchild = null;
        active1 = false;
        if(active2box !=null){
            GeneralControls.ResetBox(active2box);
        }
        active2box = null;
        active2boxchild = null;
        active2 = false;
        if(active3box !=null){
            GeneralControls.ResetBox(active3box);
        }
        active3box = null;
        active3boxchild = null;
        active3 = false;
        
    }

    IEnumerator Lamp1(){

        yield return new WaitForSeconds(.2f);
        GeneralControls.BoxExplode(active1box);
        StartCoroutine("Lamp1Destroy");

        
    }
    IEnumerator Lamp1Destroy(){

        StartCoroutine("resetbox1");
        yield return new WaitForSeconds(0.5f);
        
        lamp = GeneralControls.RemoveLamp(lamp,randomcolor);
        temp1 = active1box;
        active1box = null;
        active1boxchild = null;
        active1 = false;
        active2 = false;
        active3 = false;
        oneTime = 0;
        if(lamp.Length != 0){

            randomcolor = Random.Range(0,lamp.Length-1);
            currentcolor = lamp[randomcolor];
            currentLampColor = GeneralControls.LampColorNum(currentcolor);
            

            lampanime.SetInteger("lampcolor",currentLampColor);
            

        }
    }
    IEnumerator resetbox1(){

        yield return new WaitForSeconds(1);
        if(temp1!=null){
            GeneralControls.DestroyBox(temp1);
        }
        
        temp1= null;
        

    }
    IEnumerator Lamp2(){

        yield return new WaitForSeconds(.2f);
        GeneralControls.BoxExplode(active1box);
        GeneralControls.BoxExplode(active2box);
        StartCoroutine("Lamp2Destroy");
        
        
        
    }
    IEnumerator Lamp2Destroy(){

        StartCoroutine("resetbox2");
        yield return new WaitForSeconds(0.5f);
        
        lamp = GeneralControls.RemoveLamp(lamp,randomcolor);
        temp1 = active1box;
        temp2 = active2box;
        active1box = null;
        active1boxchild = null;
        active1 = false;
        active2box = null;
        active2boxchild = null;
        active2 = false;
        oneTime = 0;
        if(lamp.Length != 0){

            randomcolor = Random.Range(0,lamp.Length-1);
            currentcolor = lamp[randomcolor];
            currentLampColor = GeneralControls.LampColorNum(currentcolor);

            
            lampanime.SetInteger("lampcolor",currentLampColor);

        }
    }
    IEnumerator resetbox2(){
        yield return new WaitForSeconds(1);
        if((temp1!=null)&&(temp2!=null)){
            GeneralControls.DestroyBox(temp1);
            GeneralControls.DestroyBox(temp2);
        }
        
        temp1 = null;
        temp2 = null;
        
    }
        IEnumerator Lamp3(){

        yield return new WaitForSeconds(.2f);
        GeneralControls.BoxExplode(active1box);
        GeneralControls.BoxExplode(active2box);
        GeneralControls.BoxExplode(active3box);
        StartCoroutine("Lamp3Destroy");
        
        
        
    }
    IEnumerator Lamp3Destroy(){

        StartCoroutine("resetbox3");
        yield return new WaitForSeconds(0.5f);
        
        lamp = GeneralControls.RemoveLamp(lamp,randomcolor);
        temp1 = active1box;
        temp2 = active2box;
        temp3 = active3box;
        active1box = null;
        active1boxchild = null;
        active1 = false;
        active2box = null;
        active2boxchild = null;
        active2 = false;
        active3box = null;
        active3boxchild = null;
        active3 = false;
        oneTime = 0;
        if(lamp.Length != 0){

            randomcolor = Random.Range(0,lamp.Length-1);
            currentcolor = lamp[randomcolor];
            currentLampColor = GeneralControls.LampColorNum(currentcolor);

            
            lampanime.SetInteger("lampcolor",currentLampColor);

        }
    }
    IEnumerator resetbox3(){
        yield return new WaitForSeconds(1);
        if((temp1!=null)&&(temp2!=null)&&(temp3!=null)){
            GeneralControls.DestroyBox(temp1);
            GeneralControls.DestroyBox(temp2);
            GeneralControls.DestroyBox(temp3);

        }
        
        temp1 = null;
        temp2 = null;
        temp3 = null;
        
    }
    IEnumerator LampDies(){

        yield return new WaitForSeconds(.2f);

        try{

            lampanime.SetBool("dead", true);
        }

        catch(System.NullReferenceException ne){


            Debug.Log(ne);
            
        }
         boxArray = GameObject.FindGameObjectsWithTag("boxes");
        for(int i = 0; i<boxArray.Length;i++){
            GeneralControls.DestroyBox(boxArray[i]);
        }
        
        
        if(PlayerPrefs.GetInt(levelcomplete)!=1){

            PlayerPrefs.SetInt(levelcomplete, 1);
        }
       
       StartCoroutine("DestroyLamp");
        

    } 
    IEnumerator DestroyLamp(){
        yield return new WaitForSeconds(1);

        GeneralControls.DestroyBox(lamp_color);
        victory.SetActive(true);
        Sound.instance.victorious();
        trying.SetActive(false); 
        defeated1.SetActive(false);
        zerodefeated.SetActive(false);    
    }
     IEnumerator loadinglevel(string level){

        loadbar.SetActive(true);

        if(loadprogress == 0){
            loading = loadbar.GetComponentInChildren<GUIText>();
        }
       
        
        victory.SetActive(false);
        defeated1.SetActive(false);
        trying.SetActive(false);
        zerodefeated.SetActive(false);


        
        loading.fontSize = (Screen.width)/19;
        loading.text = "Loading "+ loadprogress +"%";
        AsyncOperation async = SceneManager.LoadSceneAsync(level);

        while(!async.isDone){
            loadprogress = (int)(async.progress * 100);
            loading.text = "Loading "+ loadprogress +"%";
           yield return null;
        }
        


      }   
      IEnumerator defeat(){

        yield return new WaitForSeconds(0.5f);

        for(int i = 0; i<boxArray.Length;i++){
            if((boxArray[i] !=null)&&
               (boxArray[i] !=temp1)&&
               (boxArray[i] !=temp2)&&
               (boxArray[i] !=temp3)){
               GeneralControls.DestroyBox(boxArray[i]);
            }
            
        }
        

        defeated1.SetActive(true);
        Sound.instance.defeated();



      }
      IEnumerator zeroremains (){
        yield return new WaitForSeconds(0.2f);
        for(int i=0;i<boxes.Length;i++){
            if((boxes[i] !=null)&&
               (boxes[i] !=temp1)&&
               (boxes[i] !=temp2)&&
               (boxes[i] !=temp3)){
               GeneralControls.DestroyBox(boxes[i]);
            }
        }
        zerodefeated.SetActive(true);
        trying.SetActive(false);
        Sound.instance.defeated();
        lamp_color.SetActive(false);

      } 
      IEnumerator Timeremains(){

        while((!victory1)||
             (!defeated)){
           if((!victory1)||
            (!defeated)){
                
                Timeremaining--;
            }
            if((victory1)||
                (defeated)){
                break;
            }
            
            yield return new WaitForSeconds(1);
        }
      }
        
    
}