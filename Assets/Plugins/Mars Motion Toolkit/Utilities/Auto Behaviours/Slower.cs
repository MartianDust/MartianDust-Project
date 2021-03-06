﻿using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Slower:
// • slows the velocity of the attached rigidbody by the set speed, so long as the dependencies setting is met
//   · a toggle setting controls whether this slowing is enabled
[RequireComponent(typeof(Rigidbody))]
public class Slower : AutoBehaviour<Slower>
{
	// variables //

	
	// settings //

	[Tooltip("whether slowing is currently enabled")]
	public bool slowingEnabled = true;

	[Tooltip("the speed by which to reduce the attached rigidbody's velocity")]
	public float speedReduction = 666666f;

	#if Mars_MOTION_TOOLKIT
	[Tooltip("the dependencies by which to determine whether to slow the attached rigidbody")]
	[ReorderableList]
	public Dependency[] slowingDependencies;
	#endif




	// updating //
	
	
	// at each physics update: //
	protected virtual void FixedUpdate()
		// slow the attached rigidbody if slowing is currently enabled //
		=>	slowSpeedBy
			(
				speedReduction,
				(
					#if Mars_MOTION_TOOLKIT
					slowingDependencies.areMet() &&
					#endif
					slowingEnabled
				)
			);
}