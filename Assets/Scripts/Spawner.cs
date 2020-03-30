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
           
            Vector3 spawnPosition = new Vector3(29, Random.Range(2,10), Random.Range(-27,27));

            Instantiate(dodgeBalls[0], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnWait);
            if (GameObject.FindGameObjectsWithTag("Ball").Length >= 10)
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