using UnityEditor;
using UnityEngine.UIElements;

namespace EditorAttributes.Editor
{
    [CustomPropertyDrawer(typeof(HideInEditModeAttribute))]
    public class HideInEditModeDrawer : PropertyDrawerBase
    {
		public override VisualElement CreatePropertyGUI(SerializedProperty property)
		{
			var root = new VisualElement();

			if (EditorApplication.isPlayingOrWillChangePlaymode)
				root.Add(CreateProperty(property));

			return root;
		}
	}
}
