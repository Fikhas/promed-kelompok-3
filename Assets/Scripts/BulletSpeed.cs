using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    private float bulletSpeed = 10f;
    private float bulletTime = 2f;

    public float x = 0f;
    public float y = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("BulletDestroy", bulletTime);
        Invoke("cek", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(x, y) * bulletSpeed * Time.deltaTime);
        // if (Input.GetKeyDown(KeyCode.RightArrow))
        // {
        //     Debug.Log("Tombol kanan ditekan");
        //     transform.Translate(Vector2.right * bulletSpeed * time);
        // }
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

    private void cek()
    {
        Debug.Log(x);
        Debug.Log(y);
    }
}
