using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        Ability ability = new ExampleA();
        sr.sprite = ability.icon;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
