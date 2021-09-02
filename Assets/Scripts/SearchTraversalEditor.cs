using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SearchTraversal))]
public class SearchTraversalEditor : Editor
{
    // Start is called before the first frame update
    public override void OnInspectorGUI()
    {
        if(EditorApplication.isPlaying)
            DrawDefaultInspector();

        SearchTraversal script = (SearchTraversal)target;
        if(GUILayout.Button("Clear Lights"))
        {
            script.lightOut();
        }
    }
}
