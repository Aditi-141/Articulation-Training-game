using UnityEngine;
using System.Collections;
using SpeechLib;
using System.Xml;
using System.IO;

/**************************************************************************************
 * ******************Text to Speech for Windows SAPI *********************************
 * ************************************************************************************
 * v 1.0 - 01/01/2016
 * Marco Martinelli 
 * marco.m@gamesource.it
 * 
 * 
 * Tested on Windows 10, SAPI 4.0 | Windows 8.1
 * More info on www.finalmarco.com
/*************************************************************************************/



public class TTSUnityWin : MonoBehaviour {

	private SpVoice voice;
	


/// CODE FOR LOAD XML OR OTHER TEXT FILES IN THE SISTEM FROM THE FOLDER RESOURCE

	string loadXMLStandalone (string fileName) {
		
		string path  = Path.Combine("Resources", fileName);
		path = Path.Combine (Application.dataPath, path);
		Debug.Log ("Path:  " + path);
		StreamReader streamReader = new StreamReader (path);
		string streamString = streamReader.ReadToEnd();
		Debug.Log ("STREAM XML STRING: " + streamString);
		return streamString;
	}
///




	//Resources.Load('builtIn.xml') as Texture;

/// PRINT ON SCREEN SAPI VOICES INSTALLED IN THE OS
	void OnGUI() {
	
		SpObjectTokenCategory tokenCat = new SpObjectTokenCategory();
		tokenCat.SetId(SpeechLib.SpeechStringConstants.SpeechCategoryVoices, false);
		ISpeechObjectTokens tokens = tokenCat.EnumerateTokens(null, null);
		
		int n = 0;
		foreach (SpObjectToken item in tokens)
		{
				GUILayout.Label( "Voice"+ n +" ---> "+ item.GetDescription(0));
			    n ++;
		}
		GUILayout.Label( "There are "+ n +" SAPI voices installed in your OS | Press SPACE for start TEST");
	
		//Set a voice (if not using XML)
	//	voice.Voice = (tokens.Item (3)); // Comment this line if you use XML parser for choice voices, force a voice over the def one.

	}



	string BuiltAsset = "";

	void Start(){
    //print (loadXMLStandalone ("fottiti.xml"));	

		voice = new SpVoice();
		//TextAsset txt = (TextAsset)Resources.Load("readme", typeof(TextAsset));
	//	TextAsset txt = (TextAsset)Resources.Load("builtIn.xml", typeof(XmlText));
	//	TextAsset textXML = (TextAsset)Resources.Load("builtIn", typeof(TextAsset));
	//	BuiltAsset = textXML.text;
		//TextAsset textAsset = (TextAsset) Resources.Load("builtIn.xml");  

	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			/***************************************************
			 * Userful resources for Country codes and SAPI XML fomat
			 * https://msdn.microsoft.com/en-us/library/ms723602(v=vs.85).aspx
			 * https://msdn.microsoft.com/en-us/library/ms717077(v=vs.85).aspx
			 * https://msdn.microsoft.com/en-us/library/windows/desktop/dd318693(v=vs.85).aspx
			 * https://msdn.microsoft.com/en-us/library/jj127898.aspx
			/**************************************************/
		
			voice.Volume = 100; // Volume (no xml)
			voice.Rate = 0 ;  //   Rate (no xml)



			voice.Speak("<speak version='1.0' xmlns='http://www.w3.org/2001/10/synthesis' xml:lang='en-US'>"
			            +"English One, two, three"
			            +"<p xml:lang='it-IT'> Italiano uno, due, tre</p>"
			            +"<p xml:lang='ja-JP'>日本語　一二三、終わります。 </p>"
			            + "</speak>",
			            SpeechVoiceSpeakFlags.SVSFlagsAsync|SpeechVoiceSpeakFlags.SVSFIsXML);


			voice.Speak("NOW XML SAPI TEST", SpeechVoiceSpeakFlags.SVSFlagsAsync);
			
			voice.Speak("Spelling: Chiaroscurist, <spell>Chiaroscurist.</spell>Normal Volume,<volume level='50'>Low volume</volume>", SpeechVoiceSpeakFlags.SVSFlagsAsync|SpeechVoiceSpeakFlags.SVSFIsXML);
			voice.Speak("<lang langid='410'>Frase in italiano</lang>", SpeechVoiceSpeakFlags.SVSFlagsAsync|SpeechVoiceSpeakFlags.SVSFIsXML);


			voice.Speak("ESTERNAL FILE READING TEST", SpeechVoiceSpeakFlags.SVSFlagsAsync);

		//	voice.Speak(loadXMLStandalone ("builtIn.xml"), SpeechVoiceSpeakFlags.SVSFlagsAsync); 
		//	voice.Speak(BuiltAsset, SpeechVoiceSpeakFlags.SVSFlagsAsync); 
			voice.Speak(loadXMLStandalone ("external.xml"), SpeechVoiceSpeakFlags.SVSFlagsAsync);//must in the resource folder after build
		
			voice.Speak("End of the test, enjoy this code", SpeechVoiceSpeakFlags.SVSFlagsAsync);

		
		}
		if (Input.GetKeyDown(KeyCode.P))
		{
			voice.Pause();
			
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			voice.Resume();
		}
		
		//TEST PER ANDROID
		/*	if (Input.GetTouch)
		{

			voice.Resume();
		}*/
		
		
	}
}


