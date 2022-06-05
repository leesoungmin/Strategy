using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Cube,
    Sphere,
    Arrow
}


public class WeaponManager : MonoBehaviour
{
    public GameObject p_Cube;
    public GameObject p_Sphere;
    public GameObject p_Arrow;

    GameObject myWeapon;

    Weapon weapon;

    void SetWeapon(WeaponType weaponType)
    {
        Component c = gameObject.GetComponent<Weapon>() as Component; 

        if (c != null)
        {
            Destroy(c);
        }

        switch (weaponType)
        {
            case WeaponType.Cube:
                weapon = gameObject.AddComponent<Cube>();
                myWeapon = p_Cube;
                break;
            case WeaponType.Sphere:
                weapon = gameObject.AddComponent<Sphere>();
                myWeapon = p_Sphere;
                break;
            case WeaponType.Arrow:
                weapon = gameObject.AddComponent<Arrow>();
                myWeapon = p_Arrow;
                break;
            default:
                weapon = gameObject.AddComponent<Cube>();
                myWeapon = p_Cube;
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        SetWeapon(WeaponType.Cube);
    }

    public void ChangeCube()
    {
        SetWeapon(WeaponType.Cube);
    }
    public void ChangeArrow()
    {
        SetWeapon(WeaponType.Arrow);
    }
    public void ChangeSphere()
    {
        SetWeapon(WeaponType.Sphere);
    }
    public void Fire()
    {
        weapon.Shoot(myWeapon);
    }
}
