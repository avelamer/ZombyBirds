using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : MonoBehaviour {

	int PosicionDestroyBall = -20;
    [SerializeField] int velocidad = 10;
    float limiteSuperiorY = 3.0f;
    float limiteInferiorY = -3.0f;
    void Start () {
     float posicionY = Random.Range(limiteInferiorY, limiteSuperiorY);
	 transform.position = new Vector3(transform.position.x,posicionY,transform.position.z);
    }

    void Update () {

        if (GameConfig.IsPlaying()) {

         transform.Translate(Vector3.left * Time.deltaTime* velocidad);

        }

        if (transform.position.x < PosicionDestroyBall){

            Destroy(gameObject);

         }
	}
}
