using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GetKeyScript : MonoBehaviour
{

    public int KeyCount = 0;
    public GameObject Gate;
    public Image FadeOutCanvers;

    private void OnTriggerEnter(Collider other)
    {
 
        if (other.gameObject.tag == "Key")
        {
            KeyCount++;


            ToastMsg.Instrance.showMessage("Å° ¸Ô¾ùÀ½~~~" + KeyCount.ToString() + "/3", 1.0f);

            Destroy(other.gameObject);
            //other.gameObject.SetActive(false);

            if (KeyCount >=3 )
            {
                Invoke("GateOpen", 3);
            }
        }
        if(other.gameObject.tag == "NextScene")
        {
            ToastMsg.Instrance.showMessage("ºüÀ×~~~~~~~", 3.0f);
            StartCoroutine(FadeOut());
            Invoke("EndingScene", 3f);
        }

    }

    void GateOpen()
    {
        ToastMsg.Instrance.showMessage("Å° ´Ù ¸Ô¾ùÀ½~~~ Å»ÃâÇÕ½Ã´ç", 3.0f);
        Gate.SetActive(true);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Key")
    //    {
    //        ToastMsg.Instrance.showMessage("Å° ¸Ô¾ùÀ½~~~", 1.0f);
    //    }

    //}
    void EndingScene()
    {
        
        new WaitForSeconds(2);

        SceneManager.LoadScene("Ending");
    }

    IEnumerator FadeOut()
    {
        float fadeCount = 0;
        while (fadeCount < 1)
        {
            fadeCount += 0.01f;

            FadeOutCanvers.color = new Color(255, 255, 255, fadeCount);

            yield return new WaitForSeconds(0.01f);
        }
    }
}
