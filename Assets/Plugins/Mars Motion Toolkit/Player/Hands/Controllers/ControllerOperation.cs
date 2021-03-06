﻿using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controller Operation:
// • a controller operation is used to determine controller operational status based on:
//   · controller handedness
//   · an array of inputs
//   · an array of inputtednesses
//   · an array of states of being
//   · arrays of dependencies
// • represents a Controller Operation as a scriptable object, with the aforementioned settings
// • provides methods for determining information about how controller operations are currently operated
[CreateAssetMenu(fileName = "New Controller Operation", menuName = "Mars Motion/Controller Operation")]
public class ControllerOperation : ScriptableObject
{
	#region variables


	[InfoBox("the controller handedness (determining which controllers to check operation of) – infinite handedness results in always being operated; neither handedness is the simplest way to have this controller operation never be operated")]
	public Controller.Handedness handedness = Default.controllerHandedness;
	[InfoBox("whether to return the left versus the right controller as the first operated controller when operating without any controllers operating (only relevant when handedness is infinite)")]
	public bool fallbackToLeftVersusRight = Default.leftnessVersusRightness;
	[InfoBox("the controller inputs (to check operation upon)")]
	[ReorderableList]
	public Controller.Input[] inputs;
	[InfoBox("the controller inputtednesses (to check operation by)")]
	[ReorderableList]
	public Controller.Inputtedness[] inputtednesses;
	[InfoBox("the states of being (to check operation at)")]
	[ReorderableList]
	public Beingness[] beingnesses;
	[InfoBox("the dependencies to check thoroughly (by which to condition this operation where each dependency is necessary)")]
	[ReorderableList]
	public Dependency[] dependenciesThorough;
	[InfoBox("the dependencies to check partially (by which to condition this operation where any of the dependencies is necessary)")]
	[ReorderableList]
	public Dependency[] dependenciesPartial;
	#endregion variables




	#region properties


	// the controller to fallback to as the first operated controller when operating without any controllers operating (when handedness is infinite) //
	public Controller fallbackController => fallbackToLeftVersusRight ? Controller.left : Controller.right;
	#endregion properties




	#region methods


	// method: determine whether this operation's dependencies are met //
	public bool dependenciesMet()
		=> (dependenciesThorough.areMet() && dependenciesPartial.arePartiallyMetWhereEmptyIsTrue());

	// method: determine whether this operation is currently operated //
	public bool operated()
		=> Controller.operated(this);
	// method: determine whether this operation is currently operated at the given state of being (first requires this operation to accept either the given state of being, or no state of being) //
	public bool operated(Beingness beingness)
		=> Controller.operated(this, beingness);
	// method: determine whether this operation is currently operated at the becoming state of being (first requires this operation to accept either the becoming state of being, or no state of being) //
	public bool operatedBecomingly()
		=> operated(Beingness.becoming);
	// method: determine whether this operation is currently operated at the being state of being (first requires this operation to accept either the being state of being, or no state of being) //
	public bool operatedBeingly()
		=> operated(Beingness.being);
	// method: determine whether this operation is currently operated at the unbecoming state of being (first requires this operation to accept either the unbecoming state of being, or no state of being) //
	public bool operatedUnbecomingly()
		=> operated(Beingness.unbecoming);

	// method: determine the set of controllers for which this operation is currently operated //
	public HashSet<Controller> operatedControllers()
		=> Controller.operatedControllers(this);
	// method: determine the set of controllers for which this operation is currently operated at the given state of being (first requires this operation to accept either the given state of being, or no state of being) //
	public HashSet<Controller> operatedControllers(Beingness beingness)
		=> Controller.operatedControllers(this, beingness);
	// method: determine the set of controllers for which this operation is currently operated at the becoming state of being (first requires this operation to accept either the becoming state of being, or no state of being) //
	public HashSet<Controller> operatedBecominglyControllers()
		=> operatedControllers(Beingness.becoming);
	// method: determine the set of controllers for which this operation is currently operated at the being state of being (first requires this operation to accept either the being state of being, or no state of being) //
	public HashSet<Controller> operatedBeinglyControllers()
		=> operatedControllers(Beingness.being);
	// method: determine the set of controllers for which this operation is currently operated at the unbecoming state of being (first requires this operation to accept either the unbecoming state of being, or no state of being) //
	public HashSet<Controller> operatedUnbecominglyControllers()
		=> operatedControllers(Beingness.unbecoming);
	#endregion methods
}