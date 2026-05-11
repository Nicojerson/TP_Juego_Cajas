using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(0, -speed * Time.deltaTime, 0);
         if(Input.GetKeyDown(KeyCode.LeftArrow))
         {
            speed = speed + 0.3f;
         }

         if(Input.GetKeyDown(KeyCode.RightArrow))
         {
            speed = speed + 0.3f;
         }
    }
}
