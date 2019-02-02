using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] GameObject blockVFX;

    //cached reference
    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlock();
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        FindObjectOfType<GameSession>().AddToScore();
        Destroy(gameObject);
        level.BlockDestroyed();
        TriggerVFX();
    }

    private void TriggerVFX()
    {
        GameObject VFX = Instantiate(blockVFX, transform.position, transform.rotation);
        Destroy(VFX, 2f);
    }
}
