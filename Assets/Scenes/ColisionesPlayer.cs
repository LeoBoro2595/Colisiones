using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathWall")
        {
            transform.position = new Vector3(4.5f, 1.5f, -3.66f);
        }
    }
}
