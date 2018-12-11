using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public delegate void eventDelegate();
public delegate void eventDelegatePower(int p);
public delegate void eventDelegateObject(GameObject g);
public class GameController : MonoBehaviour {


    public static GameController gameController;
    public event eventDelegatePower powerToPlayer;
    public event eventDelegateObject deleteTipoA;
    public event eventDelegate CShakeB;

    public Text textPower;
    public Text ApiAiText;
    private string defaultDesc = "Selecione un objeto para mostrar su información";
    private Player player;
    private TipoA tipoA;
 

    void Awake()
    {
        if (gameController == null)
        {
            gameController = this;
            DontDestroyOnLoad(this);
        }
        else if (gameController != this)
        {
            Destroy(gameObject);
        }
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        tipoA = GameObject.FindGameObjectWithTag("TipoA").GetComponent<TipoA>();
        
        tipoA.onShoot = ShootObjectA;
    }

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    public void ShootObjectA(GameObject g)
    {
        if (player.power > 0)
        {
            deleteTipoA(g);
            player.power--;
            textPower.text = "Power : " + player.GetPower();
        }
        else {
            textPower.color = Color.red;
        }
    }

    public void GivePowerToPlayer(int p)
    {
        powerToPlayer(p);
        textPower.text = "Power : " + player.GetPower();
        textPower.color = Color.white;
    }

    public void LookingB(){
        CShakeB();
    }

    public void OnLeftObject()
    {
        ApiAiText.text = defaultDesc;
    }
}
