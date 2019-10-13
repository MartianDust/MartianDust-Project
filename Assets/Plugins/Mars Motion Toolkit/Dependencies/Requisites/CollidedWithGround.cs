using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Collided With Ground", menuName = "Mars Motion/Dependency Requisites/Collided With Ground")]
public class CcollidedWithGround : DependencyRequisite
{
	// methods //

	
	// method: determine the (boolean) state of this Dependency Requisite //
	public override bool state()
	{
		return TerrainResponse.collidedWithGround();
	}
}