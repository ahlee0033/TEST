using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScript : MonoBehaviour
{
    public Image FadeOutCanvers;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeOut());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator FadeOut()
    {
        float fadeCount = 1.0f;
        //Debug.Log(fadeCount.ToString() + "½ÃÀÛ");
        while (fadeCount > 0)
        {
            fadeCount -= 0.01f;

            FadeOutCanvers.color = new Color(255, 255, 255, fadeCount);

            //Debug.Log(fadeCount.ToString());
            yield return new WaitForSeconds(0.01f);
        }
    }
}
