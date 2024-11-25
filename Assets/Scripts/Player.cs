using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject pies;
    [SerializeField] private float radiopies;
    [SerializeField] private LayerMask queEssuelo;

    // Start is called before the first frame update
    void Start()
    {
        rb =GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void FixedUpdate()
    //{
    //    rb.AddForce(new Vector2(hInput,0)* fuerzmovimiento)
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
