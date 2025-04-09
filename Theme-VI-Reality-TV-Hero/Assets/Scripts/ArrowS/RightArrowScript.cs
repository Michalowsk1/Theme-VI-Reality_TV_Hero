using UnityEngine;

public class RightArrowScript : MonoBehaviour
{
    [SerializeField] GameObject arrow;

    [SerializeField] Rigidbody2D arrowrb;

    int arrowScore;

    public static int overallScore;

    bool red;
    bool yellow;
    bool green;
    bool wrong;

    void Start()
    {
        arrowrb = GetComponent<Rigidbody2D>();
        red = false;
        yellow = false;
        green = false;
        wrong = false;

        overallScore = 0;
    }

    void Update()
    {

        ScoreAdder();
        FallSpeed();
    }

    void ScoreAdder()
    {
        if (red)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Dance.score += arrowScore;
                arrowScore = 0;
                Destroy(arrow);
                red = false;
            }
        }

        if (yellow)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Dance.score += arrowScore;
                arrowScore = 0;
                Destroy(arrow);
                yellow = false;
            }
        }

        if (green)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Dance.score += arrowScore;
                arrowScore = 0;
                Destroy(arrow);
                green = false;
            }
        }

        if (wrong)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Dance.score += 0;
                arrowScore = 0;
                Destroy(arrow);
                wrong = false;
            }
        }
    }

    void FallSpeed()
    {
        if (Dance.stage == 1)
        {
            arrowrb.gravityScale = 0.075f;
        }

        if (Dance.stage == 2)
        {
            arrowrb.gravityScale = 0.1f;
        }

        if (Dance.stage == 3)
        {
            arrowrb.gravityScale = 0.125f;
        }

        if (Dance.stage == 4)
        {
            arrowrb.gravityScale = 0.15f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            Debug.Log("Inside");
            arrowScore = 1;
            red = true;
        }

        else if (collision.gameObject.tag == "Yellow")
        {
            arrowScore = 2;
            yellow = true;
        }

        else if (collision.gameObject.tag == "Green")
        {
            arrowScore = 3;
            green = true;
        }

        else if (collision.gameObject.tag == "Zero")
        {
            arrowScore = 0;
            wrong = true;
        }


        else if (collision.gameObject.tag == "Destroy")
        {
            Destroy(arrow);
        }


    }
}
