using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class player : MonoBehaviour
{

public Rigidbody2D myRigidBody;
public Vector2 velocity;

public float speed;
  private void Update()
  {
    if(Input.GetKey(KeyCode.LeftArrow))
    {
      // myRigidBody.MovePosition(myRigidBody.position - velocity * Time.deltaTime);
      myRigidBody.velocity = new Vector2(-speed, myRigidBody.velocity.y);
    }
  
  else if(Input.GetKey(KeyCode.RightArrow))

  {
      // myRigidBody.MovePosition(myRigidBody.position + velocity * Time.deltaTime);
      myRigidBody.velocity = new Vector2(speed, myRigidBody.velocity.y);
  }

}
}