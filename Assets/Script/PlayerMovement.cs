using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 screenPoint;
    Vector3 offset;
    Vector3 realPoint;
    Vector3 realPosition;

    GameMaterial game ;


    public float MoveRange = 10f;
    public float Speed = 10f;
    public void Start()
    {
        game = GetComponent<GameMaterial>();
    }
    private void Update()
    {

        if (game.isGameStarted)
        {
            Camera.main.transform.Translate(transform.forward * Time.deltaTime * Speed, Space.World);
            transform.Translate(transform.forward * Time.deltaTime * Speed, Space.World);
         

            //İleri Hareket

            if (Input.GetMouseButton(0))
            {
                //Kamera ileri Hareket


                //Eğer range içindeyse yana harekete et
                if (transform.position.x > -MoveRange && transform.position.x < MoveRange)
                {
                    AxisXMovement();
                }

            }
        }
    }
    void AxisXMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Tıklanmayla gerçek konum arasındaki fark hesaplanıp offsete ekleniyor

            screenPoint = Camera.main.WorldToScreenPoint(transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));


        }
        if (Input.GetMouseButton(0))
        {

            realPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            realPosition = Camera.main.ScreenToWorldPoint(realPoint) + offset;

            if (realPosition.x > -MoveRange && realPosition.x < MoveRange)
            {
                // X ekseninde hareket için positionda sadece x parametresi değiştirildi 
                transform.position = new Vector3(realPosition.x, transform.position.y, transform.position.z);

            }


        }

    }
   
}