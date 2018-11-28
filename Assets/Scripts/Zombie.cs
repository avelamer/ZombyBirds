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
       
       puntos = puntos + 1;

      ActualizarMarcador();

        Debug.Log (colisionador.name);
        Debug.Log (puntos);
  
    }
    void OnCollisionEnter(Collision explosion) {
        


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




}

