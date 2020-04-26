using UnityEngine;
public class throwTest : MonoBehaviour
{
 [SerializeField] private Vector3 target = new Vector3(3, 2, 6);
 [SerializeField] private float speed = 100000;
 private void Update()
 {
 transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * (10*speed));
 }
}