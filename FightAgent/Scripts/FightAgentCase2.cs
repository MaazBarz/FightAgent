using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightAgentCase2 : Agent
{

    public GameObject body;
    public GameObject platform;
    Vector3 agentBodyStartPos;
    private Rigidbody RigBod;
    public float move;
    float bodyStartPos;


    void Start()
    {
        agentBodyStartPos = gameObject.transform.position;
        RigBod = GetComponent<Rigidbody>();
    }


    public override void AgentAction(float[] vectorAction, string textAction)
    {
        if (brain.brainParameters.vectorActionSpaceType == SpaceType.continuous)
        {


            float action_right = 2f * (vectorAction[0]);
            float action_left = 2f * (vectorAction[1]);

            if (action_right > 0f)
            {
                RigBod.velocity = new Vector3(move, RigBod.velocity.y);
            }
            else if (action_left < 0f)
            {
                RigBod.velocity = new Vector3(-move, RigBod.velocity.y);
            }
            else RigBod.velocity = new Vector3(0, RigBod.velocity.y);

        }

        SetReward(0.1f);

/*
        if ((Mathf.Abs(body.transform.position.x - gameObject.transform.position.x) < 2.5f))
        {
            SetReward(0.5f);
        }
*/
        if (
            (body.transform.position.y - platform.transform.position.y) < -20f ||
            Mathf.Abs(body.transform.position.x - platform.transform.position.x) > 25f ||
            Mathf.Abs(body.transform.position.z - platform.transform.position.z) > 25f
           )
        {
            Done();
            SetReward(1f);
        }

        if (
            (gameObject.transform.position.y - platform.transform.position.y) < -40f ||
            Mathf.Abs(gameObject.transform.position.x - platform.transform.position.x) > 40f ||
            Mathf.Abs(gameObject.transform.position.z - platform.transform.position.z) > 40f
           )
        {
            Done();
            SetReward(-1f);
        }


    }

    public override void CollectObservations()
    {
        AddVectorObs(gameObject.transform.position.x);
        AddVectorObs(body.transform.position.x);
        AddVectorObs(platform.transform.position.x);
        AddVectorObs((body.transform.position.x - platform.transform.position.x));
        AddVectorObs((gameObject.transform.position.x - platform.transform.position.x));
        AddVectorObs((body.transform.position.x - gameObject.transform.position.x));

    }

    public override void AgentReset()
    {
        gameObject.transform.position = new Vector3(0f, 0f, 0f);
        bodyStartPos = UnityEngine.Random.RandomRange(-20f, 20f);
        body.transform.position = new Vector3(bodyStartPos, 0, 0);
        body.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
    }

}
//----------------------------------------------------------
/* float action_xRight = 2f * (vectorAction[0]);
 if ((gameObject.transform.position.x < 10f && action_xRight > 0f))
 {
     theRB.velocity = new Vector3(move, theRB.velocity.y);
     // gameObject.transform.Translate(new Vector3(1, 0, 0))
 }
 else theRB.velocity = new Vector3(0, theRB.velocity.y);

 float action_xLeft = 2f * (vectorAction[1]);
 if ((gameObject.transform.position.x > -10f && action_xLeft < 0f))
 {
     theRB.velocity = new Vector3(-move, theRB.velocity.y);
     // gameObject.transform.Translate(new Vector3(-1, 0, 0));
 }
 else
     theRB.velocity = new Vector3(0, theRB.velocity.y);
 /* float action_xRight = vectorAction[0];
  float action_xLeft = vectorAction[1];
  if (action_xRight == 1)
  { 
  theRB.velocity = new Vector3(move, theRB.velocity.y);
  //gameObject.transform.Translate(new Vector3(1, 0, 0));
   }

  if (action_xLeft == 0 )
  {
      theRB.velocity = new Vector3(-move, theRB.velocity.y);
      //gameObject.transform.Translate(new Vector3(-1, 0, 0));
  }
  */


/*if ((body.transform.position.y - platform.transform.position.y) > -2f ||
    Mathf.Abs(body.transform.position.x - platform.transform.position.x) > 3f ||
    Mathf.Abs(body.transform.position.z - platform.transform.position.z) > 3f || 
    (gameObject.transform.position.y - platform.transform.position.y) > -2f ||
    Mathf.Abs(gameObject.transform.position.x - platform.transform.position.x) > 3f ||
    Mathf.Abs(gameObject.transform.position.z - platform.transform.position.z) > 3f)
{
    Done();
    SetReward(-1f);
}*/
//-----------------------------------------------------------------------------------------------------


