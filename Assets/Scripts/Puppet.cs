using System.Collections;
using UnityEngine;

public class Puppet : MonoBehaviour
{
    public Rigidbody[] partOfPuppet;

    private IEnumerator coroutine;

    // Start is called before the first frame update
    private void Start()
    {
        //Drop();
    }

    // Update is called once per frame
    private void Update()
    {
        coroutine = WaitTime(2.0f);
    }

    public void Drop()
    {
        Time.timeScale = 0.07f;

        foreach (var part in partOfPuppet)
        {
            part.constraints = RigidbodyConstraints.None;
        }

        StartCoroutine(coroutine);
    }

    private IEnumerator WaitTime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Time.timeScale = 1;
    }
}
