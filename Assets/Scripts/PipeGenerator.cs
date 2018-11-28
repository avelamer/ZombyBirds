using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{

    [SerializeField] Transform prefabTuberia;
    void Start()
    {
        // InvokeRepeating se usa para crear un objeto en el juego desde un prefab. 

        InvokeRepeating("GenerarPipe", 1, 2);
    }
    void GenerarPipe()
    {
       if (GameConfig.IsPlaying()) {

            // esto se usa para que el objeto creado esté perfectamente alineado con los ejes del mapa.
            Instantiate(prefabTuberia, transform.position, Quaternion.identity);
        }

    }
       


    
}