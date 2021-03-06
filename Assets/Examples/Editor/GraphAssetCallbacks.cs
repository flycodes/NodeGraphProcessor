﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GraphProcessor;
using UnityEditor.Callbacks;

public class GraphAssetCallbacks
{
	[MenuItem("Assets/Create/GraphProcessor", false, 10)]
	public static void CreateGraphPorcessor()
	{
		var		obj = Selection.activeObject;
		string	path;

		if (obj == null)
			path = "Assets";
		else
			path = AssetDatabase.GetAssetPath(obj.GetInstanceID());

		var graph = ScriptableObject.CreateInstance< BaseGraph >();
		ProjectWindowUtil.CreateAsset(graph, path + "/GraphProcessor.asset");
	}

	[OnOpenAsset(0)]
	public static bool OnBaseGraphOpened(int instanceID, int line)
	{
		Debug.Log("To open the graph, use the buttons in the inspector");
		return false;
	}

}
