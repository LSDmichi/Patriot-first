using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Create_User : MonoBehaviour {

    [SerializeField]
    Text user_name;

    [SerializeField]
    GameObject create_btn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!string.IsNullOrEmpty(user_name.text))
        {
            create_btn.SetActive(true);
        }
        else
        {
            create_btn.SetActive(false);
        }
	}
}
