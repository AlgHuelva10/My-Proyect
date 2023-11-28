using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Destruir "GameObject"
        destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
       //Imprimir "Crikets" en la consola
        print("Crikets"); 
    }
}
