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
    public class Game
    {

        private Panel panel_m;
        private UIFactory uiFactory_m;
        private GameLoop gameLoop_m;

        public Game(ref Panel panel)
        {
            panel_m = panel;
            uiFactory_m = new UIFactory(ref panel);
            gameLoop_m = new GameLoop(ref uiFactory_m);
        }

        public void StartGame()
        {
            gameLoop_m.StartGame(panel_m);
        }

        //public UIFactory GetUIFactory()
        //{
        //    return uiFactory_m;
        //}

        //public GameLoop GetGameLoop()
        //{
        //    return gameLoop_m;
        //}

        public void Update(ref PaintEventArgs e)
        {
            uiFactory_m.Update(ref e);
            //gameLoop_m.Update();
        }


    }

}

