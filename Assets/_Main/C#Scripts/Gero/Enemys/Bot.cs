using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : Actor
{
    Animator anim;
    public bool isDead = false;
    public int selectedWeapon = 0;
    //public FpsControllerLPFP controller;
    public GameObject[] arms;
    public GameObject[] cams;
    Transform previousArms;

    public void Awake()
    {
        //anim = GetComponent<Animator>();
        isDead = false;
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        if (anim != null) anim.SetTrigger("TakeDamage");
    }
    public override void Die()
    {
        isDead = true;
        Debug.Log("BOT DEAD");
        if (anim != null) anim.SetTrigger("Die");
        Destroy(gameObject, 2f);
    }

    void Start()
    {
        previousArms = arms[0].transform;
        SelectWeapon();
    }

    void Update()
    {
        int previousSelectedWeapon = selectedWeapon;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedWeapon >= 1)
                selectedWeapon = 0;
            else
                selectedWeapon++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon <= 0)
                selectedWeapon = 1;
            else
                selectedWeapon--;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            selectedWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            selectedWeapon = 2;
        }

        if (previousSelectedWeapon != selectedWeapon)
        {
            SelectWeapon();
        }
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach (GameObject arm in arms)
        {
            if (i == selectedWeapon)
            {
                arm.transform.rotation = previousArms.transform.rotation;
                arm.gameObject.SetActive(true);
                //controller.playerCam = cams[i].transform;
                //controller.arms = arm.transform;
                previousArms = arm.transform;
            }
            else
                arm.gameObject.SetActive(false);
            i++;
        }
    }
}