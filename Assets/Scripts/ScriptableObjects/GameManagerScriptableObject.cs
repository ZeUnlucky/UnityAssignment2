using UnityEngine;

public enum PrefabColors
{
    BLUE,
    RED,
    GREEN
}

[CreateAssetMenu(fileName = "GameManagerScriptableObject", menuName = "Scriptable Objects/GameManagerScriptableObject")]
public class GameManagerScriptableObject : ScriptableObject
{
    public Object[] Prefabs;

    public Object GetRandomObject()
    {
        if (Prefabs == null)
        {
            Debug.LogError("Empty Prefabs list");
            return null;
        }
        else if (Prefabs.Length == 0)
        {
            Debug.LogError("Prefabs list is empty");
            return null;
        }
        else
            return Prefabs[Random.Range(0, Prefabs.Length)];
    }

    public Object GetPrefabByEnum(PrefabColors color)
    {
        return Prefabs[(int)color];
    }
    public Object GetPrefabByIndex(int index)
    {
        return Prefabs[index];
    }
}
