using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolverAlMenu : MonoBehaviour {

	public Button volverbtn;

	// Use this for initialization
	void Start () {
		Button vol = volverbtn.GetComponent<Button>();
		vol.onClick.AddListener(volver);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void volver () {
		Application.LoadLevel("Menu");
	}
}
