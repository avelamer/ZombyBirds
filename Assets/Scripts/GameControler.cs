using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour {

	private const string PUNTOS = "puntos";
	private const string HIGHTSCORE = "hightscore";

	public static void StorePuntos (int puntos){

		PlayerPrefs.SetInt(PUNTOS,puntos);
		PlayerPrefs.Save();
	}
	private static int GetPuntos (){
		int puntos = 0;

		return puntos;

	}

	public static void StoreHightScore (int hightscore){

		PlayerPrefs.SetInt(HIGHTSCORE,hightscore);
		PlayerPrefs.Save();
	}

	private static int GetHightScore (){
		int hightscore = 0;

		return hightscore;
	}	

	
}