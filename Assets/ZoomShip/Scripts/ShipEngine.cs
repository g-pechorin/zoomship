using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(APilot))]
public class ShipEngine : MonoBehaviour
{
	public APilot pilot {get; private set;}
	
	void Start ()
	{
		pilot = GetComponent<APilot>();	
		Debug.Assert(null != pilot);
	}
	
	public EngineDesign engineDesign;

	void FixedUpdate ()
	{
		transform.localPosition += Time.fixedDeltaTime * transform.forward * pilot.thrusting * engineDesign.speed;
		transform.localRotation *= Quaternion.Euler(0, Time.fixedDeltaTime * pilot.turning *engineDesign.spin, 0);
	}
}
