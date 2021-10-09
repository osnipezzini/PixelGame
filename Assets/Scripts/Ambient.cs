using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambient : MonoBehaviour
{
    [SerializeField]
    public Transform player;
    [SerializeField]
    public Transform playerRespawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = playerRespawn.transform.position;
            Physics2D.SyncTransforms();
        }
    }
}
