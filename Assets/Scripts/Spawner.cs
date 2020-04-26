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
           
            Vector3 spawnPosition = new Vector3(30, Random.Range(2,6), Random.Range(-8, 8));
            Instantiate(dodgeBalls[0], spawnPosition, gameObject.transform.rotation);
//            foreach(var obj in dodgeBalls){
//                obj.addComponent<throwTest>();
//            }
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