using UnityEngine;
using System.Collections;

public class Slider : MonoBehaviour {

    private Slider Slid;
	// Use this for initialization
	void Start () {
        Slid = GetComponent<Slider>();
        //Slid.
	}
	
	// Update is called once per frame
	void Update () {
        //Slid.value
	}

    public void SubmitSliderSetting() {
        Debug.Log("Value:");
    }
}
