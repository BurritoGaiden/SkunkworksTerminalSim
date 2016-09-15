using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
 
public class AutoType : MonoBehaviour {
 
	public float letterPause = 0.2f;
	public AudioClip sound;
    //public int i;
	public string[] message;
    public int[] waitBetweenLines;
    public bool[] boolsMofos;
 
	// Use this for initialization
	void Start () {
        //message = this.GetComponent<Text>().text;
        if (message[0] == null)
        {
            message[0] = "Hey Asshole ";
        }
		//this.GetComponent<Text>().text = "dalksdfj;adskfj";
		StartCoroutine(TypeText ());
	}

    void heh() {
        //int poo = message.GetLength();

    }

	IEnumerator TypeText () {
        for (int i = 0; i <= message.Length; i++)
        {
            //i = 0;
            foreach (char letter in message[i].ToCharArray())
            {
                this.GetComponent<Text>().text += letter;
                //this.GetComponent<Text>().text += "\n";


                //if (sound)
                //audio.PlayOneShot (sound);
                yield return 0;
                letterPause = Random.Range(.1f, .22f);
                if (i == 4) {
                    letterPause = .02f;
                }
                yield return new WaitForSeconds(letterPause);
            }
            this.GetComponent<Text>().text += "\n";
            yield return new WaitForSeconds(2);
            print("poop" + i.ToString());
            //i++;
        } 
	}
}