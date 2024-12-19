using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class GoToInGameButton : ButtonWithAudio
    {
        protected override void Start()
        {
            base.Start();
            onClick.AddListener(GoToInGame);
        }

        //M�todo que chama o m�todo de ir para o jogo do GameManager
        private void GoToInGame()
        {
            GameManager.instance.GoToInGame();
        }
    }
}