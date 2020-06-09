using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using UnityEngine.UI;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
  
    private float speed = 5.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;
    public static int count;

    Collider col;
 

    private float animationDuration = 0.0f;

    public AudioSource collect;
    public Text results;
    protected string word;


    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time<animationDuration)
        {
            controller.Move(Vector3.forward* speed * Time.deltaTime);
            return;
        }
        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        controller.Move((Vector3.forward*speed) * Time.deltaTime);

       actions.Add("Left", Left);
        actions.Add("A", Up);
        actions.Add("C", Down);
        actions.Add("right", Right);

        moveVector.y = verticalVelocity;

        moveVector.z = speed;

       controller.Move(moveVector * Time.deltaTime);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }
    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();

        word = speech.text;
        results.text = "You said: <b>" + word + "</b>";
        
    }

    private void Right()
    {
        transform.Translate(0, 0, 0);
    }
    private void Left()
    {
        transform.Translate(0, 0, 0);
    }
    private void Up()
    {
        transform.Translate(0, 1, 0);
    }
    private void Down()
    {
        transform.Translate(0, -1, 0);
    }

    void OnTriggerEnter(Collider col)
    {
            if (col.gameObject.tag == "right"|| col.gameObject.tag == "Left")
        {
            if (word == col.gameObject.tag)
            {
                score.scoreValue += 1;
                count = count + 1;
                Destroy(col.gameObject);
            }

            }
    }
}
