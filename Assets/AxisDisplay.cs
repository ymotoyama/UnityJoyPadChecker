using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AxisDisplay : MonoBehaviour
{
    public Slider m_Slider;
    public Text m_ValueLabel;

    void Start()
    {
        m_ValueLabel.text = "-";
    }
    
    public void SetValue(float value)
    {
        m_Slider.value = value;
        m_ValueLabel.text = System.Math.Round((double)value, 4).ToString();
    }
}
