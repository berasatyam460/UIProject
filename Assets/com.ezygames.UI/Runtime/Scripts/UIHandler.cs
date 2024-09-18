using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.UI;
using TMPro;

namespace ezygamers.UI
{
    public class UIHandler : MonoBehaviour
    {
        //reference of the UI
        [SerializeField] Image _image;
        [SerializeField] TextMeshProUGUI _text;
        // Start is called before the first frame update
        void Start()
        {

            if (GetComponentInChildren<Image>() != null)
            {
                //set the image 
                _image = GetComponentInChildren<Image>();
            }
            if (GetComponentInChildren<TextMeshProUGUI>() != null)
            {
                //set textmesh
                _text = GetComponentInChildren<TextMeshProUGUI>();
            }

        }


    }
}
