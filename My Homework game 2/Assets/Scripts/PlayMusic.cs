using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class PlayMusic : MonoBehaviour {
	
	public AudioClip[] musicClips;
	public AudioMixerSnapshot volumeDown;
	public AudioMixerSnapshot volumeUp;	

	public void FadeUp(float fadeTime)
	{
		volumeUp.TransitionTo (fadeTime);
	}
	
	public void FadeDown(float fadeTime)
	{		
		volumeDown.TransitionTo (fadeTime);
	}
}
