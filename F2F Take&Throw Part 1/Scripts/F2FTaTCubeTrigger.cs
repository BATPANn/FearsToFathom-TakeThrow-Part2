using UnityEngine;

public class F2FTaTCubeTrigger : MonoBehaviour
{

    public F2FTakeAndThrowYoutube TakeScript;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Throwable"))
        {


            if(TakeScript.HandIsFull == false)
            {


                Debug.Log("Cube is in the cube");


            }

            


        }



    }


}
