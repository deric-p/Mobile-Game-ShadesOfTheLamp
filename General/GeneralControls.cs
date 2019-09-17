using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class GeneralControls : MonoBehaviour {

	
	

	// if a star is pressed and solves puzzel
	//take in one child that is act
	public static bool LampOne(GameObject Box, string color){
		


		if (Box == null) {

			return false;

		}
		//check for purple
		else if ((color == "purple") && 
		         ((Box.tag == "act1") || (Box.tag == "act123")) && 
		         (Box.layer == 13)) {

			return true;

		//check for yellow
		} 
		else if ((color == "yellow") && 
		         ((Box.tag == "act1") || (Box.tag == "act123")) && 
		         (Box.layer == 15)) {

			return true;

		//check for teal
		} 
		else if ((color == "teal") && 
		         ((Box.tag == "act1") || (Box.tag == "act123")) && 
		         (Box.layer == 14)) {

			return true;

		} 
		else if ((color == "white") && 
		         ((Box.tag == "act1") || (Box.tag == "act123")) && 
		         (Box.layer == 18)) {

			return true;

		}
		else if ((color == "red") && 
		         ((Box.tag == "act1") || (Box.tag == "act123")) && 
		         (Box.layer == 10)) {

			return true;

		}
		else if ((color == "blue") && 
		         ((Box.tag == "act1") || (Box.tag == "act123")) && 
		         (Box.layer == 11)) {

			return true;

		}
		else if ((color == "green") && 
		         ((Box.tag == "act1") || (Box.tag == "act123")) && 
		         (Box.layer == 12)) {

			return true;

		}
		//if not the case return false
		else {

			return false;

		}	
	}
	// if two boxes are used or a star and a box are used to solve the puzzel
	//take in two children of the box
	public static bool LampTwo(GameObject Box1, GameObject Box2,string color){

		
	

		//purple
		if ((color == "purple") && 
		    ((Box1.layer == 10) || (Box1.layer == 11)) && 
		    ((Box2.layer == 10) || (Box2.layer == 11))) {

			return true;

		//teal
		} if ((color == "teal") && 
		           ((Box1.layer == 12) || (Box1.layer == 11)) && 
		           ((Box2.layer == 12) || (Box2.layer == 11))) {

			return true;

		//yellow
		} if ((color == "yellow") && 
		           ((Box1.layer == 10) || (Box1.layer == 12)) && 
		           ((Box2.layer == 10) || (Box2.layer == 12))) {

			return true;

		//orange
		} if ((color == "orange") && 
		           ((Box1.layer == 10) || (Box1.layer == 15)) && 
		           ((Box2.layer == 10) || (Box2.layer == 15))) {

			return true;

		//grey
		} if ((color == "grey") && 
		           ((Box1.layer == 18) || (Box1.layer == 16)) && 
		           ((Box2.layer == 18) || (Box2.layer == 16))) {

			return true;

		//brown
		} if ((color == "brown") && 
		           ((Box1.layer == 17) || (Box1.layer == 11)) && 
		           ((Box2.layer == 17) || (Box2.layer == 11))) {

			return true;

		//pink
		}if ((color == "pink") && 
		           ((Box1.layer == 10) || (Box1.layer == 18)) && 
		           ((Box2.layer == 10) || (Box2.layer == 18))) {

			return true;

		} if ((color == "red") && 
		           ((Box1.layer == 15) || (Box1.layer == 13)) && 
		           ((Box2.layer == 15) || (Box2.layer == 13))) {

			return true;

		}  if ((color == "blue") && 
		           ((Box1.layer == 13) || (Box1.layer == 14)) && 
		           ((Box2.layer == 13) || (Box2.layer == 14))) {

			return true;

		} if ((color == "green") && 
		           ((Box1.layer == 14) || (Box1.layer == 15)) && 
		           ((Box2.layer == 14) || (Box2.layer == 15))) {

			return true;

		} 

			return false;

		

	}
	//takes in 3 game objects and checkif true
	public static bool LampThree(GameObject Box1,GameObject Box2, GameObject Box3,string color){

		
		
		//black
		if ((color == "black") &&
			((Box1.layer == 15) || (Box1.layer == 14) || (Box1.layer == 13)) &&
			((Box2.layer == 15) || (Box2.layer == 14) || (Box2.layer == 13)) &&
			((Box3.layer == 15) || (Box3.layer == 14) || (Box3.layer == 13))) {
			
			return true;
		}
		//white
		else if ((color == "white") &&
		        ((Box1.layer == 10) || (Box1.layer == 11) || (Box1.layer == 12)) &&
		        ((Box2.layer == 10) || (Box2.layer == 11) || (Box2.layer == 12)) &&
		        ((Box3.layer == 10) || (Box3.layer == 11) || (Box3.layer == 12))){

			return true;

		//return false 
		}else if ((color == "orange") && 
		           ((Box1.layer == 10) || (Box1.layer == 15)||(Box1.layer == 20)) && 
		           ((Box2.layer == 10) || (Box2.layer == 15)||(Box2.layer == 20))&&
		           ((Box3.layer == 10) || (Box3.layer == 15)||(Box3.layer == 20))) {

			return true;

		//grey
		} else if ((color == "grey") && 
		           ((Box1.layer == 18) || (Box1.layer == 16)||(Box1.layer == 20)) && 
		           ((Box2.layer == 18) || (Box2.layer == 16)||(Box2.layer == 20))&&
		           ((Box3.layer == 18) || (Box3.layer == 16)||(Box3.layer == 20))) {

			return true;

		//brown
		} else if ((color == "brown") && 
		           ((Box1.layer == 17) || (Box1.layer == 11)||(Box1.layer == 20)) && 
		           ((Box2.layer == 17) || (Box2.layer == 11)||(Box2.layer == 20))&&
		           ((Box3.layer == 17) || (Box3.layer == 11)||(Box3.layer == 20))) {

			return true;

		//pink
		} else if ((color == "pink") && 
		           ((Box1.layer == 18) || (Box1.layer == 10)||(Box1.layer == 20)) && 
		           ((Box2.layer == 18) || (Box2.layer == 10)||(Box2.layer == 20))&&
		           ((Box3.layer == 18) || (Box3.layer == 10)||(Box3.layer == 20)))  {

			return true;

		}else{

			return false;

		}
	}
		//reset boxes
	public static void ResetBox(GameObject Box){
		//temp object for Coroutine
		Sound.instance.resetbox();
		//array of the children
		Transform [] Boxchildren = Box.GetComponentsInChildren<Transform> (true);
		//Searches Through All Child boxes and turn original on and everything else off
		for (int i =0; i < Boxchildren.Length; i++) {

			if(Boxchildren[i].gameObject.tag == "box"){

				Transform [] BoxchildrenBox = Boxchildren[i].GetComponentsInChildren<Transform> (true);

				for(int j =0;j <BoxchildrenBox.Length;j++){

					if(BoxchildrenBox[j].gameObject.tag == "off"){

						BoxchildrenBox[j].gameObject.SetActive(true);
					}

				}
			}
			if((Boxchildren[i].gameObject.tag == "act123")||(Boxchildren[i].gameObject.tag == "act1")){
				Boxchildren[i].gameObject.SetActive(false);
			}
			if((Boxchildren[i].gameObject.tag == "act23")||(Boxchildren[i].gameObject.tag == "act2")){
				Boxchildren[i].gameObject.SetActive(false);
			}
			if(Boxchildren[i].gameObject.tag == "act3"){
				Boxchildren[i].gameObject.SetActive(false);
			}
		}
		

	}
	public static void BoxExplode(GameObject Box){
		//temp game object reset
		GameObject temp = null;
		if(Box!=null){
		Sound.instance.explodebox();
		//array of the children
		Transform [] BoxChildren = Box.GetComponentsInChildren<Transform> (true);
		//Search Through All Children for Active
		for (int i =0; i<BoxChildren.Length; i++) {
			//turns off box 
			if(BoxChildren[i].gameObject.tag == "box"){

				BoxChildren[i].gameObject.SetActive(false);
			}
			//checks for active object
			if(((BoxChildren[i].gameObject.tag == "act1")||(BoxChildren[i].gameObject.tag == "act123"))&&
			    (BoxChildren[i].gameObject.activeSelf == true)){
				temp = BoxChildren[i].gameObject;
				//Search for the explosion
				for (int j =0; j<BoxChildren.Length; j++){
					if((BoxChildren[j].gameObject.tag == "acte1")||(BoxChildren[j].gameObject.tag == "acte123")){
						//add Sound

						BoxChildren[j].gameObject.SetActive(true);
						//turn off color box and turns on explosion
						temp.SetActive(false);
					}
				}
			}
			//checks for active object
			if(((BoxChildren[i].gameObject.tag == "act2")||(BoxChildren[i].gameObject.tag == "act23")||
				(BoxChildren[i].gameObject.tag == "act123"))&&
			   (BoxChildren[i].gameObject.activeSelf == true)){
				temp = BoxChildren[i].gameObject;
				//Search for the explosion
				for (int j =0; j<BoxChildren.Length; j++){
					if((BoxChildren[j].gameObject.tag == "acte2")||(BoxChildren[j].gameObject.tag == "acte23")
						||(BoxChildren[j].gameObject.tag == "acte123")){
						//add Sound

						BoxChildren[j].gameObject.SetActive(true);
						//turn off color box and turns on explosion
						temp.SetActive(false);
					}
				}
			}
			//checks for active object
			if(((BoxChildren[i].gameObject.tag == "act3")||(BoxChildren[i].gameObject.tag == "act123")
				||(BoxChildren[i].gameObject.tag == "act23"))&&
			   (BoxChildren[i].gameObject.activeSelf == true)){
				temp = BoxChildren[i].gameObject;
				//Search for the explosion
				for (int j =0; j<BoxChildren.Length; j++){
					if((BoxChildren[j].gameObject.tag == "acte3")||(BoxChildren[j].gameObject.tag == "acte123")||
						(BoxChildren[j].gameObject.tag == "acte123")){
						//add Sound

						BoxChildren[j].gameObject.SetActive(true);
						//turn off color box and turns on explosion
						temp.SetActive(false);
					}
				}
			}

		}
	}
	}

	//checks if the boxes are the game color
	public static bool DuplicateBox(GameObject Box1,GameObject Box2){
		if (Box1.layer == Box2.layer) {
			return true;
		} else {
			return false;
		}
	}

	//turns on the box that is clicked
	public static GameObject TurnOnBox(GameObject Box,bool active1,bool active2,bool active3){
		//array of children
		Transform [] BoxChildren = Box.GetComponentsInChildren<Transform> (true);
		//temp game Object
		GameObject temp = null;
		Sound.instance.activebox();
		
			//search through all children
			for (int i =0; i < BoxChildren.Length; i++) {
				//turns off box
				if(BoxChildren[i].gameObject.tag == "box" ){

					Transform [] BoxChildrenBox = BoxChildren[i].GetComponentsInChildren<Transform> (true);

					for(int j=0;j<BoxChildrenBox.Length;j++){

						if(BoxChildrenBox[j].gameObject.tag == "off"){

							BoxChildrenBox[j].gameObject.SetActive(false);

						}

					}

				}
				//checks if box phase 1 is turned on
				if(((BoxChildren[i].gameObject.tag == "act1")||(BoxChildren[i].gameObject.tag == "act123"))&&
				   (active1)&&
				   (!active2)&&
				   (!active3)){
					temp = BoxChildren[i].gameObject;
					temp.SetActive(true);

				}
				//checks if box phase 2 is turned on
				if(((BoxChildren[i].gameObject.tag == "act2")||(BoxChildren[i].gameObject.tag == "act23")||
					(BoxChildren[i].gameObject.tag == "act123"))&&
				   (active1)&&
				   (active2)&&
				   (!active3)){
					temp = BoxChildren[i].gameObject;
					temp.SetActive(true);
				}
				//checks if box phase 3 is turned on
				if(((BoxChildren[i].gameObject.tag == "act3")||(BoxChildren[i].gameObject.tag == "act123")
					||(BoxChildren[i].gameObject.tag == "act23"))&&
				   (active1)&&
				   (active2)&&
				   (active3)){
					temp = BoxChildren[i].gameObject;
					temp.SetActive(true);
				}

			
	    }
		return temp;

	}
	//removing an array index
	public static string[] RemoveLamp(string[] LampArray,int x){
		if(LampArray.Length !=1){
			Sound.instance.swaplamp();
		}
		
		//decleares new string array of lamps
		string [] UpdatedLamp = new string[LampArray.Length-1];
		//loop counters
		int i = 0;
		int j = 0;
		//loop occurs while true
		while(i < LampArray.Length){
			// updates lamp array and remove old
			if(i != x){
				UpdatedLamp[j] = LampArray[i];
				j++;
			}
			i++;
		}
		//return lamp array
		return UpdatedLamp;
		
	}
	//Removes a Box from the GameObject Array
	public static GameObject[] RemoveBox(GameObject[] BoxArray, GameObject Box){

		GameObject[] TempBoxArray = new GameObject[BoxArray.Length-1];

		int i = 0;
		int j = 0;

		while(i < BoxArray.Length){

			if(BoxArray[i] != Box){
				TempBoxArray[j] = BoxArray[i];
				j++;
			}
			i++;

		}
		return TempBoxArray;
	}
	public static bool CheckBox(string color,GameObject Box){
		// Array of Box Children
		Transform [] Boxchildren = Box.GetComponentsInChildren<Transform> (true);

		for(int i=0;i < Boxchildren.Length;i++){
			// checks the color
			if((color=="purple")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 10) || (Boxchildren[i].gameObject.layer == 11))){
				//return true
				
				return true;
			}
			// checks the color
			if((color=="teal")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 12) || (Boxchildren[i].gameObject.layer == 11))){
			
				//return true
				return true;
			}
			// checks the color
			if((color=="yellow")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 12) || (Boxchildren[i].gameObject.layer == 10))){
				//return true
				return true;
			}
			// checks the color
			if((color=="white")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 12) || (Boxchildren[i].gameObject.layer == 11) ||
				 (Boxchildren[i].gameObject.layer == 10))){
				//return true
				return true;
			}
			// checks the color
			if((color=="orange")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 10) || (Boxchildren[i].gameObject.layer == 15)||
				 (Boxchildren[i].gameObject.layer == 20))){
				//return true
				return true;
			}
			// checks the color
			if((color=="grey")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 16) || (Boxchildren[i].gameObject.layer == 18)||
				 (Boxchildren[i].gameObject.layer == 20))){
				//return true
				return true;
			}
			// checks the color
			if((color=="black")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 13) || (Boxchildren[i].gameObject.layer == 14)||
				 (Boxchildren[i].gameObject.layer == 15))){
				//return true
				return true;
			}
			// checks the color
			if((color=="brown")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 17) || (Boxchildren[i].gameObject.layer == 11)||
				 (Boxchildren[i].gameObject.layer == 20))){
				//return true
				return true;
			}
			// checks the color
			if((color=="pink")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 10) || (Boxchildren[i].gameObject.layer == 18)||
				 (Boxchildren[i].gameObject.layer == 20))){
				//return true
				return true;
			}
			// checks the color
			if((color=="red")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 13) || (Boxchildren[i].gameObject.layer == 15))){
				//return true
				return true;
			}
			// checks the color
			if((color=="blue")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 13) || (Boxchildren[i].gameObject.layer == 14))){
				//return true
				return true;
			}
			// checks the color
			if((color=="green")&&
				//checks if the box is active
				(Boxchildren[i].gameObject.activeSelf == true)&&
				//checks to make sure the tag is correct
				((Boxchildren[i].gameObject.tag == "act1")||(Boxchildren[i].gameObject.tag == "act123")||
				 (Boxchildren[i].gameObject.tag == "act2")||(Boxchildren[i].gameObject.tag == "act23")||
				 (Boxchildren[i].gameObject.tag == "act3"))&&
				//checks to make sure the colors are correct
				((Boxchildren[i].gameObject.layer == 14) || (Boxchildren[i].gameObject.layer == 15))){
				//return true
				return true;
			}

		}
		return false;
	}
	public static int LampColorNum(string color){

		//checks color and returns animator color 
		if(color == "purple"){
			return 0;
		}
		else if (color == "teal"){
			return 1;
		}
		else if (color == "yellow"){
			return 2;
		}
		else if (color == "white"){
			return 3;
		}
		else if (color == "orange"){
			return 4;
		}
		else if (color == "grey"){
			return 5;
		}
		else if (color == "black"){
			return 6;
		}
		else if (color == "brown"){
			return 7;
		}
		else if (color == "pink"){
			return 8;
		}
		else if (color == "red"){
			return 9;
		}
		else if (color == "green"){
			return 10;
		}
		else if (color == "blue"){
			return 11;
		}
		else{
			return 9;
		}
	}
	//returns lamp color number
	public static int Lampinteger(string color){

		//checks color and returns animator color 
		if(color == "purple"){
			return 2;
		}
		else if (color == "teal"){
			return 2;
		}
		else if (color == "yellow"){
			return 2;
		}
		else if (color == "white"){
			return 3;
		}
		else if (color == "orange"){
			return 2;
		}
		else if (color == "grey"){
			return 2;
		}
		else if (color == "black"){
			return 3;
		}
		else if (color == "brown"){
			return 2;
		}
		else if (color == "pink"){
			return 2;
		}
		else if (color == "red"){
			return 2;
		}
		else if (color == "blue"){
			return 2;
		}
		else if (color == "green"){
			return 2;
		}
		else{
			return 9;
		}
	}
	//if touched return game object that was touched
	public static GameObject checkTouch(Vector3 pos){

    	Vector3 wp = Camera.main.ScreenToWorldPoint(pos);
		Vector2 touchPos = new Vector2 (wp.x, wp.y);
    	Collider2D hit = Physics2D.OverlapPoint(touchPos);

    	if(hit){
    		
    		return hit.transform.gameObject;
         	
    	}
    	else{

    		return null;
    	}
    }
    //after lamp solve destroy box
    public static void DestroyBox(GameObject Box){
    	Box.SetActive(false);
    	Destroy(Box);
    }

    //check if touch box is already active
    public static bool CheckActive(GameObject Box){
    	//finds all the children of the box
    	Transform [] Boxchildren = Box.GetComponentsInChildren<Transform> (true);

    	for(int i =0; i < Boxchildren.Length; i++){

    		if((Boxchildren[i].gameObject.tag == "box")&&
    			(Boxchildren[i].gameObject.activeSelf == true)){

    			return true;

    		}
    	}
    	return false;
    }
    //checks based on actives
    public static bool CheckLamp(string color,int x){

    	if((color == "purple")&&
    	   (x==2)){

    		return true;
    	}

    	if((color == "teal")&&
    	   (x==2)){

    		return true;
    	}

    	if((color == "yellow")&&
    	   (x==2)){

    		return true;
    	}

    	if((color == "white")&&
    	   (x==3)){

    		return true;
    	}

    	if((color == "orange")&&
    	   (x==2)){

    		return true;
    	}

    	if((color == "grey")&&
    	   (x==2)){

    		return true;
    	}

    	if((color == "black")&&
    	   (x==3)){

    		return true;
    	}

    	if((color == "brown")&&
    	   (x==2)){

    		return true;
    	}

    	if((color == "pink")&&
    	   (x==2)){

    		return true;
    	}
    	if((color == "red")&&
    	   (x==2)){

    		return true;
    	}
    	if((color == "blue")&&
    	   (x==2)){

    		return true;
    	}
    	if((color == "green")&&
    	   (x==2)){

    		return true;
    	}

    	return false;
    }
    public static GameObject ReturnNumber(GameObject ind,string number){

    	Transform [] indchildren = ind.GetComponentsInChildren<Transform> (true);

    	for(int i=0;i<indchildren.Length;i++){

    		if((indchildren[i].gameObject.tag == "one")&&(number == "one")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "two")&&(number == "two")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "three")&&(number == "three")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "four")&&(number == "four")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "five")&&(number == "five")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "six")&&(number == "six")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "arrow")&&(number == "arrow")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "victory")&&(number == "victory")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "defeated")&&(number == "defeated")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "zero")&&(number == "zero")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "mainmenu")&&(number == "mainmenu")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "loader")&&(number == "loadbar")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "bg2")&&(number == "bg2")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "bg3")&&(number == "bg3")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "phase2")&&(number == "phase2")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "phase3")&&(number == "phase3")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "phase1")&&(number == "phase1")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "shaman")&&(number == "shaman")){
    			return indchildren[i].gameObject;
    		}
    		if((indchildren[i].gameObject.tag == "lamp")&&(number == "lamp")){
    			return indchildren[i].gameObject;
    		}

    	}
    	return null;
    }
    public static bool Combinations(GameObject[] boxes,int color){

    	for(int i=0;i<boxes.Length;i++){

    		Transform [] boxchildren = boxes[i].GetComponentsInChildren<Transform> (true);
    		for(int j=0;j<boxchildren.Length;j++){

    			if(boxchildren[j].gameObject.layer == color){

    				return true;
    			}
    		}

    	}
    	return false;

    }
    public static bool CheckCombination(GameObject[] boxes, string color){
    	int temp = 0;
    	int temp2 = 0;
    	Transform [] boxchildren = null;

    	for(int i=0;i<boxes.Length;i++){

    		boxchildren = boxes[i].GetComponentsInChildren<Transform> (true);

    		for(int j=0;j<boxchildren.Length;j++){


    			if((color == "purple")&&
    				((boxchildren[j].gameObject.layer == 10)||
    				 (boxchildren[j].gameObject.layer == 11)||
    				 (boxchildren[j].gameObject.layer == 13))&&
    				 ((boxchildren[j].gameObject.tag == "act1")||(boxchildren[j].gameObject.tag == "act123"))) {
    					if(temp == 0){
    						temp = boxchildren[j].gameObject.layer;
    					}
						
						if(boxchildren[j].gameObject.layer == 13){
							return true;
						}

    			}
    			if((color == "teal")&&
    				((boxchildren[j].gameObject.layer == 12)||
    				 (boxchildren[j].gameObject.layer == 11)||
    				 (boxchildren[j].gameObject.layer == 14))&&
    				 ((boxchildren[j].gameObject.tag == "act1")||
    				  (boxchildren[j].gameObject.tag == "act123"))) {

						if(temp == 0){
    						temp = boxchildren[j].gameObject.layer;
    					}
						if(boxchildren[j].gameObject.layer == 14){
							return true;
						}

    			}
    			if((color == "yellow")&&
    				((boxchildren[j].gameObject.layer == 12)||
    				 (boxchildren[j].gameObject.layer == 10)||
    				 (boxchildren[j].gameObject.layer == 15))&&
    				 ((boxchildren[j].gameObject.tag == "act1")||(boxchildren[j].gameObject.tag == "act123"))) {

						if(temp == 0){
    						temp = boxchildren[j].gameObject.layer;
    					}
						if(boxchildren[j].gameObject.layer == 15){
							return true;
						}

    			}
    			if((color == "white")&&
    				((boxchildren[j].gameObject.layer == 10)||
    				 (boxchildren[j].gameObject.layer == 11)||
    				 (boxchildren[j].gameObject.layer == 12)||
    				 (boxchildren[j].gameObject.layer == 18))&&
    				 ((boxchildren[j].gameObject.tag == "act1")||(boxchildren[j].gameObject.tag == "act123"))) {
						if(temp == 0){
    						temp = boxchildren[j].gameObject.layer;
    					}
						if(boxchildren[j].gameObject.layer == 18){
							return true;
						}

    			}
    			if((color == "orange")&&
    				((boxchildren[j].gameObject.layer == 10)||
    				 (boxchildren[j].gameObject.layer == 15))&&
    				 (temp == 0)&&
    				 ((boxchildren[j].gameObject.tag == "act1")||(boxchildren[j].gameObject.tag == "act123"))) {
    					
						temp = boxchildren[j].gameObject.layer;

    			}
    			if((color == "grey")&&
    				((boxchildren[j].gameObject.layer == 16)||
    				 (boxchildren[j].gameObject.layer == 18))&&
    				 (temp == 0)&&
    				 ((boxchildren[j].gameObject.tag == "act1")||(boxchildren[j].gameObject.tag == "act123"))) {
						temp = boxchildren[j].gameObject.layer;

    			}
    			if((color == "black")&&
    				((boxchildren[j].gameObject.layer == 13)||
    				 (boxchildren[j].gameObject.layer == 14)||
    				 (boxchildren[j].gameObject.layer == 15))&&
    				 (temp == 0)&&
    				 ((boxchildren[j].gameObject.tag == "act1")||(boxchildren[j].gameObject.tag == "act123"))) {
						temp = boxchildren[j].gameObject.layer;
						

    			}
    			if((color == "brown")&&
    				((boxchildren[j].gameObject.layer == 17)||
    				 (boxchildren[j].gameObject.layer == 11))&&
    				 (temp == 0)&&
    				 ((boxchildren[j].gameObject.tag == "act1")||(boxchildren[j].gameObject.tag == "act123"))) {
						temp = boxchildren[j].gameObject.layer;

    			}
    			if((color == "pink")&&
    				((boxchildren[j].gameObject.layer == 18)||
    				 (boxchildren[j].gameObject.layer == 10))&&
    				 (temp == 0)&&
    				 ((boxchildren[j].gameObject.tag == "act1")||(boxchildren[j].gameObject.tag == "act123"))) {
						temp = boxchildren[j].gameObject.layer;

    			}
    			if((color == "red")&&
    				((boxchildren[j].gameObject.layer == 15)||
    				 (boxchildren[j].gameObject.layer == 13)||
    				 (boxchildren[j].gameObject.layer == 10))&&
    				 ((boxchildren[j].gameObject.tag == "act1")||(boxchildren[j].gameObject.tag == "act123"))) {
						if(temp == 0){
    						temp = boxchildren[j].gameObject.layer;
    					}
						if(boxchildren[j].gameObject.layer == 10){
							return true;
						}

    			}
    			if((color == "green")&&
    				((boxchildren[j].gameObject.layer == 14)||
    				 (boxchildren[j].gameObject.layer == 15)||
    				 (boxchildren[j].gameObject.layer == 12))&&
    				 ((boxchildren[j].gameObject.tag == "act1")||(boxchildren[j].gameObject.tag == "act123"))) {
						if(temp == 0){
    						temp = boxchildren[j].gameObject.layer;
    					}
						if(boxchildren[j].gameObject.layer == 12){
							return true;
						}

    			
				}	
    			if((color == "blue")&&
    				((boxchildren[j].gameObject.layer == 13)||
    				 (boxchildren[j].gameObject.layer == 14)||
    				 (boxchildren[j].gameObject.layer == 11))&&
    				 ((boxchildren[j].gameObject.tag == "act1")||(boxchildren[j].gameObject.tag == "act123"))) {
						if(temp == 0){
    						temp = boxchildren[j].gameObject.layer;
    					}

						if(boxchildren[j].gameObject.layer == 11){

							return true;
						}

    			}
    		
        }
    }
    for(int i=0;i<boxes.Length;i++){

    		boxchildren = boxes[i].GetComponentsInChildren<Transform> (true);

    		for(int j=0;j<boxchildren.Length;j++){
    			// using temp to check solve
    			if((color == "purple")&&
    				((boxchildren[j].gameObject.layer == 10)||
    				 (boxchildren[j].gameObject.layer == 11))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {

						return true;

    			}
    			if((color == "teal")&&
    				((boxchildren[j].gameObject.layer == 12)||
    				 (boxchildren[j].gameObject.layer == 11))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {

						return true;

    			}
    			if((color == "yellow")&&
    				((boxchildren[j].gameObject.layer == 12)||
    				 (boxchildren[j].gameObject.layer == 10))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {

						return true;

    			}
    			if((color == "white")&&
    				((boxchildren[j].gameObject.layer == 10)||
    				 (boxchildren[j].gameObject.layer == 11)||
    				 (boxchildren[j].gameObject.layer == 12))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 (temp2 == 0)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {

						temp2 = boxchildren[j].gameObject.layer;

    			}

    			if((color == "orange")&&
    				((boxchildren[j].gameObject.layer == 10)||
    				 (boxchildren[j].gameObject.layer == 15)||
    				 (boxchildren[j].gameObject.layer == 20))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {
    					
    					temp2 = boxchildren[j].gameObject.layer;
    					if(((temp == 10)||(temp == 15))&&
    						((temp2 == 15)||(temp2 == 10))){

    						return true;
    					}
						
    			}
    			if((color == "grey")&&
    				((boxchildren[j].gameObject.layer == 16)||
    				 (boxchildren[j].gameObject.layer == 18)||
    				 (boxchildren[j].gameObject.layer == 20))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {

    					temp2 = boxchildren[j].gameObject.layer;
						if(((temp == 16)||(temp == 18))&&
    						((temp2 == 16)||(temp2 == 18))){
    						
    						return true;
    					}
    			}
    			if((color == "black")&&
    				((boxchildren[j].gameObject.layer == 13)||
    				 (boxchildren[j].gameObject.layer == 14)||
    				 (boxchildren[j].gameObject.layer == 15))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 (temp2 == 0)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {

						temp2 = boxchildren[j].gameObject.layer;
						


    			}
    			if((color == "brown")&&
    				((boxchildren[j].gameObject.layer == 17)||
    				 (boxchildren[j].gameObject.layer == 11)||
    				 (boxchildren[j].gameObject.layer == 20))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {

						temp2 = boxchildren[j].gameObject.layer;
						if(((temp == 17)||(temp == 11))&&
    					   ((temp2 == 17)||(temp2 == 11))){
    						
    						return true;
    					}

    			}
    			if((color == "pink")&&
    				((boxchildren[j].gameObject.layer == 18)||
    				 (boxchildren[j].gameObject.layer == 10)||
    				 (boxchildren[j].gameObject.layer == 20))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {

						temp2 = boxchildren[j].gameObject.layer;
						if(((temp == 18)||(temp == 10))&&
    						((temp2 == 18)||(temp2 == 10))){
    						
    						return true;
    					}

    			}
    			if((color == "red")&&
    				((boxchildren[j].gameObject.layer == 15)||
    				 (boxchildren[j].gameObject.layer == 13))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {

						return true;

    			}
    			if((color == "green")&&
    				((boxchildren[j].gameObject.layer == 14)||
    				 (boxchildren[j].gameObject.layer == 15))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {

						return true;

    			}
    			if((color == "blue")&&
    				((boxchildren[j].gameObject.layer == 13)||
    				 (boxchildren[j].gameObject.layer == 14))&&
    				 (temp != 0)&&
    				 (temp != boxchildren[j].gameObject.layer)&&
    				 ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123"))) {

						return true;

    			}
    			

    		}
    	}
    	for(int i=0;i<boxes.Length;i++){

    		boxchildren = boxes[i].GetComponentsInChildren<Transform> (true);
    		for(int j=0;j<boxchildren.Length;j++){

    			if((color == "black")&&
                    ((boxchildren[j].gameObject.layer == 13)||
                     (boxchildren[j].gameObject.layer == 14)||
                     (boxchildren[j].gameObject.layer == 15))&&
                     (temp != 0)&&
                     (temp != boxchildren[j].gameObject.layer)&&
                     (temp2 != 0)&&
                     (temp2 != boxchildren[j].gameObject.layer)&&
                     ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123")||
                      (boxchildren[j].gameObject.tag == "act3")) ) {

                        return true;

                }
                if((color == "white")&&
                    ((boxchildren[j].gameObject.layer == 10)||
                     (boxchildren[j].gameObject.layer == 11)||
                     (boxchildren[j].gameObject.layer == 12))&&
                     (temp != 0)&&
                     (temp != boxchildren[j].gameObject.layer)&&
                     (temp2 != 0)&&
                     (temp2 != boxchildren[j].gameObject.layer)&&
                     ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123")||
                      (boxchildren[j].gameObject.tag == "act3"))) {

                        return true;

                }
                if((color == "orange")&&
                    ((boxchildren[j].gameObject.layer == 10)||
                     (boxchildren[j].gameObject.layer == 15)||
                     (boxchildren[j].gameObject.layer == 20))&&
                     (temp != 0)&&
                     (temp != boxchildren[j].gameObject.layer)&&
                     (temp2 != 0)&&
                     (temp2 != boxchildren[j].gameObject.layer)&&
                     ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123")||
                      (boxchildren[j].gameObject.tag == "act3"))) {

                        return true;

                }
                if((color == "grey")&&
                    ((boxchildren[j].gameObject.layer == 18)||
                     (boxchildren[j].gameObject.layer == 16)||
                     (boxchildren[j].gameObject.layer == 20))&&
                     (temp != 0)&&
                     (temp != boxchildren[j].gameObject.layer)&&
                     (temp2 != 0)&&
                     (temp2 != boxchildren[j].gameObject.layer)&&
                     ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123")||
                      (boxchildren[j].gameObject.tag == "act3"))) {

                        return true;

                }
                if((color == "brown")&&
                    ((boxchildren[j].gameObject.layer == 17)||
                     (boxchildren[j].gameObject.layer == 11)||
                     (boxchildren[j].gameObject.layer == 20))&&
                     (temp != 0)&&
                     (temp != boxchildren[j].gameObject.layer)&&
                     (temp2 != 0)&&
                     (temp2 != boxchildren[j].gameObject.layer)&&
                     ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123")||
                      (boxchildren[j].gameObject.tag == "act3"))) {

                        return true;

                }
                if((color == "pink")&&
                    ((boxchildren[j].gameObject.layer == 10)||
                     (boxchildren[j].gameObject.layer == 18)||
                     (boxchildren[j].gameObject.layer == 20))&&
                     (temp != 0)&&
                     (temp != boxchildren[j].gameObject.layer)&&
                     (temp2 != 0)&&
                     (temp2 != boxchildren[j].gameObject.layer)&&
                     ((boxchildren[j].gameObject.tag == "act23")||(boxchildren[j].gameObject.tag == "act123")||
                      (boxchildren[j].gameObject.tag == "act3"))) {

                        return true;

                }
    		}
    	}


    	
    	return false;

    }
    //checks based on actives
    public static bool Finalchecklamp(string color,int x,GameObject box){

    	if((color == "purple")&&
    	   (x==2)){

    		return true;
    	}

    	if((color == "teal")&&
    	   (x==2)){

    		return true;
    	}

    	if((color == "yellow")&&
    	   (x==2)){

    		return true;
    	}

    	if((color == "white")&&
    	   (x==3)){

    		return true;
    	}

    	if((color == "orange")&&
    	   (x==2)&&
    	   (box.layer != 20)){

    		return true;
    	}
    	if((color == "orange")&&
    	   (x==3)&&
    	   (box.layer == 20)){

    		return true;
    	}

    	if((color == "grey")&&
    	   (x==2)&&
    	   (box.layer != 20)){

    		return true;
    	}
    	if((color == "grey")&&
    	   (x==3)&&
    	   (box.layer == 20)){

    		return true;
    	}

    	if((color == "black")&&
    	   (x==3)){

    		return true;
    	}

    	if((color == "brown")&&
    	   (x==2)&&
    	   (box.layer != 20)){

    		return true;
    	}
    	if((color == "brown")&&
    	   (x==3)&&
    	   (box.layer == 20)){

    		return true;
    	}

    	if((color == "pink")&&
    	   (x==2)&&
    	   (box.layer != 20)){

    		return true;
    	}
    	if((color == "pink")&&
    	   (x==3)&&
    	   (box.layer == 20)){

    		return true;
    	}
    	if((color == "red")&&
    	   (x==2)){

    		return true;
    	}
    	if((color == "blue")&&
    	   (x==2)){

    		return true;
    	}
    	if((color == "green")&&
    	   (x==2)){

    		return true;
    	}

    	return false;
    }
    
	
}
