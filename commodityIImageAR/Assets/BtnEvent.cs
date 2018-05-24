using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnEvent : MonoBehaviour {

    

	public void OnOpenURL(string URL)
    {
        Application.OpenURL(URL);
    }
}
