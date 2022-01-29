using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    [Header("Cinemachine Controllers")]
    public CinemachineSmoothPath cmPath;

    
    
    [Header("Game Over Assets")]
    public bool gameOver;

    [SerializeField] private GameObject gameOverCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        gameOver = false;
        gameOverCanvas.SetActive(false);
        createSmoothPath();

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            gameOverCanvas.SetActive(true);
            if (Input.GetButton("Fire1"))
            {
                SceneManager.LoadScene("PlayScene");
            }
        }
        
    }

    void createSmoothPath()
    {
        cmPath.m_Waypoints = new CinemachineSmoothPath.Waypoint[10];
        for (int i = 0; i < cmPath.m_Waypoints.Length; ++i)
        {
            cmPath.m_Waypoints[i] = new CinemachineSmoothPath.Waypoint();
            cmPath.m_Waypoints[i].position = new Vector3(Random.Range(0,100), 0, 0);
        }
    }
}
