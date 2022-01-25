using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    private CharacterController _characterController;

    private Vector3 velocity;
    

    private float horizontalMovement;

    private float runSpeed = 3.0f;
    public float runFastSpeed;
    public float runSlowSpeed;
    
    
    void Start()
    {

        
        _characterController = GetComponent<CharacterController>();
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
        transform.forward = new Vector3(horizontalMovement, 0, Mathf.Abs(horizontalMovement) - 1);
        if (Input.GetButtonDown("Fire1"))
        {
            _characterController.Move(new Vector3(horizontalMovement*runSpeed, 0, 0) * Time.deltaTime);
        }
        
        

    }
}
