using UnityEngine;
using System.Collections;

// will keep update the health of the player while its being drained
public class Player : MonoBehaviour
{
    [SerializeField]
    float health = 100;

    [SerializeField]
    float hunger = 100;

    [SerializeField]
    float foodPickups;

    public float Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public float Hunger
    {
        get
        {
            return hunger;
        }

        set
        {
            hunger = value;
        }
    }

    public float FoodPickups
    {
        get
        {
            return foodPickups;
        }

        set
        {
            foodPickups = value;
        }
    }

    
}
