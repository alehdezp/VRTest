using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoA : MonoBehaviour {
    public delegate void OnShoot(GameObject g);
    public OnShoot onShoot;
    GameController controller;

    void Start () {

        controller = GameController.gameController;
        controller.deleteTipoA += deleteObject;
    }
	
	// Update is called once per frame
	void Update () {
    
    }

    void deleteObject(GameObject g)
    {
        if (g == gameObject)
            g.SetActive(false);
    }

    public void Shooted(GameObject g)
    {
        onShoot(g);
    }

}
