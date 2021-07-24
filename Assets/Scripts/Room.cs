using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private GameObject roomLight;

    [SerializeField] private GameObject northOpen;
    [SerializeField] private GameObject northClose;

    [SerializeField] private GameObject eastOpen;
    [SerializeField] private GameObject eastClose;

    [SerializeField] private GameObject westOpen;
    [SerializeField] private GameObject westClose;

    [SerializeField] private GameObject south;

    // Start is called before the first frame update
    void Start()
    {
        roomLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
