
using Audio;
using Managers;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ButtonWithAudio : Button
    {
        protected override void Start()
        {
            base.Start();
            onClick.AddListener(PlayAudio);
        }

        //M�todo que chama o m�todo de Tocar �udio
        private void PlayAudio()
        {
            AudioManager.instance.PlayGenericButtonSound();
        }
    }
}