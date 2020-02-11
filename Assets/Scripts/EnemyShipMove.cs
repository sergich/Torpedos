using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipMove : MonoBehaviour
{
    //public GameObject ship;
    public float speedShip;
    public Rigidbody myShip;
    public float speedMax;
    private float speedCurrent;
    private float speed, dirY;
    private Vector3 dirMove;
    public float MoveUp, MoveDown, dirUpDown,speedY;

    // Start is called before the first frame update
    void Start()
    {
        dirY = 1f;
        myShip = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //change speed move
        speedCurrent = speedShip * Time.deltaTime;
        speed = Mathf.Clamp(speed, speedCurrent, speedMax);

        //change UpDown position
        dirUpDown = Time.deltaTime * dirY* speedY;
        if (dirY == 1f && transform.position.y > MoveUp)
        {
            dirY = -1f;
        }
        if (dirY == -1f && transform.position.y <  MoveDown)
        {
            dirY = 1f;
        }

        dirMove = new Vector3(1f, dirUpDown, 0) * speed;
        transform.position = transform.position + dirMove;
        
    }
}
