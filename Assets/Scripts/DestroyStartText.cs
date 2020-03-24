using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyStartText : MonoBehaviour
{
    [SerializeField] Text StartingText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Hide", 11);
    }

    void Hide()
    {
        Destroy(gameObject);
    }
}
