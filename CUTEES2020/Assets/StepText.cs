using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepText : MonoBehaviour
{
    

        public Text stepText;
        private step stepData;

        public void Setup(step data)
        {
            stepData = data;
            stepText.text = stepData.stepText;
        }

    
}
