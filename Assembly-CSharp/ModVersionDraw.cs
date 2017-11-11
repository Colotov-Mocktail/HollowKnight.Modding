﻿using GlobalEnums;
using UnityEngine;

namespace Modding
{
    /// <inheritdoc />
    /// <summary>
    /// Class to draw the version information for the mods on the main menu.
    /// </summary>
	public class ModVersionDraw : MonoBehaviour
	{
        /// <summary>
        /// Run When Gui is shown.
        /// </summary>
		public void OnGUI()
		{
			if (drawString != null && (UIManager.instance.uiState == UIState.MAIN_MENU_HOME || UIManager.instance.uiState == UIState.PAUSED))
			{
				Color backgroundColor = GUI.backgroundColor;
				Color contentColor = GUI.contentColor;
				Color color = GUI.color;
				Matrix4x4 matrix = GUI.matrix;
				GUI.backgroundColor = Color.white;
				GUI.contentColor = Color.white;
				GUI.color = Color.white;
				GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.width / 1920f, (float)Screen.height / 1080f, 1f));
				GUI.Label(new Rect(0f, 0f, 1920f, 1080f), drawString);
				GUI.backgroundColor = backgroundColor;
				GUI.contentColor = contentColor;
				GUI.color = color;
				GUI.matrix = matrix;
			}
		}
		public string drawString;
	}
}