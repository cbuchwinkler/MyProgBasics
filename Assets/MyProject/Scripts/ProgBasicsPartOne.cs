using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasicsPartOne : MonoBehaviour {

   private int index = 0;
   private int step = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        CountUp(3);
        Text("myStringText");
        MultNumbers(3.3f, 1.0f);
        MixTypes("firstTry", 4, 3.9f);

    }

    private void CountUp()
    {
        index = index + step;
        Debug.Log(index);
    }

    private void CountUp(int mystep)
    {
        index = index + mystep;
        Debug.Log(index);
    }

    private void Text (string text)
    {
        Debug.Log(text);
    }

    private void MultNumbers(float first, float second)
    {
        float tmp = first * second;
        Debug.Log("MultNumbers:" + tmp);
    }

    private void MixTypes(string test, int index, float end)
    {
        Debug.Log(test + " , " + index + " , " + end);
    }
}
