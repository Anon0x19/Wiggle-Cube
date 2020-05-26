//Made by Anon0x19
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

        // void Start is called when play button is pressed

        // void Update called for every frame

        //We marked this as "Fixed"Update because we are messing around with the objects physics and
        //Unit prefers to mess with physics while using FixedUpdate rather than Update
        void FixedUpdate()
        {
            //Add a forward force through Unity without the need of changing the source code it self
            rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Add a force of 2000 on the z axis, layout= X, Y, Z

            if ( Input.GetKey("d") )
            {
                //On executed if condition is met
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if ( Input.GetKey("a") )
            {
                //On executed if condition is met
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
			
			//If the value of the operand is below -1 it will run the .EndGame variable, which will restart the operands position to 0, 0, 0
			if (rb.position.y < -1f)
			{
				FindObjectOfType<GameManager>().EndGame();
			}
			
			//If the value of the operand is above 1.5, the operands position will be set to 0, 0, 0 and it will carry the same process as above
			if (rb.position.y > 1.5f)
			{
				FindObjectOfType<GameManager>().EndGame();
			}
        }
  }
