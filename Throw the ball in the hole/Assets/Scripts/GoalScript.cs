using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public ScoreScript score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        score.IncreaseScore(1);
        RandomisePosition();
    }

    private void RandomisePosition()
    {
        float x = Random.Range(-2f, 7f);
        float y = Random.Range(-4f, 3.5f);
        gameObject.transform.position = new Vector2(x,y);

    }

    
}
