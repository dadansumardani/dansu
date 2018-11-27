using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	public void GoToMainMenu()
	{
		Application.LoadLevel("main_menu");
	}
	
	public void GoToARCamera()
	{
		Application.LoadLevel("ARCamera");
	}

	public void GoToHint()
	{
		Application.LoadLevel("Petunjuk");
	}
	
	public void ExitApplication()
	{
		Application.Quit();
	}
		
		
}
