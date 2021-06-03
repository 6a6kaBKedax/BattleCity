using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScr : MonoBehaviour
{
    public int HP = 1;
    public void Destroy()
    {
        if (HP != 1)
        {
            Destroy();
        }
    }
}
