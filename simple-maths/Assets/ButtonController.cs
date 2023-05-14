using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private Button lastClickedButton;

    public void OnButtonClick(Button button)
    {
        if (lastClickedButton != null)
        {
            lastClickedButton.interactable = true;
            lastClickedButton = null;
        }

        button.interactable = false;
        lastClickedButton = button;
    }
}
