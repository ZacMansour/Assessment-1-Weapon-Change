using UnityEngine;
using System.Collections;

public class ChangeWeapons : MonoBehaviour 

{
    //Declare WeaponsArray of GameObjects + set in Unity
    public GameObject[] weapons;

    void Start () 
    {
        Cursor.visible = false;//hide cursor

        //set weapon to default
        WeaponChanger(0);
    }

    void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            WeaponChanger(0);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            WeaponChanger(1);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            WeaponChanger(2);

        if (Input.GetKeyDown(KeyCode.Alpha4))
            WeaponChanger(3);

    }

    //function(passedValue)
    //for (1 to WeaponsArray.Length)
    //if (loopValue == passedValue)
    //WeaponsArray [current element].SetActive(true)
    //else 
    //WeaponsArray [current element].SetActive(false)

    void WeaponChanger(int weaponNumber)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].SetActive(false);
            if (i != weaponNumber)
                weapons[i].SetActive(false);
            else
                weapons[i].SetActive(true);
        }
    }
}
