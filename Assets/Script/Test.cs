using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] float _rotatespeed;
    //private Transform _transform = default;
    public float _rotateZ = 0f;
    bool _isSwing = false;
    bool _stop = false;
    
    // Start is called before the first frame update
    private void Awake()
    {
      
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V ) )
        {
            _stop = true;
        }
        if ( _stop == false )
        {
            if (_isSwing == false)
            {
                if (_rotateZ < 90)
                {
                    _rotateZ += Time.deltaTime + _rotatespeed;
                    transform.localEulerAngles = new(transform.localEulerAngles.x, transform.localEulerAngles.y, _rotateZ);
                }
                else
                {
                    _isSwing = true;
                }
            }
            if (_isSwing == true)
            {
                if (_rotateZ > -90)
                {
                    _rotateZ -= Time.deltaTime + _rotatespeed;
                    transform.localEulerAngles = new(transform.localEulerAngles.x, transform.localEulerAngles.y, _rotateZ);
                }
                else
                {
                    _isSwing = false;
                }
            }
        }
        


        }
}
