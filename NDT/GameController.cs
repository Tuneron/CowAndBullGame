using System;
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
            this.game.Start();
            this.playerController.Start();

            while (this.game.EndGame() == false)
            {
                this.playerController.SetPlayersPlace(this.game.AwardingAPlace(
                    this.game.GetInPlace(this.playerController.GetPlayerNumbers(this.game.NumberLenght)),
                    this.playerController.GetPlayerPlaces()));

                this.gameView.PlayerLogo(this.playerController.GetPlayerNames(),
                    this.game.TableProportions, this.playerController.GetPlayerPlaces());

                this.gameView.GameInformation(this.game.TableProportions, this.playerController.GetPlayerPlaces(),
                    this.game.GetInPlace(this.playerController.GetPlayerNumbers(this.game.NumberLenght)),
                    this.game.GetOutOfPlace(this.playerController.GetPlayerNumbers(this.game.NumberLenght)));

                this.playerController.PlayersTurn(this.game.NumberLenght, this.game.TableProportions);

                Console.Clear();
            }
            this.gameView.Rewarding(this.playerController.GetPlayerNames(), this.playerController.GetPlayerPlaces());
            Console.ReadKey();
        }
    }
}
