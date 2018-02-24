using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackObject : MonoBehaviour {
    public Vector2 nearest;
    public Vector2[] towerPos;
    public Vector2 unitPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        nearest=findNearest();
	}

    Vector2 findNearest()
    {
        Vector2 test = new Vector2(10000, 10000);
        foreach(Vector2 vect in towerPos)
        {
            if (Vector2.Distance(unitPos, vect) < Vector2.Distance(unitPos, test))
                test = vect;
        }
        return test;
    }
}
