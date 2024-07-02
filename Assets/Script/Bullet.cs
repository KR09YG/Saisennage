using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    PowerGauge powerGauge;
    [SerializeField] public float _gagepower = 0;
    Rigidbody2D rb;
    bool gage = true;
    [SerializeField] float _movespeed = 10;
    [SerializeField] float _gagespeed = 1;
    bool pulas = true;
    // Start is called before the first frame update
    void Start()
    {
        powerGauge = GameObject.Find("Power").GetComponent<PowerGauge>();
        _gagepower = powerGauge._gauge;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * _gagepower;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
