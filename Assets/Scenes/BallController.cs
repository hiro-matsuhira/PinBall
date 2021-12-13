using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    int score = 0;

    private float visiblePosZ = -6.5f;


    private GameObject gameoverText;


    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {

        this.gameoverText = GameObject.Find("GameOverText");

        this.scoreText = GameObject.Find("ScoreText");
        
    }

    // Update is called once per frame
    void Update()
    {


        if (this.transform.position.z <this.visiblePosZ)
        {

            this.gameoverText.GetComponent<Text>().text = "Game Over";

        }
        
       
    }

    private void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.tag=="SmallStarTag")
        {

            score += 10;

            this.scoreText.GetComponent<Text>().text = score + "point";
        }
        
        if (other.gameObject.tag=="LargeStarTag")
        {

            score += 15;

            this.scoreText.GetComponent<Text>().text = score + "point";
        }

        if (other.gameObject.tag=="SmallCloudTag")
        {

            score += 20;

            this.scoreText.GetComponent<Text>().text = score + "point";
        }

        if (other.gameObject.tag=="LargeCioudTag")
        {

            score += 50;

            this.scoreText.GetComponent<Text>().text = score + "point";
        }
    }

    
    
        
    

}
