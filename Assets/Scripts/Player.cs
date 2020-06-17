using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    private Rigidbody thisRigidbody = null;
    public float Force = 250;
    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        thisRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisRigidbody.AddForce(Vector3.up * Force);
            thisAnimation.Play();
        }
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(1);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="Enemy")
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(1);
        }
    }
}
