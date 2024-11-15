using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColissionDete : MonoBehaviour
{
    public GameObject Bullet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        // Simple for now, can add instead something like health = health - 1, if health = 0 {destroy game object}
        if(other.isTrigger == false){
            // if the box collider has it's "Is Trigger" option unselected
            // the bullet will destroy itself, and *hopefully* not destroy the wall it collided with.
            Destroy(Bullet);
            Destroy(Bullet.gameObject);
        }
        else {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
