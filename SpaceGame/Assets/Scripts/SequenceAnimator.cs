using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceAnimator : MonoBehaviour
{
    public float waitTime = 0.15f;
    public float waitEnd = 0.5f;
    List<Animator> animators;

    void Start()
    {
        animators = new List<Animator>(GetComponentsInChildren<Animator>());
        StartCoroutine(Movement());
    }

    IEnumerator Movement()
    {
        while (true)
        {
            foreach(var animator in animators)
            {
                animator.SetTrigger("Movement");
                yield return new WaitForSeconds(waitTime);
            }
            yield return new WaitForSeconds(waitEnd);
        }
    }
}
