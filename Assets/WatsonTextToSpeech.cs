using System.Collections;
/*using System.Collections.Generic;
using UnityEngine;
using IBM.Watson.DeveloperCloud.Services.TextToSpeech.v1;
using IBM.Watson.DeveloperCloud.DataTypes;
using IBM.Watson.DeveloperCloud.Utilities;
using IBM.Watson.DeveloperCloud.Logging;
using IBM.Watson.DeveloperCloud.Connection;
using System.IO;
using FullSerializer;

public class PlayerController : MonoBehaviour {

  	//You need to provide some string of text to say.
	private string outputText = "Hi there, it's me!";
	private TextToSpeech _textToSpeech;

	[SerializeField]
	private fsSerializer _serializer = new fsSerializer();

	void Start()
	{
		Credentials credentials2 = new Credentials(<username>, <password>, "https://stream.watsonplatform.net/text-to-speech/api");
		_textToSpeech = new TextToSpeech(credentials2);

		//Make sure you give Watson a voice type
		_textToSpeech.Voice = VoiceType.en_US_Allison;

		//send the outputText, and in the simpliest example set streaming to false as this will be a short sentence
		if(!_textToSpeech.ToSpeech(OnSynthesize, OnFail, outputText, false))
			Log.Debug("ExampleTextToSpeech.ToSpeech()", "Failed to synthesize!");
	}

  //build the audio player with successful response
	private void OnSynthesize(AudioClip clip, Dictionary<string, object> customData)
	{
		PlayClip(clip);
	}

  //you need to create an AudioObject so Unity can play the audio file sent back by Watson
	private void PlayClip(AudioClip clip)
	{
		if (Application.isPlaying && clip != null)
		{
			GameObject audioObject = new GameObject("AudioObject");
			AudioSource source = audioObject.AddComponent<AudioSource>();
			source.spatialBlend = 0.0f;
			source.loop = false; //that sounds annoying
			source.clip = clip; //the actual audio bits
			source.Play();

			Destroy(audioObject, clip.length);
		}
	}

	private void OnFail(RESTConnector.Error error, Dictionary<string, object> customData)
	{
		Log.Error("ExampleTextToSpeech.OnFail()", "Error received: {0}", error.ToString());
	}
}*/