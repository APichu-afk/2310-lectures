﻿//(c) Samantha Stahlke 2020
//Created for INFR 2310.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//You don't need to worry about understanding this file for this class.
//If you are curious:
//It hooks into Unity's scene GUI update and calls some custom utilities to
//draw a path in the Editor scene.
[CustomEditor(typeof(BezierMover_COMPLETED))]
public class BezierEditor_COMPLETED : Editor
{
    private const int samples = 8;

    private void OnEnable()
    {
        SceneView.duringSceneGui += GUICallback;
    }

    private void GUICallback(SceneView sceneview)
    {
        BezierMover_COMPLETED obj = target as BezierMover_COMPLETED;

        if (obj == null)
            return;

        PathDrawUtility.DrawBezierPath(obj.points, 
                                       BezierDemo_COMPLETED.Bezier3, 
                                       samples);
    }
}
