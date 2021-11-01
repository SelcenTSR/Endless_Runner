using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clon : MonoBehaviour
{
    GameMaterial game;
    public GameObject coin;
    public ParticleSystem particle;
    public GameObject obstacle;
    public GameObject obstacles;
    public GameObject obs1, obs, cube;
    public GameObject doublecoin, decreasecoin;
    float xr_coordinate = 5.0f;
    float xl_coordinate = -5.0f;
  

    void Start()
    {
        game = GetComponent<GameMaterial>();
        InvokeRepeating("clon", 0, 0.6f);
       InvokeRepeating("clonobs", 0, 0.7f);
       

    }

    public void clon()
    {
        int random = Random.Range(0, 100);
        if (random > 0 && random < 100)
        {
            if (game.isGameStarted)
            {
                klonla(coin, 1.0f);
            }


        }

        
    }
    //public void cloncoinC()
    //{
    //    int random = Random.Range(0, 100);
    //    if (random > 70 && random < 100)
    //    {
    //        if (game.isGameStarted)
    //        {
    //            coinP(doublecoin, 1.0f);
    //        }

    //    }
    //    if (random > 40 && random < 70)
    //    {
    //        coinP(decreasecoin, 1.0f);
    //    }
    //}
        public void clonobs()
    {
        int random = Random.Range(0, 100);
        if (random > 70 && random < 100)
        {
            if (game.isGameStarted)
            {
                clonObstacle(obstacle, 1.0f);
            }


        }
        if (random > 40 && random < 70)
        {
            if (game.isGameStarted)
            {
                clonSphere(obstacles, 1.0f);
            }

        }
        //if(random > 0 && random < 10)
        //{
        //    if (game.isGameStarted)
        //    {
        //        clonCubes(obs, 15f);
        //        clonCubes(obs1, -14f);
        //        clonCubes(cube, -7f);
        //    }
        //}
        if(random >0 && random < 10)
        {
            if (game.isGameStarted)
            {
                coinP(doublecoin, 1.0f);
            }
        }
        if (random > 10 && random < 20)
        {
            if (game.isGameStarted)
            {
                coinP(decreasecoin, 1.0f);
            }
        }
        Debug.Log(random + "SAYIII");
    }
    void Update()
    {

    }
    public void klonla(GameObject objectt, float y)
    {
        GameObject clon = Instantiate(objectt);
        clon.SetActive(true);
        int random = Random.Range(0, 100);
        if (random > 50)
        {
            clon.transform.position = new Vector3(xr_coordinate, y, (transform.position.z + 20.0f));
            Debug.Log(clon.transform.position);
        }
        if (random < 50)
        {
            clon.transform.position = new Vector3(xl_coordinate, y, (transform.position.z + 20.0f));
            Debug.Log(clon.transform.position);
        }
     
     
    }
    public void clonObstacle(GameObject objectt, float y)
    {
        GameObject clon = Instantiate(objectt);
        clon.SetActive(true);
        clon.transform.position = new Vector3(-10, y, (transform.position.z + 35.0f));
        clon.GetComponent<Animator>().speed = Random.Range(0.75f, 1.25f);

    }
    public void clonSphere(GameObject objectt, float y)
    {
        GameObject clon = Instantiate(objectt);
        clon.SetActive(true);
        clon.transform.position = new Vector3(-12, y, (transform.position.z + 35.0f));
        clon.GetComponent<Animator>().speed = Random.Range(0.75f, 1.25f);

    }
    public void coinP(GameObject objectt, float y)
    {
        GameObject clon = Instantiate(objectt);
        clon.SetActive(true);
        int random = Random.Range(0, 100);
        if (random > 50)
        {
            clon.transform.position = new Vector3(xr_coordinate, y, (transform.position.z + 40.0f));
           
        }
        if (random < 50)
        {
            clon.transform.position = new Vector3(xl_coordinate, y, (transform.position.z + 40.0f));
           
        }
    }
    //public void clonCubes(GameObject objectt, float y)
    //{
    //    GameObject clon = Instantiate(objectt);
    //    clon.SetActive(true);
    //    clon.transform.position = new Vector3(0, y, (transform.position.z + 35.0f));
      
    //}
}
