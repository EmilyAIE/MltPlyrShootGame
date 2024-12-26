using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [Header("Gun Storage")]
    //[SerializeField] public List<BaseGun> guns;
    private int m_selectedGunIndex;
    public int selectedGunIndex => m_selectedGunIndex;

    //[Header("Key Storage")]
    //[SerializeField] public List<BaseKey> keys;

    private void Start()
    {
    }

    public void ChangeWeaponIndex()
    {
        //m_selectedGunIndex++;
        //if (m_selectedGunIndex >= guns.Count)
        //{
        //    m_selectedGunIndex = 0;
        //}
    }

    //public void AddGun(BaseGun gun)
    //{
    //    guns.Add(gun);
    //    if (gun.swapOnStart)
    //        GetComponent<PlayerShoot>().SwapWeapon();
    //    guns[guns.Count - 1].Initialise();
    //}

    //public void AddKey(BaseKey key)
    //{
    //    keys.Add(key);
    //}
}
