/*@Author: Grace Benedek Rooney
 *@UPI: gben604
 *@Subject: IS 320, Test 2
 *@Purpose: To make actions when an item is selected
 */

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections;

public class OnClick : MonoBehaviour {

	public string pointData = "";
	private bool showText = false;
	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 MousePos = Input.mousePosition;
			{
				//I have assumed that you want the mouse point
				pointData = "x: " + MousePos.x.ToString()+", y: " + MousePos.y.ToString()+ ", z: " + MousePos.z.ToString();
			}
		}
	}

	void OnMouseDown()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GetComponent<Renderer>().material.color = Color.green;
			transform.localScale += new Vector3(0.025F, 0.025F, 0.025F);

		}
		if (!showText)
		{
			showText = true;
		}
	}

	void OnGUI()
	{
		if (showText)
		{
			GUIStyle guistyle = new GUIStyle();
			guistyle.fontSize = 30;
			//didn't get time to finish getting the color of font to change
			guistyle.normal.textColor = Color.white;
			GUI.Label(new Rect(50, 50, 3000, 1000), pointData, guistyle);
		}

	}

	
}



