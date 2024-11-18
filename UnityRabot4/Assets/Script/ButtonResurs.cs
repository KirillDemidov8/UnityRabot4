using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Navigate
{
    public class ButtonResurs : MonoBehaviour
    {
       

        private Button button;


        [SerializeField] Image elementIcon;
        private Resurs resurs = new Resurs();
        public TypeResource typeResource;
        private void Start()
        {
            button = GetComponent<Button>();
            GetInfoResurs();
            StartCoroutine(TimertimeEnrichment());
           


        }

        public void GetInfoResurs()
        {
            resurs = ServiceLoadTimeActiveRes.Instance.LoadTimeActiveRes(typeResource);
            Debug.Log(resurs.timeEnrichment);
        }

        public void GetInfoType()
        {
            Debug.Log(typeResource);

        }
        public IEnumerator TimertimeEnrichment()
        {
            button.interactable = false;
            ServiceLoadIcon.Instance.LoadIconNotActive(elementIcon);

            yield return new WaitForSeconds(resurs.timeEnrichment);
            Debug.Log("End1");
            StartCoroutine(TimertimeDisintegration());

        }
        public IEnumerator TimertimeDisintegration()
        {
            button.interactable = true;
            ServiceLoadIcon.Instance.LoadIconActive(elementIcon);

            yield return new WaitForSeconds(resurs.timeDisintegration);

            Game.Instance.GameOver();

            Debug.Log("End2");

        }
        public void ButtonClic()
        {
           StopAllCoroutines();
            StartCoroutine(TimertimeEnrichment());
        }


        



    }
}