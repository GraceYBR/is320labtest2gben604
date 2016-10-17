/*@Author: Grace Benedek Rooney
 *@UPI: gben604
 *@Subject: IS 320, Test 2
 */


using UnityEngine;
using Pathfinding.Serialization.JsonFx; //make sure you include this using
using System;

public class Sketch : MonoBehaviour {
    public GameObject treeObject;
	public string _WebsiteURL = "http://is320test2gben604.azurewebsites.net/tables/TreeSurvey?zumo-api-version=2.0.0";

    void Start () {
		//get request using my url
		string jsonResponse = Request.GET(_WebsiteURL);

        //Just in case something went wrong with the request we check the reponse and exit if there is no response.
        if (string.IsNullOrEmpty(jsonResponse))
        {
            return;
        }

		//deserialises the json into objects
		TreeSurvey[] survey = JsonReader.Deserialize<TreeSurvey[]>(jsonResponse);

		//int numberOfTrees = survey.Length; //used for debugging purposes

        //Loops through each item and places a gameobject for it
		//Places it at the X, Y, Z coordinates specified
		//Makes the text of the object the id of the tree
        foreach (TreeSurvey tree in survey)
        {
			GameObject aTree = (GameObject)Instantiate(treeObject);
			aTree.transform.position = new Vector3 (float.Parse(tree.X), float.Parse(tree.Y), float.Parse(tree.Z));
			aTree.GetComponentInChildren<TextMesh>().text = tree.TreeID;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
