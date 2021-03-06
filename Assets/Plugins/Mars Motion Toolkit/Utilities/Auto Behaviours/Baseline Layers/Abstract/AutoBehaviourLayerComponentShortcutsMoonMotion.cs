﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

// Auto Behaviour Layer Component Shortcuts Mars Motion:
// #auto #shortcuts #tracking
// • provides this behaviour with automatically-connected state and methods (recursively) of its game object's and its children game objects' Mars Motion components
public abstract class AutoBehaviourLayerComponentShortcutsMarsMotion<AutoBehaviourT> :
					AutoBehaviourLayerComponentShortcutsUnity<AutoBehaviourT>
						where AutoBehaviourT : AutoBehaviour<AutoBehaviourT>
{
	#region Utilities




	#region Auto Behaviours


	#region Trackings

	#region miscellaneous
	public float timeAwake => trackTimeOfAwake.timeAwake;
	public float lightIntensityAwake => trackLightIntensityAtAwake.lightIntensityAwake;
	public bool awake => trackAwake.awake;
	public Color colorAwake => trackColorAtAwake.colorAwake;
	#endregion miscellaneous

	#region Collideds
	public HashSet<Collider> collidedColliders => trackCollideds.collidedColliders;
	public HashSet<GameObject> collidedObjects => collidedColliders.uniqueObjects();
	public HashSet<Rigidbody> collidedRigidbodies => collidedColliders.uniqueCorrespondingRigidbodies();
	#endregion Collideds

	#region Components
	public List<CapsuleCollider> capsuleCollidersAwake => trackCapsuleCollidersAtAwake.capsuleCollidersAwake;
	#endregion Components

	#region Transformations
	public Vector3 localScaleAwake => trackLocalScaleAtAwake.localScaleAwake;
	public float localScaleXAwake => trackLocalScaleXAtAwake.localScaleXAwake;
	public float localScaleYAwake => trackLocalScaleYAtAwake.localScaleYAwake;
	public float localScaleZAwake => trackLocalScaleZAtAwake.localScaleZAwake;
	public Vector3 positionAwake => trackPositionAtAwake.positionAwake;
	public float positionXAwake => trackPositionXAtAwake.positionXAwake;
	public float positionYAwake => trackPositionYAtAwake.positionYAwake;
	public float positionZAwake => trackPositionZAtAwake.positionZAwake;
	public Quaternion rotationAwake => trackRotationAtAwake.rotationAwake;
	public float localPositionZAwake => trackLocalPositionZAtAwake.localPositionZAwake;
	public float localPositionYAwake => trackLocalPositionYAtAwake.localPositionYAwake;
	public float eulerAngleYAwake => trackEulerAngleYAtAwake.eulerAngleYAwake;
	public float localPositionXAwake => trackLocalPositionXAtAwake.localPositionXAwake;
	public Vector3 localPositionAwake => trackLocalPositionAtAwake.localPositionAwake;
	public float localEulerAngleZAwake => trackLocalEulerAngleZAtAwake.localEulerAngleZAwake;
	public float localEulerAngleYAwake => trackLocalEulerAngleYAtAwake.localEulerAngleYAwake;
	public float localEulerAngleXAwake => trackLocalEulerAngleXAtAwake.localEulerAngleXAwake;
	public Vector3 localEulerAnglesAwake => trackLocalEulerAnglesAtAwake.localEulerAnglesAwake;
	public float eulerAngleZAwake => trackEulerAngleZAtAwake.eulerAngleZAwake;
	public float eulerAngleXAwake => trackEulerAngleXAtAwake.eulerAngleXAwake;
	public Vector3 eulerAnglesAwake => trackEulerAnglesAtAwake.eulerAnglesAwake;
	public Quaternion localRotationAwake => trackLocalRotationAtAwake.localRotationAwake;
	#endregion Transformations
	#endregion Trackings
	#endregion Auto Behaviours
	#endregion Utilities
}