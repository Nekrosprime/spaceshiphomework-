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

    // Use this for initialization
    void Start()
    {
        //rend.color= newcolor; låter dig att sätta färg själv i unity
        rend.color = newColor;
        //rend.color = newcolor;(0, 0, 0); är där du sätter in olika värden på 0 t.ex 0, 1, 0.5f inom detta 
        //så väljer du hur stark dessa tre färger ska vara på själva produkten du skappar R=röd, G=grön, B= blå
        rend.color = new Color(1f, 0.5f, 0.3f);
        //other.position = new vector 3(3, 2, other.position.z);  
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey(KeyCode.D är när du ändrar hur din produkt rör sig när man klickar på "D" 
        if (Input.GetKey(KeyCode.D))
        {
            // transform
            transform.Rotate(
                0f,
                0f,
                -rotationSpeed * Time.deltaTime);
            rend.color = new Color(0, 0, 1);
        }
        //Input.GetKey(KeyCode.D är när du ändrar hur din produkt rör sig när man klickar på "A" 
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
            rend.color = new Color(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-4 * Time.deltaTime, 0, 0);
        }


        transform.Translate(5 * Time.deltaTime, 0, 0);
    }

}
