using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilotUser : APilot {

	void Update ()
	{
		thrusting = Input.GetAxis("Fire1");
		turning = Input.GetAxis("Horizontal");
	}
}
