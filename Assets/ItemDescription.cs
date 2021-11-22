using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDescription : MonoBehaviour
{
    void OnEnable()
    {
        Time.timeScale = 0f;
        StartCoroutine(HideItem());
    }

    IEnumerator HideItem()
    {
        yield return new WaitForSecondsRealtime(5f);
        gameObject.SetActive(false);
        Time.timeScale = 1f;
        yield break;
    }
}
