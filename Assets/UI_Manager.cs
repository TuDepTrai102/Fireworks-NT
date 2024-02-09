using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

namespace Fireworks.NT
{
    public class UI_Manager : MonoBehaviour
    {
        public VisualEffect fireWorks;
        public VFXSpawnerState spawnerState;
        public Text fireworksCountTextUI;
        public float fireworksCountNumber = 1f;
        public Button fireworksButton_Increase;
        public Button fireworksButton_Decrease;
        public Button fireworksButton_Play;
        public Button fireworksButton_Stop;

        private void Awake()
        {
            fireworksCountTextUI.text = fireworksCountNumber.ToString();
            fireWorks.Stop();
        }

        public void IncreaseFireworks()
        {
            fireworksCountNumber += 1;
            fireWorks.SetFloat("Spawn Rate", fireworksCountNumber);
            fireworksCountTextUI.text = fireworksCountNumber.ToString();
            fireworksButton_Increase.OnDeselect(null);
        }
        
        public void DecreaseFireworks()
        {
            fireworksCountNumber -= 1;
            fireWorks.SetFloat("Spawn Rate", fireworksCountNumber);
            fireworksCountTextUI.text = fireworksCountNumber.ToString();
            fireworksButton_Decrease.OnDeselect(null);
        }

        public void FireFireworks()
        {
            fireWorks.Play();
            fireworksButton_Play.OnDeselect(null);
        }

        public void StopFireworks()
        {
            fireWorks.Stop();
            fireworksButton_Stop.OnDeselect(null);
        }
    }
}