using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberias : MonoBehaviour {

int PosicionDestroyTuberia = -20;

    /* -[SeriezableField] se usa para que esta variable pueda ser modifficada desde fuera
       -int (variable de tipo entero) velocidad (nombre de la variable) = 2 (valor de la variable)
       -como no se ha especificado el tipo de variable se sobrentiende que es público*/

    [SerializeField] int velocidad = 10;

    float limiteSuperiorY = 3.0f;

    float limiteInferiorY = -3.0f;


    void Start () {
      
        float posicionY = Random.Range(limiteInferiorY, limiteSuperiorY);

        transform.position = new Vector3(transform.position.x,posicionY,transform.position.z);
    }


    void Update () {

        transform.Translate(Vector3.left * Time.deltaTime* velocidad);

        if (transform.position.x < PosicionDestroyTuberia){

            Destroy(gameObject);

         }
	}
}
