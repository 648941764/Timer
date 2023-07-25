using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Button swtichBtn;
    public GameObject Clock;
    private bool _switch = true;
    

    public void OnswtichBtnClicked()
    {
        _switch = !_switch;
        //Clock.SetActive(_switch);
        Clock.GetComponent<ClockController>().enabled = _switch;
    }
}
