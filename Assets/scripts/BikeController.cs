using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
	//public float fuel = 1;
    //public float fuelconsumption = 0.1f;

    public float speed = 1500f;
	public float rotationSpeed = 15f;

	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;

	public Rigidbody2D rb;

	private float movement = 0f;
	private float rotation = 0f;
	private gameMaster gm;
	private Timer t;
	


	//public UnityEngine.UI.Image image;
	void Start()
	{
		gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
		t = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();


	}

    void Update()
    {
        if ((UIController.isRaceBtnDown == true) || (Input.GetKeyDown(KeyCode.RightShift)))
		{
			movement = -1 * speed;
		}
		else if((UIController.isBrakeBtnDown == true) || (Input.GetKeyDown(KeyCode.LeftShift)))
        {
			movement = 1 * speed;
		}
		else 
		{
			movement = 0;
		}
		//movement = -Input.GetAxisRaw("Vertical") * speed;
		//rotation = Input.GetAxisRaw("Horizontal");
		//image.fillAmount = fuel;
	}

	void FixedUpdate ()
	{
		
		if (movement == 0f)
		{
			backWheel.useMotor = false;
			frontWheel.useMotor = false;
		} else
		{
			backWheel.useMotor = true;
			frontWheel.useMotor = true;

			JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
			backWheel.motor = motor;
			frontWheel.motor = motor;

			rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
		}
		//fuel -= fuelconsumption * Mathf.Abs(-speed) * Time.fixedDeltaTime;
		
		AnalogueSpeedConverter.ShowSpeed(rb.velocity.magnitude, 0, 35);
    }

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.CompareTag("Coin"))
		{
			Destroy(col.gameObject);
			gm.points += 1;
		}
		if(col.CompareTag("GasCan"))
		{
			Destroy(col.gameObject);
			t.timeLeft = t.maxTime;
		}
	}
	

	
}
