using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsGenerator : MonoBehaviour {

	[SerializeField] Transform prefabMinimizador;
	[SerializeField] Transform prefabMaximizador;
	void Start () {

		// InvokeRepeating se usa para crear un objeto en el juego desde un prefab. 

        InvokeRepeating("GenerarBlueBall", 6, 12);
		
		 InvokeRepeating("GenerarGreenBall", 12, 12);
	}
	void GenerarBlueBall()
    {
       if (GameConfig.IsPlaying()) {

            // esto se usa para que el objeto creado esté perfectamente alineado con los ejes del mapa.
            Instantiate(prefabMinimizador, transform.position, Quaternion.identity);
        }
    }
	void GenerarGreenBall(){
    
       if (GameConfig.IsPlaying()) {

            // esto se usa para que el objeto creado esté perfectamente alineado con los ejes del mapa.
            Instantiate(prefabMaximizador, transform.position, Quaternion.identity);
        }
	}
}
