using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class SoundEndEvent : UnityEvent { }
public class SoundController : MonoBehaviour
{
    public SoundEndEvent OnSoundEndEvent;
    private AudioSource _audioSource;
    private bool isPlaying = false;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        _audioSource = GetComponent<AudioSource>();
        if (_audioSource == null)
        {
            Debug.LogWarning("AudioSource component missing!");
        }
        if (OnSoundEndEvent == null)
            OnSoundEndEvent = new SoundEndEvent();
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
            isPlaying = true;
            _audioSource.Play();
            Debug.Log("Sound played.");
        }
        else
        {
            Debug.LogWarning("AudioSource is not assigned."); // if not send warning
        }
    }
    private void Update()
    {
        if (isPlaying)
        {
            if (!_audioSource.isPlaying)
            {
                isPlaying = false;
                OnSoundEndEvent.Invoke();
            }
        }
    }
}
