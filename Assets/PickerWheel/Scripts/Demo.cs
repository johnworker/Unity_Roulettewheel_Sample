using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.PickerWheelUI;
using UnityEngine.UI;
using TMPro;

public class Demo : MonoBehaviour
{
    [SerializeField] private Button uiSpinButton;
    [SerializeField] private TextMeshProUGUI uiSpinButtonText;

    [SerializeField] private PickerWheel pickerWheel;

    private void Start()
    {
        uiSpinButton.onClick.AddListener(() =>
        {
            uiSpinButton.interactable = false;
            uiSpinButtonText.text = "Spinning";

            pickerWheel.OnSpinStart(() => 
            {
                Debug.Log("Spin start...");
            });

            pickerWheel.OnSpinEnd(wheelPiece =>
            {
                Debug.Log("Spin end¡Glabel¡G" + wheelPiece.Label + "¡AAmount¡G" + wheelPiece.Amount);
                uiSpinButton.interactable = true;
                uiSpinButtonText.text = "Spin";
            });

            pickerWheel.Spin();

        });
    }

}
