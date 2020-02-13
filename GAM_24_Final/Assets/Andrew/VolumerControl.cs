using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Slider slider = GetComponent<Slider>();

        slider.value = GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>().volume;

        slider.onValueChanged.AddListener(OnValueChanged);
    }

    void OnValueChanged(float volume)
    {
        Debug.Log("AUDIO CHANGED....");
        GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>().volume = volume;
    }
}
