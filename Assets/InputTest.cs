using UnityEngine;
using UnityEngine.UI;

public class InputTest : MonoBehaviour {

    public Toggle m_ToggleJoystickButton00;
    public Toggle m_ToggleJoystickButton01;
    public Toggle m_ToggleJoystickButton02;
    public Toggle m_ToggleJoystickButton03;
    public Toggle m_ToggleJoystickButton04;
    public Toggle m_ToggleJoystickButton05;
    public Toggle m_ToggleJoystickButton06;
    public Toggle m_ToggleJoystickButton07;
    public Toggle m_ToggleJoystickButton08;
    public Toggle m_ToggleJoystickButton09;
    public Toggle m_ToggleJoystickButton10;
    public Toggle m_ToggleJoystickButton11;
    public Toggle m_ToggleJoystickButton12;
    public Toggle m_ToggleJoystickButton13;
    public Toggle m_ToggleJoystickButton14;
    public Toggle m_ToggleJoystickButton15;
    public Toggle m_ToggleJoystickButton16;
    public Toggle m_ToggleJoystickButton17;
    public Toggle m_ToggleJoystickButton18;
    public Toggle m_ToggleJoystickButton19;

    public AxisDisplay m_AxisDisplay01;
    public AxisDisplay m_AxisDisplay02;
    public AxisDisplay m_AxisDisplay03;
    public AxisDisplay m_AxisDisplay04;
    public AxisDisplay m_AxisDisplay05;
    public AxisDisplay m_AxisDisplay06;
    public AxisDisplay m_AxisDisplay07;
    public AxisDisplay m_AxisDisplay08;

    void Start () {
	
	}
	
	void Update ()
    {
        m_ToggleJoystickButton00.isOn = Input.GetKey(KeyCode.JoystickButton0);
        m_ToggleJoystickButton01.isOn = Input.GetKey(KeyCode.JoystickButton1);
        m_ToggleJoystickButton02.isOn = Input.GetKey(KeyCode.JoystickButton2);
        m_ToggleJoystickButton03.isOn = Input.GetKey(KeyCode.JoystickButton3);
        m_ToggleJoystickButton04.isOn = Input.GetKey(KeyCode.JoystickButton4);
        m_ToggleJoystickButton05.isOn = Input.GetKey(KeyCode.JoystickButton5);
        m_ToggleJoystickButton06.isOn = Input.GetKey(KeyCode.JoystickButton6);
        m_ToggleJoystickButton07.isOn = Input.GetKey(KeyCode.JoystickButton7);
        m_ToggleJoystickButton08.isOn = Input.GetKey(KeyCode.JoystickButton8);
        m_ToggleJoystickButton09.isOn = Input.GetKey(KeyCode.JoystickButton9);
        m_ToggleJoystickButton10.isOn = Input.GetKey(KeyCode.JoystickButton10);
        m_ToggleJoystickButton11.isOn = Input.GetKey(KeyCode.JoystickButton11);
        m_ToggleJoystickButton12.isOn = Input.GetKey(KeyCode.JoystickButton12);
        m_ToggleJoystickButton13.isOn = Input.GetKey(KeyCode.JoystickButton13);
        m_ToggleJoystickButton14.isOn = Input.GetKey(KeyCode.JoystickButton14);
        m_ToggleJoystickButton15.isOn = Input.GetKey(KeyCode.JoystickButton15);
        m_ToggleJoystickButton16.isOn = Input.GetKey(KeyCode.JoystickButton16);
        m_ToggleJoystickButton17.isOn = Input.GetKey(KeyCode.JoystickButton17);
        m_ToggleJoystickButton18.isOn = Input.GetKey(KeyCode.JoystickButton18);
        m_ToggleJoystickButton19.isOn = Input.GetKey(KeyCode.JoystickButton19);

        m_AxisDisplay01.SetValue(Input.GetAxisRaw("Axis01"));
        m_AxisDisplay02.SetValue(Input.GetAxisRaw("Axis02"));
        m_AxisDisplay03.SetValue(Input.GetAxisRaw("Axis03"));
        m_AxisDisplay04.SetValue(Input.GetAxisRaw("Axis04"));
        m_AxisDisplay05.SetValue(Input.GetAxisRaw("Axis05"));
        m_AxisDisplay06.SetValue(Input.GetAxisRaw("Axis06"));
        m_AxisDisplay07.SetValue(Input.GetAxisRaw("Axis07"));
        m_AxisDisplay08.SetValue(Input.GetAxisRaw("Axis08"));
    }
}
