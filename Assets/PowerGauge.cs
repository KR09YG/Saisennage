using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerGauge : MonoBehaviour
{
    [SerializeField] public float _gauge = 0f;
    [SerializeField] public float _gaugespeed = 1f;
    [SerializeField] Text text;
    bool _gaugebool;
    bool chack = true;
    Bullet _gameObject;
    Slider _slider;
    // Start is called before the first frame update
    void Start()
    {
        _gameObject = GameObject.Find("Circle (2)").GetComponent<Bullet>();
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
        _slider.value = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_gauge);
        _slider.value = _gauge /100;
        text.text = _gauge.ToString("F2");
        _gameObject._gagepower = _gauge;
        if (chack)
        {
            if (_gaugebool)
            {
                if (_gauge < 100)
                {
                    _gauge += Time.deltaTime * _gaugespeed;
                }
                else
                {
                    _gaugebool = false;
                }
            }
            if (_gaugebool == false)
            {
                if (_gauge > 0)
                {
                    _gauge = 0;
                }
                else
                {
                    _gaugebool = true;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.K) )
        {
            chack = false;
        }
    }
}
