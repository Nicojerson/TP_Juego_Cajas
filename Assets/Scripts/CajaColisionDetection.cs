using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaColisionDetection : MonoBehaviour
{
    public UIMANAGER uiMGR;
    private Vector3[] posiciones = 
    {
        new Vector3(0f, 6.67f, 0f),
        new Vector3(2f, 6.67f, 0f),
        new Vector3(-2f, 6.67f, 0f)
    };
    //Creo un array de variables de tipo vector3 (vector3 tiene tres valores, x, y, y z)
    //Le añado 3 variables a ese array, las 3 posiciones que voy a necesitar
    //Para acceder a una de esas variables hago posiciones[1] o 0 o 2

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        int posicionrandom = Random.Range(0, posiciones.Length);
        //Creo una variable que es algo random desde 0 de posiciones hasta el ultimo (osea posiciones.length)
        //Esa variable es un numero random del 0 al 2, y lo voy a usar despues


        Debug.Log("Colisión con " + col.gameObject.name);
        if(col.gameObject.CompareTag("Player"))
        {
            uiMGR.textoPerdiste.gameObject.SetActive(true);
            Destroy(col.gameObject);
        }else if(col.gameObject.CompareTag("Piso")){
            gameObject.transform.position = posiciones[posicionrandom];

        }
    }


}
