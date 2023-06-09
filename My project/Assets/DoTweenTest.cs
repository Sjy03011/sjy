using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenTest : MonoBehaviour
{
    public bool isPunch;
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMoveX(5, 2);
        //transform.DORotate(new Vector3(0, 0, 180), 2);
        //transform.DORotate(new Vector3(3, 3, 3), 2);

        //sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 2)SetEase(Ease.OutBounce));
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2)
        // sequence.Append(transform.DOScale(new Vector3(3, 3, 3), 2));
        // sequence,SetLoops(-1, LoopToyo);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPunch == false)
            {
                isPunch = true;
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPunch);

                Color color = new Color(Random.value, Random.value, Random.value);
                Renderer renderer = GetComponent<Renderer>();
                renderer.material.DOColor(color,0.1f);
            }
        }
    }

    public void EndPunch()
    {
        isPunch = false;
    }
}
