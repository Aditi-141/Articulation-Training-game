using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using UnityEngine.UI;
using SpeechLib;
using System.Xml;
using System.IO;
public class Player : MonoBehaviour {

   
    
    public static int count;
    private SpVoice voice;

    public Sound[] file;


    Collider col;
    public Text results;
    protected string word;
 
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    void Start() 
    {
        
      
    }

    private void Update()
    {

       
           


        



        actions.Add("A", a);
        actions.Add("B", b);
        actions.Add("C", c);
        actions.Add("D", d);
        actions.Add("E", e);
        actions.Add("F", f);
        actions.Add("G", g);
        actions.Add("H", h);
        actions.Add("I", i);
        actions.Add("J", j);
        actions.Add("K", k);
        actions.Add("L", l);
        actions.Add("M", m);
        actions.Add("N", n);
        actions.Add("O", o);
        actions.Add("P", p);
        actions.Add("Q", q);
        actions.Add("R", r);
        actions.Add("S", s);
        actions.Add("T", t);
        actions.Add("U", u);
        actions.Add("V", v);
        actions.Add("W", w);
        actions.Add("X", x);
        actions.Add("Y", y);
        actions.Add("Z", z);
        

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray(),ConfidenceLevel.Low);
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


    private void a()
    {
        
            
    }

    private void b()
    {
      
    }

    private void c()
    {
       
    }

    private void d()
    {
    }

    private void e()
    {
    }

    private void f()
    {
    }

    private void g()
    {
    }

    private void h()
    {
    }

    private void i()
    {
    }

    private void j()
    {
    }

    private void k()
    {
    }

    private void l()
    {
    }

    private void m()
    {
    }

    private void n()
    {
    }

    private void o()
    {
    }

    private void p()
    {
       
    }

    private void q()
    {
    }

    private void r()
    {
    }

    private void s()
    {
    }

    private void t()
    {
    }

    private void u()
    {
    }

    private void v()
    {
    }

    private void w()
    {
    }

    private void x()
    {
    }

    private void y()
    {
    }

    private void z()
    {
    }


    public void Audio(string name)
    {
        Sound s = Array.Find(file, sound => sound.name == name);
        s.source.Play();
    }
   





    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "A" || col.gameObject.tag == "B" || col.gameObject.tag == "C" || col.gameObject.tag == "D" || col.gameObject.tag == "E" || col.gameObject.tag == "F" || col.gameObject.tag == "G" || col.gameObject.tag == "H" || col.gameObject.tag == "I" || col.gameObject.tag == "J" || col.gameObject.tag == "K" || col.gameObject.tag == "L" || col.gameObject.tag == "M" || col.gameObject.tag == "N" || col.gameObject.tag == "O" || col.gameObject.tag == "P" || col.gameObject.tag == "Q" || col.gameObject.tag == "R" || col.gameObject.tag == "S" || col.gameObject.tag == "T" || col.gameObject.tag == "U" || col.gameObject.tag == "V" || col.gameObject.tag == "W" || col.gameObject.tag == "X" || col.gameObject.tag == "Y" || col.gameObject.tag == "Z")
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
