using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    public TextMeshProUGUI CollisionText;
    public TextMeshProUGUI SoundEndText;

    public void UpdateCollisionCount(int count)
    {
        if (CollisionText != null)
        {
            CollisionText.text = $"Agent1 Collied {count} Times";
            Debug.Log("Collisions: " + count);
        }
        else
        {
            Debug.LogWarning("No Collision Text Provided");
        }
    }

    public void UpdateSoundText()
    {
        if (SoundEndText != null)
            SoundEndText.text = "Sound finished at least once";
    }
}
