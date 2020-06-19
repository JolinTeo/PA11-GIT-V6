using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public int Score;
    public Text Score_Txt;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Obstacle");
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.90f, 3.95f), transform.position.z);

    }

    public void UpdateScore(int score)
    {
        Score += score;

        Score_Txt.text = "Score : " + Score;
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ScoreBox")
        {
            player.GetComponent<Player>().UpdateScore(10);
        }
    }
}
