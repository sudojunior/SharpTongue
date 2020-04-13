using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Thanks to Cole Gilbert for help creating this script
    public static Vector2 playerPosition { get; set; }
    public static List<Vector2> enemyPositions { get; set; }
    public static List<int> enemyHealth { get; set; }
    public static bool pickedUpSword { get; set; }
    public static bool pickedUpCrossbow { get; set; }
    bool firstScene = true;
    int lastScene;
    public GameObject playerPrefab;


    void OnEnable()
    {
        if(GameObject.FindGameObjectsWithTag("GameManager").Length <= 1)
        {
            playerPosition = new Vector2(0, 0);
            enemyPositions = new List<Vector2> { };
            enemyHealth = new List<int> { };
            pickedUpSword = false;
            SceneManager.sceneLoaded += OnSceneLoaded;
            DontDestroyOnLoad(gameObject);
            
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Last Scene: " + lastScene);
        Debug.Log("Build Index: " + scene.buildIndex);

        if (lastScene == scene.buildIndex && scene.buildIndex < 2 && !firstScene)
        {
            GetComponent<Player>().healthBar = GameObject.Find("HealthBar").GetComponent<HealthBar>();
            GameObject.FindGameObjectWithTag("Player").transform.position = playerPosition;
            GameObject.Find("HealthBar").GetComponent<HealthBar>().SetHealth(GetComponent<Player>().currentHealth);
            if (enemyPositions.Count > 0)
            {
                transform.position = enemyPositions[0];
                Enemy[] enemies;
                enemies = FindObjectsOfType<Enemy>();

                foreach (Enemy em in enemies)
                {
                    if (enemyPositions.Count > 0)
                    {
                        em.currentHealth = enemyHealth[0];
                        em.transform.position = enemyPositions[0];
                        enemyPositions.Remove(enemyPositions[0]);
                        enemyHealth.Remove(enemyHealth[0]);
                    }
                    else
                    {
                        Destroy(em.gameObject);
                    }
                }
            }

            else
            {
                Enemy[] enemies;
                enemies = FindObjectsOfType<Enemy>();

                foreach (Enemy em in enemies)
                {
                    Destroy(em.gameObject);
                }
            }
            lastScene = scene.buildIndex;
        }
        else if (scene.buildIndex < 2 && !firstScene)
        {
            GetComponent<Player>().healthBar = GameObject.Find("HealthBar").GetComponent<HealthBar>();
            GameObject.FindGameObjectWithTag("Player").transform.position = Vector2.zero;
            GameObject.Find("HealthBar").GetComponent<HealthBar>().SetHealth(GetComponent<Player>().currentHealth);
            lastScene = scene.buildIndex;
        }

        if (firstScene)
        {
            Instantiate(playerPrefab);
            GetComponent<Player>().healthBar = GameObject.Find("HealthBar").GetComponent<HealthBar>();
            GameObject.FindGameObjectWithTag("Player").transform.position = playerPosition;
            GameObject.Find("HealthBar").GetComponent<HealthBar>().SetHealth(GetComponent<Player>().currentHealth);
            firstScene = false;
            lastScene = scene.buildIndex;
        }
    }
}
