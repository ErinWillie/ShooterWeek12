using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyOneBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3);
        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider whatIHit)
    {
        if (whatIHit.tag == "Player")
        {
            whatIHit.GetComponent<PlayerBehavior>().LoseLife();
            Destroy(this.gameObject);
        }
        else if (whatIHit.tag == "Weapon")
        {
            whatIHit.GetComponent<PlayerBehavior>().EarnScore(2);
            Destroy(whatIHit.gameObject);
            Destroy(this.gameObject);
        }
    }
}