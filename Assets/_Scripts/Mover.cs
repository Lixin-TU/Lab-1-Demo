using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Mover : MonoBehaviour
{
    public Vector3 TargetPosition;
    public float Speed;
    
    // Start is called before the first frame update
    void Start()
    {
        TargetPosition = new Vector3(x:0,y:0,z:0);   
    }

    // Update is called once per frame
    void Update()
    {
        TargetPosition = TargetPosition + Time.deltaTime * Speed * new Vector3(x:0.1f, y:0, z:0);
        this.gameObject.transform.position = TargetPosition;
    }
}
