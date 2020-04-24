using UnityEngine;
using System.Collections;

public class og : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		if(GUI.Button(new Rect(400,400,100,50),"play"))
			
		{
			Application.LoadLevel(1);
			
		}
	}
	
	
}
