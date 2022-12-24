using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food1 : MonoBehaviour
{
    public BoxCollider2D SpawnArea;

    private void Start()
    {
        RandomizePosition();
    }
    private void RandomizePosition()
    {
        Bounds bounds = this.SpawnArea.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject.FindObjectOfType<AudioManager>().playsong("yum1");
            RandomizePosition();
        }
    }
}
