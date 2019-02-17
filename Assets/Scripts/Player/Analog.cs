﻿//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Analog : MonoBehaviour {


//    int timeLeft;

//    Vector2[] userinput;
//    public Vector2[] gesture1 = new Vector2[2];
//    public Vector2[] gesture2 = new Vector2[2];

//    Animator anim;
//    AnimatorStateInfo stateinfo;
//    int state_Combat = Animator.StringToHash("Base Layer.Combat Mode");

//    bool coroutineStarted;

//    void Start()
//    {
//        coroutineStarted = false;
//        timeLeft = 2;
//        anim = GetComponent<Animator>();
//    }


//    void Update()
//    {

//        if (stateinfo.fullPathHash == state_Combat)
//        {

//            if (((Input.GetAxis("RightJoyStickHorizontal") != 0) || (Input.GetAxis("RightJoyStickVertical") != 0)) && (coroutineStarted == false) && (timeLeft == 2))
//            {
//                StartCoroutine(coRoutineTest());
//                coroutineStarted = true;
//            }

//            if (timeLeft <= 0 && coroutineStarted == true)
//            {
//                coroutineStarted = false;
//                Debug.Log("*******ended*******");
//                StopCoroutine(coRoutineTest());
//                timeLeft = 2;
//            }

//        }

//    }

//    IEnumerator coRoutineTest()
//    {
//        if (Input.GetAxis("RightJoyStickHorizontal") > 0.2)
//        {
//            userinput[0].x = 1;
//        }
//        else
//        {
//            userinput[0].x = 0;
//        }

//        if (Input.GetAxis("RightJoyStickVertical") > 0.2)
//        {
//            userinput[0].y = 1;
//        }
//        else
//        {
//            userinput[0].y = 0;
//        }

//        yield return new WaitForSeconds(0.10f);



//        if (Input.GetAxis("RightJoyStickHorizontal") > 0.2)
//        {
//            userinput[1].x = 1;
//        }
//        else
//        {
//            userinput[1].x = 0;
//        }

//        if (Input.GetAxis("RightJoyStickVertical") > 0.2)
//        {
//            userinput[1].y = 1;
//        }
//        else
//        {
//            userinput[1].y = 0;
//        }


//        if (userinput[0] == gesture1[0])
//        {
//            if (userinput[1] == gesture1[1])
//            {
//                Debug.Log("Gesture 1 is a Match");
//                anim.SetTrigger("SpAttack2");
//                ResetTriggers();
//            }
//        }

//        if (userinput[0] == gesture2[0])
//        {
//            if (userinput[1] == gesture2[1])
//            {
//                Debug.Log("Gesture 2 is a Match");
//                anim.SetTrigger("SpAttack1");
//                ResetTriggers();
//            }
//        }

//        yield return new WaitForSeconds(0.80f);
//        timeLeft = 0;


//    }

//    void ResetTriggers()
//    {
//        anim.ResetTrigger("SpAttack1");
//        anim.ResetTrigger("SpAttack2");
//    }

//}
