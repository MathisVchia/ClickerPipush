using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeManager : MonoBehaviour
{

    public shopManagement shopManagement;
    public int tickets;

    // Start is called before the first frame update
    void Start()
    {
        upgradeButtons = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (shopManagement.bonus > 10)
        {
            upgradeButtons = true;
        }
    }
}
