using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int power;
    GameController controller;

    // Use this for initialization
    void Start () {
        power = 0;
        controller = GameController.gameController;
        controller.powerToPlayer += powerToPlayer;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void powerToPlayer(int p)
    {
        power += p;
    }

    public int GetPower()
    {
        return power;
    }
}
