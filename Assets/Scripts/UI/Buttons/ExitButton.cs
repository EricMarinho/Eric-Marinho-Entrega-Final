using Managers;
using UnityEngine.UI;

namespace UI
{
    public class ExitButton : ButtonWithAudio
    {
        protected override void Start()
        {
            base.Start();
            onClick.AddListener(ExitGame);
        }

        //M�todo que chama o m�todo de sair do jogo do GameManager
        private void ExitGame()
        {
            GameManager.instance.ExitGame();
        }
    }
}