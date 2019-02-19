using UnityEngine;
using System.Collections;

public class CubeRotation : MonoBehaviour {

    public float RotateSpe = 90;
  
    // Use this for initialization
    void Start () {
    
       
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Slide);
        //transform.Rotate(RotateSpe * Time.deltaTime,0,0);

        //transform.Rotate(0, 25 * Time.deltaTime, 0, Space.Self);

        transform.Rotate(Vector3.down, RotateSpe* Time.deltaTime);
    }

 

    //Invoked when a submit button is clicked.
    public void ChangeSpend(float Speed)
    {
        //Displays the value of the slider in the console.
        this.RotateSpe = Speed;
    }

    //public void Change(float Speed)
    //{
    //    //Displays the value of the slider in the console.
    //    this.RotateSpe = Speed;
    //}
}
