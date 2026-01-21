using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Vector3 move = new Vector3(0f,1.0f,0f);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SwitchDirection", 0f,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += move * Time.deltaTime;
    }
    void SwitchDirection()
    {
        move *=-1;
    }
}
