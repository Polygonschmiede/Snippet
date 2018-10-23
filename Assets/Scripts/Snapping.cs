using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapping : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	/**
	 * Snapping Zone
	 *
	 *	objToSnapp = Objekt das an einer Pos. einrasten soll.
	 * 	TagetSnappZone = Einraste Punkt
	 *
	 * 
	 */
	public void SnappObjToZone(GameObject objToSnapp, GameObject TagetSnappZone)
	{
		//Objekt wird dem Einrastepunkt untergeordnet (In der Hierachie)
		objToSnapp.transform.parent = TagetSnappZone.transform;

		//Physik ausmachen
		objToSnapp.GetComponent<Rigidbody>().useGravity = false;
		objToSnapp.GetComponent<Rigidbody>().isKinematic = true;
		
		//Physik löschen (muss nicht)
		Destroy(objToSnapp.GetComponent<Rigidbody>());
		Destroy(objToSnapp.GetComponent<BoxCollider>());
		
		//Koordinaten erstellen
		Vector3 pos = new Vector3(0.0f, 0.0f, 0.0f);
		Quaternion rot = TagetSnappZone.transform.rotation;
		
		//Debug.Log(objToSnapp.transform.position);

		//Hier Local nicht Worldposition!!!
		objToSnapp.transform.localPosition = pos;
		objToSnapp.transform.localRotation = rot;
	}
	
}
