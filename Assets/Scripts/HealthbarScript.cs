using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthbarScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject player;
    public Slider slider;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = player.GetComponent<EntityHealthAndDmg>().GetHealth() / 2.0f;
    }
}