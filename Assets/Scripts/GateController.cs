using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GateController : MonoBehaviour
{
    public CinemachineVirtualCamera camera1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && camera1.gameObject.activeSelf == true)
        {
            Debug.Log("entra trigger");
            //camera1.AddCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_NoiseProfile
            //camera1.AddCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 24;
            //camera1.AddCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 3;
            //camera1.AddCinemachineComponent<CinemachineImpulseListener>
        }
    }*/
}
