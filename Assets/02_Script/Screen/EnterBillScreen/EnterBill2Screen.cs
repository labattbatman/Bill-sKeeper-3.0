using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnterBill2Screen : MonoBehaviour
{

    public Slider m_Slider;
    public Text m_SubAmmount;

    
    // Use this for initialization
	void Start ()
    {

        m_Slider.onValueChanged.AddListener(SliderOnChanded);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void SliderOnChanded(float value)
    {
        m_SubAmmount.text = (value * 9.99).ToString("c2");
    }
}
