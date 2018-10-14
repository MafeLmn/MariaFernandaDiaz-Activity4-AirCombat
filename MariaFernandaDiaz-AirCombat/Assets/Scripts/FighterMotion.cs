using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(Vector3.forward);

        if (Input.GetKey(KeyCode.RightArrow)) {
            this.transform.Translate(Vector3.right);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.transform.Translate(Vector3.left);
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            this.transform.Translate(Vector3.up);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            this.transform.Translate(Vector3.down);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            //creamos un nuevo gameobject missile a partir de un prefab
            GameObject newMissile = GameObject.Instantiate(Resources.Load("Bullets/Missile") as GameObject);
            //buscamos el pivote de disparo
            GameObject shootPivot = GameObject.Find("FighterPlane/ShootPivot");
            //Hacemos que el misil sea hijo del shoot pivot
            newMissile.transform.SetParent(shootPivot.transform);
            //movemos el misil hacia donde esta el shoot pivot, es decir, debajo del ala
            newMissile.transform.localPosition = Vector3.zero;
            //hacemos que los misiles ya no sean hijos del avión
            newMissile.transform.SetParent(null);
        }

    }
}
