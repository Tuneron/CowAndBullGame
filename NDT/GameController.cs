using System;
using System.Collections.Generic;
using System.Text;

namespace NDT
{
    class GameController
    {
        private Game game;

        private GameView gameView;

        public GameController()
        {
            this.gameView = new GameView();
            this.game = new Game(this.gameView.RegisterLenghtNumber(), this.gameView.RegisterQuantityOfPlayers());
        }
    }
}
