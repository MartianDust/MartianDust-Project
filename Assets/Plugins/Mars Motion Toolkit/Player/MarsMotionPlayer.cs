using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

// Mars Motion Player:
// • singleton for the Mars Motion Player
// • provides methods for the Mars Motion Player
public class MarsMotionPlayer : SingletonBehaviour<MarsMotionPlayer>
{
	// methods //

	
	public static void setPositionForMovingBodyPositionTo(Vector3 targetPosition)
		=> displacePositionBy(MarsMotionBody.displacementForMovingPositionTo(targetPosition));
	public static void setPositionForMovingBodyPositionTo(RaycastHit raycastHit)
		=> setPositionForMovingBodyPositionTo(raycastHit.position());
}