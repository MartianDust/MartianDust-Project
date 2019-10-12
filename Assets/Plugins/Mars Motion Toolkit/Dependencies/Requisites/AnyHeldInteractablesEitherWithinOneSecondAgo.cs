using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Any Held Interactables Either Within One Second Ago", menuName = "Mars Motion/Dependency Requisites/Any Held Interactables Either Within One Second Ago")]
public class AnyHeldInteractablesEitherWithinOneSecondAgo : DependencyRequisite
{
	// methods //

	
	// method: determine the (boolean) state of this Dependency Requisite //
	public override bool state()
	{
		return HandHoldingTracker.anyHeldInteractablesEitherWithin(1f);
	}
}