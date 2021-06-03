using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public string TankId { get; set; }
    public string Fracktion { get; set; }
    //Tank type
    public Gun gun { get; set; }
    public Corpus corpus { get; set; }
    public Tower tower { get; set; }
}
