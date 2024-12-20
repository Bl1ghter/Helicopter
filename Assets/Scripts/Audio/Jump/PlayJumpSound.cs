using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayJumpSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] _jumpClips;

    private AudioSource _jumpAudio;

    private void Start()
    {
        _jumpAudio = GetComponent<AudioSource>();
    }

    public void PlaySound(int soundToPlay)
    {
        _jumpAudio.clip = _jumpClips[soundToPlay];
        _jumpAudio.Play();
    } 
}
