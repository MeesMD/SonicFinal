using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField]
    private float overFinish = 2;
    [SerializeField]
    private Animator anim;

    public float speed;
    public bool isFinished = false;

    void Start()
    {
       anim = GameObject.Find("Timer").GetComponent<Animator>();
    }

    IEnumerator ColFinish()
    {
        while (true)
        {
            changeAngle();
            anim.SetBool("isFinished", true);
            yield return new WaitForSeconds(5f);
            Application.LoadLevel("StartScene");
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            overFinish -= 1;

            if (overFinish == 0)
            {
                StartCoroutine(ColFinish());
            }
        }
    }

    void changeAngle()
    {
        isFinished = true;
    }
}


