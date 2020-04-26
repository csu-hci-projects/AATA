using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class throwTest : MonoBehaviour
{
 private float speed;
 public Vector3 target;
 public GameObject player;
 private void Start(){
 speed = Random.Range(20,65);
 player = GameObject.FindGameObjectsWithTag("Player")[0];
 target = player.transform.position;
 target.x = target.x -5;
 target.y = Random.Range(target.y, target.y + 2);
 target.z = Random.Range(target.z -3, target.z + 3);
 }
 private void Update()
 {
 transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * (speed));
 }
}