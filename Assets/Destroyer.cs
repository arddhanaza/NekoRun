using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
    
    void DestroyOnHit(Collider2D other)
    {
        Destroy(other.gameObject);
    } 
	
}
