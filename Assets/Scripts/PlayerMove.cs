using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float SpeedIdle;
    public Rigidbody myPlayer;
    public float SpeedCurrent;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SpeedCurrent = Time.deltaTime * 10000f;
            myPlayer.AddForce(transform.forward * SpeedCurrent);
        }
        
    }
}
