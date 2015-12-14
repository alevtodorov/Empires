using Empires.Interfaces;
using Empires.Models.Buildings;
using Empires.Other.Print;
using System;

namespace Empires.Core
{
    public class Engine : IEngine
    {
        private readonly IDatabase db;
        public event EventHandler OnTurn;

        public Engine(IDatabase db)
        {
            this.db = db;
        }

        public void Run()
        {
            string input = Console.ReadLine();
            while (input.ToLower() != "armistice")
            {
                if(OnTurn != null)
                {
                    OnTurn(this, new EventArgs());
                }
                string[] userInput = input.Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                switch (userInput[0])
                {
                    case "build":
                        if(userInput[1] == "barracks")
                        {
                            db.AddBuilding(new Barracks(this));
                        }
                        if(userInput[1] == "archery")
                        {
                            db.AddBuilding(new Archery(this));
                        }
                        break;
                    case "empire":
                        var p = new ConsolePrintAllInfo();
                        p.Print(db);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
