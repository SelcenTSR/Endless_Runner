using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMaterial : MonoBehaviour
{
    //[SerializeField] private Material Material;
    public GameObject gameOver;
    public Transform Ground;
    PlayerMovement player;
    public Transform Ground2;
    public Transform Ground1;
    public GameObject coins;
    public ParticleSystem particle,particleCoin;
    public GameObject start;
    public bool isGameStarted = false;
    public Text coin_count;
   public int coin=0;

    public void Start()
    {
        player = GetComponent<PlayerMovement>();
    }

    public void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && !isGameStarted)
        {
           
            isGameStarted = true;
            start.SetActive(false);
        }
       
       

    }
    public void tryagain()
    {
    
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Scenes/1");
    }
    public void exit()
    {
        Application.Quit();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ObsacleCube")
        {
            particle.transform.position = transform.position;
            gameOver.SetActive(true);
            isGameStarted = false;
            particle.Play();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Obstacle" && isGameStarted)
        {

            particle.transform.position = transform.position;
            gameOver.SetActive(true);
            isGameStarted = false;
            particle.Play();


        }
        if (other.transform.tag == "Coin")
        {
            particleCoin.transform.position = transform.position;
            other.gameObject.SetActive(false);
            coin++;
            particleCoin.Play();
            coin_count.text = "HEART : " + coin.ToString();
           
           
        }

        if (other.transform.tag == "Doublecoin")
        {
            Debug.Log("DCOİNDEYİİM");
                coin = coin +5;
            coin_count.text = "HEART : " + (coin).ToString();
        }
        if (other.transform.tag == "Decreasecoin")
        {
            coin = coin-5;
            coin_count.text = "HEART : " + (coin).ToString();
        }

        if (other.tag == "engel")
        {
            Ground.position = new Vector3(Ground2.transform.position.x, Ground2.transform.position.y, Ground2.transform.position.z +150.0f);
            Debug.Log(Ground.position + "ALOOOOO");
        }
        if (other.tag == "engel2")
        {

            Ground1.position = new Vector3(Ground.transform.position.x, Ground.transform.position.y, Ground.transform.position.z + 150.0f);
            Debug.Log(Ground1.position + "ALOOOO");
        }
        if (other.tag == "engel3")
        {

            Ground2.position = new Vector3(Ground1.transform.position.x, Ground1.transform.position.y, Ground1.transform.position.z + 150.0f);
            Debug.Log(Ground1.position + "ALOOOO");
        }
    }

}
