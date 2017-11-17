using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public Button polimerizacionbtn;
	public Button reduccionbtn;
	public Button saponificacionbtn;
	public Button informacionbtn;
	public Button salirbtn;

	// Use this for initialization
	void Start () {
		Button poli = polimerizacionbtn.GetComponent<Button>();
		poli.onClick.AddListener(adicion);

		Button redu = reduccionbtn.GetComponent<Button>();
		redu.onClick.AddListener(reduccion);

		Button sapo = saponificacionbtn.GetComponent<Button>();
		sapo.onClick.AddListener(saponificacion);

		Button info = informacionbtn.GetComponent<Button>();
		info.onClick.AddListener(informacion);

		Button sal = salirbtn.GetComponent<Button>();
		sal.onClick.AddListener(salir);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void adicion(){
		Application.LoadLevel("Adicion");
	}

	void reduccion(){
		Application.LoadLevel("Reduccion");	
	}

	void saponificacion(){
		Application.LoadLevel("Sustitución");
	}

	void informacion(){
		Application.LoadLevel("Informacion");	
	}

	void salir(){
		Application.Quit();
	}
}
