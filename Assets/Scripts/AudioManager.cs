using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{

    // Start is called before the first frame update
    public Sound[] sounds;
    void Awake()
    {
       foreach(Sound s in sounds)
        {
           s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        } 
    }

    void Start()
    {
        Play("Background");
        Play("A");
        Play1("B");
        Play2("C");
        Play3("D");
        Play4("E");
        Play5("F");
        Play6("G");
        Play7("H");
        Play8("I");
        Play9("J");
        Play10("K");
        Play11("L");
        Play12("M");
        Play13("N");
        Play14("O");
        Play15("P");
        Play16("Q");
        Play17("R");
        Play18("S");
        Play19("T");
        Play20("U");
        Play21("V");
        Play22("W");
        Play23("X");
        Play24("Y");
        Play25("Z");
       
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(2.0f);
    }

    public void Play1(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(12.0f);
    }

    public void Play2(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(32.0f);
    }
    public void Play3(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(42.0f);
    }
    public void Play4(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(52.0f);
    }
    public void Play5(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(62.0f);
    }
    public void Play6(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(72.0f);
    }
    public void Play7(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(82.0f);
    }
    public void Play8(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(92.0f);
    }
    public void Play9(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(102.0f);
    }
    public void Play10(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(122.0f);
    }
    public void Play11(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(132.0f);
    }
    public void Play12(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(142.0f);
    }
    public void Play13(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(152.0f);
    }
    public void Play14(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(162.0f);
    }
    public void Play15(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(172.0f);
    }
    public void Play16(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(182.0f);
    }
    public void Play17(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(192.0f);
    }
    public void Play18(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(202.0f);
    }
    public void Play19(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(222.0f);
    }
    public void Play20(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(232.0f);
    }
    public void Play21(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(242.0f);
    }
    public void Play22(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(252.0f);
    }
    public void Play23(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(262.0f);
    }
    public void Play24(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(272.0f);
    }
    public void Play25(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(282.0f);
    }
}
