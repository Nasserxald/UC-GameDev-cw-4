using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x < 5f)
            {
                transform.position = transform.position + new Vector3(5f, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x > -5f)
            {
                transform.position = transform.position + new Vector3(-5f, 0, 0);
            }
        }    
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemies")
            SceneManager.LoadScene("SampleScene");
    }
}
