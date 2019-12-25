using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Phsics_Ray : MonoBehaviour
{
    public Transform m_tr;
    public float distance = 10.0f;
    public RaycastHit hit;
    public LayerMask m_layermask;

 

    // Start is called before the first frame update
    void Start()
    {
        m_tr = GetComponent<Transform>();
       
    }

    private void FixedUpdate()
    {
        Ray ray = new Ray();

        ray.origin = m_tr.position;
        ray.direction = m_tr.forward;

       
        if (Physics.Raycast(transform.position, transform.forward, out hit, 8))
        {
             
            if(hit.transform.tag == "box")
            {
                Debug.Log("Box를 이용하여 Action!");


            }

        }
        
     
        onDrawRayLine();
    }
    public void onDrawRayLine()
    {
        if (hit.collider != null)
        {
            Debug.DrawLine(m_tr.position, m_tr.position + m_tr.forward * hit.distance, Color.red);
        }
        else
        {
            Debug.DrawLine(m_tr.position, m_tr.position + m_tr.forward * this.distance, Color.white);
        }
    }
  
}
