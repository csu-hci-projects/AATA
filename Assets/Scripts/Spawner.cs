using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] dodgeBalls;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;

    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
           
            Vector3 spawnPosition = new Vector3(30, Random.Range(1,8), Random.Range(0, 13));
            Instantiate(dodgeBalls[0], spawnPosition, gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnWait);
            if (GameObject.FindGameObjectsWithTag("Ball").Length >= 20)
            {
                stop = true;
                destroyBall();
            }
        }
    }

    void destroyBall()
    {
        var balls = GameObject.FindGameObjectsWithTag("Ball");
        foreach (var clone in balls)
        {
            Destroy(clone);
        }
    }
}