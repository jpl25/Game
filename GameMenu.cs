using UnityEditor;
using UnityEngine;
using System.Collections;

namespace GAME
{
	public class GameMenu : MonoBehaviour
	{
		
		void OnGUI (){
			Event evnt = Event.current;
			Rect contextRect = new Rect (10, 10, 100, 100);
			if (evnt.type == EventType.ContextClick) {
				Vector2 mousePos = evnt.mousePosition;
				if (contextRect.Contains (mousePos)) {
					EditorUtility.DisplayPopupMenu(new Rect(mousePos.x, mousePos.y, 0, 0), "Assets/", null);
					evnt.Use ();
				}
			}

		}
	}
}

