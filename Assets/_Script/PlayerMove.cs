using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    private CharacterController _characterController;
    private CinemachineDollyCart cmDolly;

    private Vector3 velocity;
    

    private float horizontalMovement;

    private float runSpeed = 20.0f;

    public Rigidbody rb;
    
    
    
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        cmDolly = GetComponent<CinemachineDollyCart>();
        horizontalMovement = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.gameOver) return;
        
        if (gameObject.transform.position.y <= -50)
        {
            GameManager.instance.gameOver = true;
        }
        
        if (Input.GetButton("Fire1"))
        {
            // _characterController.Move(new Vector3(horizontalMovement*runSpeed, 0, 0) * Time.deltaTime);
            cmDolly.m_Speed = 20.0f;
        }
        else
        {
            cmDolly.m_Speed = 0.0f;
        }
        
        

    }
}
