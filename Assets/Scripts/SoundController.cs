using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource _audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        _audioSource = GetComponent<AudioSource>();
        if (_audioSource == null)
        {
            Debug.LogWarning("AudioSource component missing!");
        }
    }

    public void PlaySound(CollisionData collisionData)
    {

        if (collisionData == null)
        {
            Debug.LogWarning("Collision Data missing!");
            return;
        }
        if (_audioSource != null) //Checks if there is an audiosource attached to the script
        {
            _audioSource.Play();
            Debug.Log("Sound played.");
        }
        else
        {
            Debug.LogWarning("AudioSource is not assigned."); // if not send warning
        }
    }
}
