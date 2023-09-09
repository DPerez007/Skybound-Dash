using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
   public float speed = 5f;
   private float leftEdge;

 private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;

private void Start()
{
    leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f;
}

   private void Update ()
   {

    transform.position += Vector3.left * speed * Time.deltaTime;

    if(transform.position.x < leftEdge)
    {
        Destroy(gameObject);

    }

   }

         private void AnimateSprite()
    {
        spriteIndex++;
        if(spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        spriteRenderer.sprite = sprites[spriteIndex];
    }

}


