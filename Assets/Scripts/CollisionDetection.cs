using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D enter)
    {
        Debug.Log("anjay nabrak cuy");
        Destroy(gameObject);
        if (enter.CompareTag("Enemy"))
        {
            Destroy(enter.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D stay)
    {
        Debug.Log("anjay nabrak cuy");
    }

    private void OnTriggerExit2D(Collider2D exit)
    {
        Debug.Log("anjay nabrak cuy");
    }
}
