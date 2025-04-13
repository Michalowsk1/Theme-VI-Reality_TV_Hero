using UnityEngine;

public class LeftArrowScript : MonoBehaviour
{
    [SerializeField] GameObject arrow;

    [SerializeField] Rigidbody2D arrowrb;

    int arrowScore;

    public static int overallScore;

    bool red;
    bool yellow;
    bool green;
    bool wrong;

    bool touching;


    void Start()
    {
        arrowrb = GetComponent<Rigidbody2D>();
        red = false;
        yellow = false;
        green = false;
        wrong = false;

        overallScore = 0;

        touching = false;
    }

    void Update()
    {

        ScoreAdder();
        arrowrb.gravityScale = Dance.gravScale;
    }



    void ScoreAdder()
    {
        if (red)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && touching)
            {
                Dance.score += arrowScore;
                arrowScore = 0;
                Destroy(this.arrow);
                red = false;
                touching=false;
            }
        }

        if (yellow)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && touching)
            {
                Dance.score += arrowScore;
                arrowScore = 0;
                Destroy(this.arrow);
                yellow = false;
                touching = false;
            }
        }

        if (green)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && touching)
            {
                Dance.score += arrowScore;
                arrowScore = 0;
                Destroy(this.arrow);
                green = false;
                touching = false;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag == "Red")
            {
                touching = true;
                arrowScore = 10;
                red = true;
            }

            else if (collision.gameObject.tag == "Yellow")
            {
                 touching = true;
                 arrowScore = 20;
                 yellow = true;
            }

            else if (collision.gameObject.tag == "Green")
            {
                touching = true;
                arrowScore = 30;
                green = true;
            }

            else if (collision.gameObject.tag == "Destroy")
            {
                Dance.score -= 30;
                Destroy(arrow);
            }
    }
}
