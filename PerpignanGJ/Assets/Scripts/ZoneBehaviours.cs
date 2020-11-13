using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneBehaviours : MonoBehaviour
{

    public enum ObjectNeeded
    {
        None
    }


    [SerializeField] private float decreaseSpeed = .5f;
    [SerializeField] private float zoneLifeTime = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(zoneLifeTime > 0)
        {
            zoneLifeTime -= decreaseSpeed * Time.deltaTime;
        }
        else
        {
            Debug.Log("Death");
        }
    }
}
