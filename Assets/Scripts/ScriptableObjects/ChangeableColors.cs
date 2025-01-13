using System;
using UnityEngine;

public enum MaterialColors
{
    RED,
    GREEN,
    BLUE,
    WHITE,
    ORANGE,
    PURPLE,
    YELLOW
}

[CreateAssetMenu(fileName = "ChangeableColors", menuName = "Scriptable Objects/ChangeableColors")]
public class ChangeableColors : ScriptableObject
{
    public Material[] Materials = new Material[Enum.GetNames(typeof(MaterialColors)).Length];

    public Material GetMaterial()
    {
        if (Materials == null)
        {
            Debug.LogError("Empty Materials list");
            return null;
        }
        else if (Materials.Length == 0)
        {
            Debug.LogError("Materials list is empty");
            return null;
        }
        else
            return Materials[UnityEngine.Random.Range(0, Materials.Length)];
    }
    public Material GetMaterial(int index)
    {
        return Materials[index];
    }
}
