﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NDT
{
    class GameController
    {
        private Game game;

        private GameView gameView;

        public PlayerController playerController;

        public GameController()
        {
            this.gameView = new GameView();

            int numberLenght = this.gameView.RegisterLenghtNumber();
            int quantityOfPlayers = this.gameView.RegisterQuantityOfPlayers();

            this.game = new Game(numberLenght, quantityOfPlayers);

            this.playerController = new PlayerController(numberLenght, quantityOfPlayers);

            this.game.SetProportions(this.playerController.GetPlayerNames());
        }

        public void Run()
        {
            this.game.start();
            this.gameView.Head(this.playerController.GetPlayerNames(),
                this.game.TableProportions, this.playerController.GetPlayerPlaces());

            //this.gameView.Body(this.game.TableProportions);

        }
    }
}
