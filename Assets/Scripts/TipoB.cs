using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoB : MonoBehaviour {
    bool isShaking;

    float speed = 50f; //how fast it shakes
    float amount = 0.018f; //how much it shakes
                           // Use this for initialization
    GameController controller;

    void Start()
    {
        isShaking = false;
  
        controller = GameController.gameController;
        controller.CShakeB += changeShake;
    }

    // Update is called once per frame
    void Update()
    {
        if (isShaking)
        {
            transform.Translate(new Vector3(Mathf.Sin(Time.time * speed), 0, 0) * amount);
        }
    }

    void changeShake()
    {
        isShaking = !isShaking;
    }


}