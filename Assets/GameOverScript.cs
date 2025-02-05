using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverText;

    public static bool isGameOver = false;

    private void OnTriggerEnter(Collider other)
    {
        gameOverText.SetActive(true);

        isGameOver = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
