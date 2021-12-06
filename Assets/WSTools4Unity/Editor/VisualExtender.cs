using Unity.VisualScripting;
using UnityEditor;

public class VisualExtender
{
    [MenuItem("VisualScript/Update")]
    public static void ShowWindow()
    {
        UnitBase.Update();
    }
}