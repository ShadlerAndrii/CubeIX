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
        // ���� ����� ������ � ����
        if (col.tag == "Player")
        {
            // ��� ������� � �����
            col.GetComponent<PlayerScript>().Score += ScoreAdd;
            // ��������� ����
            SoundSource.PlayOneShot(PickupSFX);
            // �������� ���������� ������
            Instantiate(PickupEffect, transform.position, transform.rotation);
            // ������� ���������
            Destroy(gameObject, 0.4f);
        }
    }
}