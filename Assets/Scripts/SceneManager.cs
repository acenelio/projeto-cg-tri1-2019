using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
    private Transform Tape = null; 
    private Vector3 Speed = new Vector3(-2f, 0f, 0f);
    
    void Awake() 
    {
        Assert.IsNotNull(Tape); 
    }

    void Start()
    {        
    }

    void Update()
    {
        Tape.position = Tape.position + Speed * Time.deltaTime;
    }
}
