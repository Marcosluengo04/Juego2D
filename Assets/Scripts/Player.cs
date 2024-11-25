using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject pies;
    [SerializeField] private int fuerzaMovimiento;
    [SerializeField] private int fuerzaSalto;
    [SerializeField] private float radiopies;
    [SerializeField] private LayerMask queEssuelo;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animacion;
    float hInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");

        if (hInput != 0) 
        {
            anim
        
        }
    }
    //private void FixedUpdate()
    //{
    //    rb.AddForce(new Vector2(hInput, 0) * fuerzMovimiento)
    //}

    private bool EnSuelo() 
    {
        //"coll" representa el collider detectado
        Collider coll = Physics2D.OverlapCircle(pies.position, radiopies, queEssuelo );

        if (coll != null)
        {
            return true;



        }
        else 
        { 
        
            return false;
        
        }
        
        


    }
    //  Codigo para pintar 
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(pies.position , radiopies);
    }



}
