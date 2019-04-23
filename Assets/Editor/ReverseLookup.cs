using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ReverseLookup : EditorWindow {

	private string filter;

	[MenuItem("Tools/ReverseLookup")]
	private static void Init() {
		GetWindow<ReverseLookup>();
	}

	private void OnGUI() {
		GUILayout.BeginHorizontal();
		GUILayout.Label("Filter:", GUILayout.Width(45));
		GUI.SetNextControlName( "filterField" );
        filter = GUILayout.TextField( filter, "SearchTextField", GUILayout.Width( 120 ) );
        GUI.FocusControl( "filterField" );
        GUI.enabled = !string.IsNullOrEmpty( filter );
        if ( GUILayout.Button( "Clear", "SearchCancelButton" ) )
        {
            filter = string.Empty;
        }
		GUILayout.Label("\n" + filter, GUILayout.Width(120));
        GUI.enabled = true;
        GUILayout.EndHorizontal();
	}
}