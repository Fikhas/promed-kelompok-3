using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    private float bulletSpeed = 10f;
    private float bulletTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("BulletDestroy", bulletTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D enter)
    {
        if (enter.CompareTag("Enemy"))
        {
            Destroy(enter.gameObject);
            Debug.Log("anjay nabrak cuy");
        }
    }

    private void BulletDestroy()
    {
        Destroy(gameObject);
    }
}
