using  UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic; 
using System.Linq;
public class Recoginition : MonoBehaviour
{
	KeywordRecognizer keywordRecognizer;
	Dictionary<string,System.Action> keywords = new Dictionary< string, System.Action>();

	void Start()
	{
		//initialize stuff
		keywords.Add("go", () =>
			{
				// action to be performed when this keyword is spoken
				GoCalled();
			});
		keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
		keywordRecognizer.OnPhraseRecognized += KeywordRecognizerOnPhraseRecognized;
		keywordRecognizer.Start();	
	}

	void KeywordRecognizerOnPhraseRecognized(PhraseRecognizedEventArgs args)
	{
		System.Action keywordAction;
		// if the keyword recognized is in our dictionary, call that Action.
		if (keywords.TryGetValue(args.text, out keywordAction))
		{
			keywordAction.Invoke();
		}   
	}

	void GoCalled()
	{
		print("You just said GO");
	}
}