using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genarater : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.A) )
        {
            Instantiate( _bullet,transform.position, transform.rotation);
        }
    }
}
