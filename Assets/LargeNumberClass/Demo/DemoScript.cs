using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoScript : MonoBehaviour
{

    LargeNumber result = new LargeNumber();
    LargeNumber addAmount = new LargeNumber();
    LargeNumber subAmount = new LargeNumber();
    LargeNumber setAmount = new LargeNumber();

    public Button addOne;
    public Button subOne;
    public Button addLargeNumber;
    public Button subLargeNumber;
    public Button assignLargeNumber;

    public InputField largeNumberToAdd;
    public InputField largeNumberToSub;
    public InputField largeNumberToSet;

    public Text resultStringShort;
    public Text resultString;

    /*void Start()
    {

    }

    void Update()
    {

    }*/

    public void ButtonAddOne()
    {
        result.AddOne();
        UpdateText();
    }
    public void ButtonSubOne()
    {
        result.SubOne();
        UpdateText();
    }
    public void ButtonAddLargeNumber()
    {
        result.AddLargeNumber(addAmount);
        UpdateText();
    }
    public void ButtonSubLargeNumber()
    {
        result.SubLargeNumber(subAmount);
        UpdateText();
    }
    public void ButtonAssignLargeNumber()
    {
        result.Assign(setAmount);
        UpdateText();
    }

    public void UpdateLargeNumberToAdd()
    {
        char[] numbers = largeNumberToAdd.text.ToCharArray();

        addAmount.Assign(addAmount.StringToLargeNumber(largeNumberToAdd.text));
    }

    public void UpdateLargeNumberToSub()
    {
        subAmount.Assign(subAmount.StringToLargeNumber(largeNumberToSub.text));
    }

    public void UpdateLargeNumberToSet()
    {
        //setAmount.Assign(setAmount.StringToLargeNumber(largeNumberToSet.text));
        setAmount=setAmount.StringToLargeNumber(largeNumberToSet.text);
    }

    public void UpdateText()
    {
        resultStringShort.text = result.LargeNumberToShortString();
        resultString.text = result.LargeNumberToString();
    }
}
