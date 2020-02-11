using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepText : MonoBehaviour
{
    

        public Text stepText;
        private Step stepData;

        public void Setup(Step data)
        {
            stepData = data;
            stepText.text = stepData.stepText;
        }

    
}
