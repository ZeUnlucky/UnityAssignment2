using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    public TextMeshProUGUI CollisionText;

    public void UpdateCollisionCount(int count)
    {
        if (CollisionText != null)
        {
            CollisionText.text = "Collision Count: " + count;
            Debug.Log("Collisions: " + count);
        }
        else
        {
            Debug.LogWarning("No Collision Text Provided");
        }
    }
}
