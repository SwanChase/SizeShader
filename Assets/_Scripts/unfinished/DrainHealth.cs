using UnityEngine;
using System.Collections;

public class DrainHealth : MonoBehaviour
{

    float hungerLimit = 25;
    float dmg = 0.1f;

    [SerializeField]
    Player p;

    void Start()
    {
        p = GetComponent<Player>();
    }

    void Update()
    {
        float dmgOvTime = Time.deltaTime;
        if (p.Hunger <= hungerLimit)
        {
            p.Health -= dmg * Time.deltaTime;
        }
    }
}
