using UnityEngine;
using UnityEngine.UI;

public class NumberTask : MonoBehaviour
{
    public Text Number1;
    int Counter = 0;

    public void ReserButton()
    {
        Counter = 0;
        Number1.text = "" + Counter;
    }
    public void Eic()
    { 
        Counter++;
        Number1.text = "" + Counter;
    }
    public void Dic()
    {
        Counter--;
        Number1.text = "" + Counter;
    }
}
