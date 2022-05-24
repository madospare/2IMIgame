using UnityEngine.Audio;
using System;
using UnityEngine;

// Audio Manager that controls music and soundFX in the game

public class AudioManager : MonoBehaviour
{

    // Sound class reference
    public Sound[] sounds;

    public static AudioManager instance;

    void Awake()
    {

        // There should only be 1 Audio Manager and despite switching scenes,
        // the Audio Manager won't be destroyed
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        // For adding and changing sound source, volume, pitch and looping through the Unity UI
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

    }

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("MainMenuTheme"); // Plays the Menu Music
    }

    // Function for playing audio
    public void Play(string name) // All audio have names
    {

        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            // If there is no audio with specified name, an error will show up
            Debug.LogWarning("Error while trying to play audio clip. Probably typo in audio manager. " + name + " wasn't found.");
            return;
        }

        s.source.Play(); // Plays the audio

    }

    // Function for stoping audio
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Error while trying to play audio clip. Probalby typo in audio manager. " + name + " wasn't found.");
            return;
        }

        s.source.Stop(); // Stops audio

    }

}