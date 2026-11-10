using System.Numerics;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    public float speed = 3f;
    public Transform cat;
    private bool isChasing = false;
    private void Update()
    {
        if (isChasing && cat != null)
        {
            Debug.Log("hi");
            transform.position = UnityEngine.Vector3.MoveTowards(
                transform.position,
                cat.position,
                speed * Time.deltaTime


                );
        }
    }
    public void StartChasing()
    {
        isChasing = true;
    }
    public void StopChasing()
    {
        isChasing = false;
    }
}
