using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour {

    Rigidbody2D riegid;
    public float speeed;
    Animator anim;

	void Start () {
        riegid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        var a = transform.eulerAngles;
        a.z += Random.Range(0, 360);
        transform.eulerAngles = a;
	}
	

	void Update () {
        transform.position += transform.right * speeed * Time.deltaTime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject, 2);
            anim.SetBool("Destroy", true);
        }
    }
}
