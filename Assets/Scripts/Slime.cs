using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Slime : MonoBehaviour
{
    
    [SerializeField] private Transform puntoA;
    [SerializeField] private Transform puntoB;
    [SerializeField] private float velocidad;
    [SerializeField] private SpriteRenderer mover;
    [SerializeField] private float danho;


    [SerializeField] private Transform destinoActual;

    // Start is called before the first frame update
    void Start()
     //Marco como destino 
    {   
        destinoActual = puntoB;
        
    }

    // Update is called once per frame
    //Nuestra posicion se actualiza por cada frame para ir al destino actual
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destinoActual.position, 5 * Time.deltaTime);

        if (transform.position == puntoA.position)
        { 
        
             destinoActual =puntoB;
             mover.flipX = false;
            
        
        
        }
        if (transform.position == puntoB.position)
        { 
        
             destinoActual =puntoA;
             mover.flipX = true;



        }
        
        
        
        
        




    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            collision.gameObject.GetComponet<Player>().RecibirDanho(danho);
        
        }



    }




}   
