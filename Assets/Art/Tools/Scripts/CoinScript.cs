using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int ScoreAdd;
    public AudioClip PickupSFX;
    AudioSource SoundSource;
    public GameObject PickupEffect;

    void Start()
    {
        SoundSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col)
    {
        // Если игрок входит в зону
        if (col.tag == "Player")
        {
            // Ему добавим Х очков
            col.GetComponent<PlayerScript>().Score += ScoreAdd;
            // Проиграть звук
            SoundSource.PlayOneShot(PickupSFX);
            // Включить визуадьный эффект
            Instantiate(PickupEffect, transform.position, transform.rotation);
            // Монетка удаляется
            Destroy(gameObject, 0.4f);
        }
    }
}