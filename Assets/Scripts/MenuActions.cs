using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using UnityEngine.UI;


public class MenuActions : MonoBehaviour {
	//public AudioSource buttonClick;
	public Button[] mainMenu;
	public Button[] games;
	public int startY, startX, size, offset;

    void Awake()
    {
		for (int i = 0; i < games.Length; i++) {
			games[i].gameObject.SetActive(false);
		}
    }
    
    public void ButtonClick(string description)
    {
		String levelToLoad = "";
		//buttonClick.Play();

		switch(description)
		{
		case "Pong": levelToLoad = "Pong"; break;
		case "Play": switchMenu("GameMenu"); break;
		//case "Load   Game":  break;
		//case "NewGame": levelToLoad = "Level1"; break;
		//case "Prlouge": break;
		//case "Options": levelToLoad = "Options Menu"; break;
		//case "Crdits": break;
		//case "Quit": break;
		}

		StartCoroutine(Delay(.4f, levelToLoad)); //StartCoroutine(Delay(buttonClick.time + .4f, levelToLoad));
    }

	void switchMenu(String menu) {
		switch(menu) {
		case "GameMenu": 
			foreach(Button main in mainMenu) { 
				main.gameObject.SetActive(false);
			} 
			foreach(Button game in games) {
				game.gameObject.SetActive(true);
			} break;
		case "MainMenu": 
			foreach(Button main in mainMenu) {
				main.gameObject.SetActive(true);
			}
			foreach(Button game in games) {
				game.gameObject.SetActive(false);
			} break;
		}
	}

	IEnumerator Delay(float delaySec, String level)
	{
		yield return new WaitForSeconds(delaySec); 
		if (!level.Equals(""))
			Application.LoadLevel(level);
	}
}
