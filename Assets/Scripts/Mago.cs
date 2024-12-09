using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : MonoBehaviour
{
    private Animator anim;
    private GameObject Bola;
    private Transform posicionspawn;

    private Transform objetivo;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LanzarBolaFuego()
    {

        
        GameObject bolaCopia = Instantiate(Bola,posicionspawn.position,Quaternion.identity);

        //Obtengo la direccion al objetico
        Vector3 direccionAObjetivo = (objetivo.position - transform.position).normalized;
         
        
        
        
    
    
    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si lo que entra en mi trigger es player
        if (collision.CompareTag("Player")) 
        {
            //Entonces , ,i objetico es aquel que entra en mi trigger
            objetivo =collision.transform;
            anim.SetBool("ataque", true);
        
        }


        if (collision.CompareTag("Player"))
        {
            objetivo =null;
            anim.SetBool("ataque", false);

        }





    }



}
