using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject block;

    public GameObject goal;

    public GameObject gameOver;

    public GameObject vanishBox;

    public static bool isVanishBox = false;

    int vanishBoxflag = 0;

    private void OnTriggerEnter(Collider other)
    {
        isVanishBox = true;

    }

    // Start is called before the first frame update
    void Start()
    {
        isVanishBox = false;

        Screen.SetResolution(1920, 1080, false);

        int[,] map =
        {
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,2,1 },
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,1,0,1,1 },
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,1,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,1,0,0,0,0,0,0,1 },
            {1,1,1,1,1,1,5,5,5,5, 1,1,1,1,0,0,0,1,1,1, 0,1,0,1,0,1,0,1,0,1, 1,1,1,1,1,1,1,1,1,1 },
            {0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0 },
            {4,4,4,4,4,4,4,4,4,4, 4,4,4,4,4,4,4,4,4,4, 4,4,4,4,4,4,4,4,4,4, 4,4,4,4,4,4,4,4,4,4 },
        };

        Vector3 position = Vector3.zero;

        int lenY = map.GetLength(0);
        int lenX = map.GetLength(1);

        for (int y = 0;  y < 13; y++)
        {
            position.y = -y + 5;
            for (int x = 0; x < 40; x++)
            {
                position.x = x;
                if (map[y, x] == 1)
                {
                    Instantiate(block, position, Quaternion.identity);
                }
                if (map[y, x] == 2)
                {
                    goal.transform.position = position;
                }
                if (map[y,x] == 4)
                {
                    Instantiate(gameOver, position, Quaternion.identity);
                } 
                if (map[y,x] == 5 &&isVanishBox == false)
                {
                    Instantiate(vanishBox, position, Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GoalScript.isGameClear == true || GameOverScript.isGameOver == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("TitleScene");
            }
        }
    }
}
