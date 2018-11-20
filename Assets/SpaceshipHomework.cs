using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipHomework : MonoBehaviour
{
    public SpriteRenderer rend;
    public Transform other;
    public Color newColor;
    [Range(-720, 720)]
    public float rotationSpeed;
    public float timer;
    public float timerprint;
    public int spaceshipSpeed = 1;


    // Use this for initialization
    void Start()
    {
        //rend.color= newcolor; låter dig att sätta färg själv i unity
        rend.color = newColor;
        //rend.color = newcolor;(0, 0, 0); är där du sätter in olika värden på 0 t.ex 0, 1, 0.5f inom detta 
        //så väljer du hur stark dessa tre färger ska vara på själva produkten du skappar R=röd, G=grön, B= blå
        rend.color = new Color(1f, 0.5f, 0.3f);
        //other.position = new vector 3(3, 2, other.position.z);'

        // denna kod gör så att ditt objekt bytter position varenda gång du startar spelet. 
        transform.position = new Vector3(Random.Range(-13.48f, 14.25f), Random.Range(7.21f, -7.54f));
        spaceshipSpeed = Random.Range(2, 10);
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(spaceshipSpeed * Time.deltaTime, 0, 0);

        //Input.GetKey(KeyCode.D är när du ändrar hur din produkt rör sig när man klickar på "D" 
        if (Input.GetKey(KeyCode.D))
        {
            // transform
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
            rend.color = new Color(0, 0, 1);
        }
        //Input.GetKey(KeyCode.A är när du ändrar hur din produkt rör sig när man klickar på "A" 
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -rotationSpeed / 2 * Time.deltaTime);
            rend.color = new Color(0, 1, 0);
        }
        // denna kod gör så att när du klickar på Space så får ditt objekt en random färg
        if (Input.GetKey(KeyCode.Space))

        {
            rend.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        //Input.GetKey(KeyCode.S är när du ändrar hur din produkt rör sig när man klickar på "S" 
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(spaceshipSpeed / 2 * Time.deltaTime, 0, 0, Space.Self);
        }
        else
        {
            transform.Translate(spaceshipSpeed * Time.deltaTime, 0, 0, Space.Self);
        }

        // Denna kod gör så att du har en timer som vissar hur länge du har spelat och cokså printar ut ordet "Timer" 
        if (Time.fixedTime >= timer)
        {
            print("Timer:" + timer);
            timer = timer + 1;
        }

        //Gör så att när ditt objekt går utanför skärmen så "warpar" den till andra sidan så att den kommer in i skärmen igen. 
        //Denna är för X axel
        if (transform.position.x > 17.74f)
        {
            transform.position = new Vector3(-17.74f, transform.position.y);
        }
        //Gör så att när ditt objekt går utanför skärmen så "warpar" den till andra sidan så att den kommer in i skärmen igen. 
        //Denna är för Y axel
        if (transform.position.y > 10.05f)
        {
            transform.position = new Vector3(transform.position.x, -10.05f);
        }
        // samma sak fast på andra sidan av x och y axeln 
        if (transform.position.x < -17.74f)
        {
            transform.position = new Vector3(17.74f, transform.position.y);
        }

        if (transform.position.y < -10.05f)
        {
            transform.position = new Vector3(transform.position.x, 10.05f);
        }


    }
}