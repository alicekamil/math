using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCube : MonoBehaviour
{/*
    // ease in function
    public bool isAnimating;
    public Vector3 posStart;
    public Vector3 posTarget;
    public float moveTime;
    public void Update()
    {

        if(isAnimating == true)
        {
            Animate();
            
        }
        else
        {
            CheckInput();
        }
        void CheckInput {
            void CheckMove(KeyCode key, Vector3 dir)
            {
                if (Input.GetKeyDown(key))
                {
                    posStart = transform.position;
                    posTarget = posStart + dir;
                    isAnimating = true;
                    animTime = 0;
                }
                CheckMove(KeyCode.W, Vector2.up);
                CheckMove(KeyCode.S, Vector2.down);
                CheckMove(KeyCode.A, Vector2.left);
                CheckMove(KeyCode.D, Vector2.right);

            }
        }
        void Animate()
        {
            animTime += Time.deltaTime;
            float t = animTime / moveTime;
            Vector3.Lerp(posStart, posTarget, t);
            if(t >= 1f)
            {
                isAnimating = false;
            }
        }
    }
    */
}
