using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zombie : MonoBehaviour {




    Rigidbody pajaro;

    [SerializeField] Text marcadorPuntos;

    int puntos;


    public bool muerto;

    [SerializeField] int fuerza = 150;

    [SerializeField] Transform prefabExlosion;

    [SerializeField] AudioSource sonidoExplosion;

    [SerializeField] AudioSource sonidoPuntuacion;
	void Start () {
       
        GameConfig.ArrancaJuego ();
       
        marcadorPuntos.text = "Score: 0";

        muerto = false;

        pajaro = GetComponent<Rigidbody>();
	}


    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            pajaro.AddForce(transform.up*fuerza);
        }
    }
    void OnTriggerEnter (Collider colisionador){
       
        sonidoPuntuacion.Play ();

       puntos = puntos + 1;

        GameControler.StorePuntos(puntos);

      ActualizarMarcador();

        Debug.Log (colisionador.name);
        Debug.Log (puntos);
  
    }
    void OnCollisionEnter(Collision explosion) {
        

        sonidoExplosion.Play ();
        

        Instantiate (prefabExlosion, transform.position, Quaternion.identity);

        muerto = true;

        GameConfig.PararJuego ();

        Invoke ("Destruccion", 0.4f) ;
    }

    void ActualizarMarcador () {  
 
         marcadorPuntos.text = "Score: " + puntos;


    }
          
    void Destruccion () {

        Destroy (gameObject);

    }

   public void desctivarMusica () {


    }

  public void desactivarEfectos () {

      
  }

}

