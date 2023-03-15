using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject peluru;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Instantiate(peluru, gameObject.transform.position, Quaternion.identity);
            peluru.GetComponent<BulletSpeed>().x = 1f;
            peluru.GetComponent<BulletSpeed>().y = 0f;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Instantiate(peluru, gameObject.transform.position, Quaternion.identity);
            peluru.GetComponent<BulletSpeed>().x = -1f;
            peluru.GetComponent<BulletSpeed>().y = 0f;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Instantiate(peluru, gameObject.transform.position, Quaternion.identity);
            peluru.GetComponent<BulletSpeed>().y = 1f;
            peluru.GetComponent<BulletSpeed>().x = 0f;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Instantiate(peluru, gameObject.transform.position, Quaternion.identity);
            peluru.GetComponent<BulletSpeed>().y = -1f;
            peluru.GetComponent<BulletSpeed>().x = 0f;
        }
    }
}
