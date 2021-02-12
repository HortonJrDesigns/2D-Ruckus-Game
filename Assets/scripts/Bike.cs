using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
   public float fuel = 1;
   public float fuelconsumption = 0.1f;
   public Rigidbody2D bikeRigidbody;
   public Rigidbody2D backTire;
   public Rigidbody2D frontTire;
   public float speed = 20;
   public float carTorque = 10;

   public float rotationSpeed = 15f;
   private float movement;
   private float rotation;
   public UnityEngine.UI.Image image;

   void Start()
   {

   }

    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        rotation =  Input.GetAxis("Vertical");
        image.fillAmount = fuel;
    }

    private void FixedUpdate()
    {
        if(fuel > 0)
        {
        backTire.AddTorque(-movement * speed* Time.fixedDeltaTime);
        frontTire.AddTorque(-movement * speed* Time.fixedDeltaTime);
        bikeRigidbody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
        bikeRigidbody.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
        }
       fuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
    }
}
