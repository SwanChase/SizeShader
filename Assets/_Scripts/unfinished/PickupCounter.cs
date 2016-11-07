using UnityEngine;
using System.Collections;

public class PickupCounter : MonoBehaviour
{
    int pickupAmount;

    public int _pickupAmount
    {
        get { return pickupAmount; }
        set { pickupAmount = value; }
    }

}
