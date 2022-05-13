using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthBarSprite;
    [SerializeField] private Gradient healthColor;
    
    // Start is called before the first frame update
    public void UpdateTimeToDrown(float timeRemaining, float timeToDeath)
    {
       
        healthBarSprite.fillAmount = 1 - (timeRemaining/timeToDeath);
        healthBarSprite.color = healthColor.Evaluate(healthBarSprite.fillAmount);
     
    }
}
