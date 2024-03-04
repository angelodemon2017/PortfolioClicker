using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LargeNumberClickableObject : MonoBehaviour, IPointerClickHandler
{
    [Header("Large Number")]
    public LargeNumber largeNumber;
    [Space(10)]
    [Header("Add or Subtract")]
    public bool add;
    public LargeNumber clickAmount;

    [Space(10)]
    [Header("Autoclick")]
    public bool autoClick;
    public float autoClickRate = .5f;
    public LargeNumber autoClickAmount;

    float timer = 1;

    [Space(10)]
    [Header("Text Display")]
    public bool displayFullText;
    public Text numberText;
    //public Text stringFull;

    private void Start()
    {
        UpdateText();
    }

    private void OnValidate()
    {
        largeNumber.ClampList();
        clickAmount.ClampList();
        autoClickAmount.ClampList();
        UpdateText();
    }

    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (largeNumber == null)
            largeNumber = new LargeNumber();
        if (clickAmount == null)
            clickAmount = new LargeNumber();

        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
        //Debug.Log(name + " Game Object Clicked!");
        if (add)
        {
            largeNumber.AddLargeNumber(clickAmount);
            UpdateText();
        }
        else
        {
            largeNumber.SubLargeNumber(clickAmount);
            UpdateText();
        }
    }
    public void UpdateText()
    {
        if (largeNumber == null)
            largeNumber = new LargeNumber();
        if (clickAmount == null)
            clickAmount = new LargeNumber();

        if (displayFullText)
            numberText.text = largeNumber.LargeNumberToString();
        else
            numberText.text = largeNumber.LargeNumberToShortString();
    }

    private void Update()
    {
        if (autoClickAmount == null)
        {
            autoClickAmount = new LargeNumber();
        }
        if (autoClick)
        {
            timer -= Time.deltaTime;
            if (timer < autoClickRate)
                timer = 1;
            else
                return;

            if (add)
            {
                largeNumber.AddLargeNumber(autoClickAmount);
                UpdateText();
            }
            else
            {
                largeNumber.SubLargeNumber(autoClickAmount);
                UpdateText();
            }
        }
    }
}
