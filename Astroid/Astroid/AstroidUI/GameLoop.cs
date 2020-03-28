using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Astroid.AstroidUI;
using System.Windows.Input;

namespace Astroid.AstroidUI
{

    // A class that handles the game start, stop, pause, etc. states
    // Use this class to update the screen's sprites / UIFactory
    public class GameLoop
    {

        UIFactory uiFactory_m;
        bool gameStarted_m;
        bool gamePaused_m;

        public GameLoop(ref UIFactory uiFactory)
        {
            uiFactory_m = uiFactory;
            gameStarted_m = false;
            gamePaused_m = false;
        }

        public async void StartGame(Panel panel)
        {
            var updatedObject = panel;
            gameStarted_m = true;

            //UI Factory

            while (gameStarted_m)
            { 
                // stop game if escape
                KeyPressCheck();
                //uiFactory_m.Update(); // KeyPressCheck will probably update the ui itself
                updatedObject.Invalidate(); // paint all the objects to the screen again
                await Task.Delay(8);
            }
        }

        public async void Stop()
        {

        }

        public void Update()
        {

        }

        private void KeyPressCheck()
        {
            if (Keyboard.GetKeyStates(Key.Escape) > 0)
            {
                gameStarted_m = false;
            }

            if(Keyboard.GetKeyStates(Key.Up) > 0)
            {
                uiFactory_m.KeyPressHandle(UIFactory.KeyPress.UP_ARROW);
            }
        }


    }
}
