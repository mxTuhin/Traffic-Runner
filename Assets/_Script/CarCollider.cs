using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarCollider : MonoBehaviour
{
    private bool isHit=false;
    [SerializeField]private Rigidbody rb;
    private void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        if (hit.tag == "Player")
        {
            if (!isHit)
            {
                isHit = true;
                print("hit");
                hit.gameObject.GetComponent<PlayerMove>().rb.AddForce(new Vector3(10,10,10)*50);
                rb.AddForce(new Vector3(10,10,10)*50);
                StartCoroutine(timedGameOver());
                Destroy(hit.GetComponent<CharacterController>(), 0.5f);
                Destroy(gameObject, 1.0f);
            }

        }
        
        else if (hit.tag == "Enemy")
        {
            if (!isHit)
            {
                isHit = true;
                print("hit");
                hit.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(10,10,10)*50);
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(10,10,10)*50);
                StartCoroutine(timedGameOver());
                Destroy(gameObject.GetComponent<CharacterController>(), 1.0f);
                Destroy(hit, 1.0f);
            }

        }
    }

    IEnumerator timedGameOver()
    {
        yield return new WaitForSeconds(0.5f);
        GameManager.instance.gameOver = true;
    }

   
}
