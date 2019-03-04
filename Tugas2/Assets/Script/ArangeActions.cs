using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArangeActions : MonoBehaviour
{
    private RectTransform panelRectTransform;
    // Start is called before the first frame update
    void Start()
    {
        panelRectTransform = GetComponent<RectTransform>();
    }

    public void MoveDownOne()
    {
        print("(Before change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex());
        int currentSiblingIndex = panelRectTransform.GetSiblingIndex();
        panelRectTransform.SetSiblingIndex(currentSiblingIndex - 1);
        print("(After change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex());
    }

    public void MoveUpOne()
    {
        print("(Before change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex());
        int currentSiblingIndex = panelRectTransform.GetSiblingIndex();
        panelRectTransform.SetSiblingIndex(currentSiblingIndex + 1);
        print("(After change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex());
    }
}
