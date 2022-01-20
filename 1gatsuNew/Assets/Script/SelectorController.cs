using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectorController : MonoBehaviour
{
    [SerializeField] EventSystem eventSystem;

    [SerializeField] Text text;
    GameObject selectedObj;



    public void UI()
    {
        selectedObj = eventSystem.currentSelectedGameObject.gameObject;
        transform.position = new Vector3(transform.position.x, selectedObj.transform.position.y, transform.position.z);

    }
}
