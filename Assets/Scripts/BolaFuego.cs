using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaFuego : MonoBehaviour
    

{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    [SerializeField] private float fuerza;
    [SerializeField] private int rebotes;
    [SerializeField] private float   ;
    private Animator anim;

    void Bola() 
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * fuerza, ForceMode.Impulse);
        anim = GetComponent<Animator>();
    
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rebotes++;
        if (rebotes == 3)
        {
            anim.SetTrigger("Explosion");

        }
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
