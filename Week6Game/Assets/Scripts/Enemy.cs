using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    // Start is called before the first frame update
    public Transform target;
    public float moveSpeed = 5f;

    void Start()
    {
        if (target == null && GameObject.FindWithTag("Player")) //if target is null and there exissts a GameObject tagged 'player' in the scene then...
        {
            target = GameObject.FindWithTag("Player").transform; //finds Player Gameobject, gets its Transform component, stores Transform in target
        }
    }
   

    void Update()
    {
        if (target == null) return; // if there's no target, stop here and do nothing

        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step); //move target towards target at constant speed
    }
}
