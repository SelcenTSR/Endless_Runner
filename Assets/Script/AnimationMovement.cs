using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMovement : MonoBehaviour
{
    public Transform gameObject;
    public Collider üst,alt;

    public bool isHit;
    void Start()
    {
        
    }

    void Update()
    {
        if (isHit == false)
        {
            gameObject.Translate(Vector3.up * 0.5f);

        }
        else
        {
            gameObject.Translate(Vector3.up*-1 * 0.5f);
            Debug.Log("HSHFHHFHFHF");
            
        }


    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "obs1")
        {
            isHit = false;
            üst.enabled = true;
            alt.enabled = false;
           
        }
       else if (collision.transform.tag == "obs")
        {
            isHit = true;
            üst.enabled = false;
            alt.enabled = true;
          
          
        }
    }
}
//public void OnTriggerEnter(Collider collision)
//{
//    if (collision.transform.tag == "obs1")
//    {
//        isHit = true;
//        üst.enabled = false;
//        alt.enabled = true;
//        Debug.Log("ÇARPTIM");
//    }
//    if (collision.transform.tag == "obs")
//    {
//        isHit = false;
//        üst.enabled = true;
//        alt.enabled = false;
//        Debug.Log("ÇARPTIM1");

//    }
//}