using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLOWER_Blackboard : DynamicBlackboard
{
    public Sprite SeedSprite;
    public Sprite FlowerSprite;

    private void OnEnable()
    {
        gameObject.tag = "SEED";
        gameObject.GetComponent<SpriteRenderer>().sprite = SeedSprite;
    }

    public void FromSeedToFlower()
    {
        gameObject.tag = "FLOWER";
        gameObject.GetComponent<SpriteRenderer>().sprite = FlowerSprite;
    }
}
