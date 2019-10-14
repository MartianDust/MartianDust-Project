using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Shaders: provides shader constants and properties //
public static class Shaders
{
	#region Unity
	public const string standard_Address = "Standard";
	public static Shader standard_IfInAwakeOrStart => standard_Address.asShaderAddressToShader_IfInAwakeOrStart();
	#endregion Unity
	
	#region Mars Motion Toolkit
	#if Mars_MOTION_TOOLKIT
	public const string addressPrefixForMarsMotionToolkit = MarsMotion.toolkitName+"/";
	public const string penetratingStroke_Address = addressPrefixForMarsMotionToolkit+"Penetrating Stroke";
	public static Shader penetratingStroke_IfInAwakeOrStart => penetratingStroke_Address.asShaderAddressToShader_IfInAwakeOrStart();
	#endif
	#endregion Mars Motion Toolkit
}