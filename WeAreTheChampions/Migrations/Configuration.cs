namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WeAreTheChampions.Models.WeAreTheChampionsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WeAreTheChampions.Models.WeAreTheChampionsContext context)
        {
            #region renkler
            if (!context.Colors.Any())
            {
                var renk1 = new Color()
                {
                    ColorName = "Siyah",
                    Red = 0,
                    Green = 0,
                    Blue = 0
                };

                var renk2 = new Color()
                {
                    ColorName = "Beyaz",
                    Red = 255,
                    Green = 255,
                    Blue = 255
                };

                context.Colors.Add(renk1);
                context.Colors.Add(renk2);
            }
            #endregion

            #region oyuncular
            if (!context.Players.Any())
            {
                var oyuncu1 = new Player()
                {
                    PlayerName = "Melis Çoban"
                };

                var oyuncu2 = new Player()
                {
                    PlayerName = "Kağan Algül"
                };

                var oyuncu3 = new Player()
                {
                    PlayerName = "Ece Merve Çoban"
                };

                var oyuncu4 = new Player()
                {
                    PlayerName = "Elif Büşra Algül"
                };

                context.Players.Add(oyuncu1);
                context.Players.Add(oyuncu2);
                context.Players.Add(oyuncu3);
                context.Players.Add(oyuncu4);
            }
            #endregion

            #region takımlar
            if (!context.Teams.Any())
            {
                var takim1 = new Team()
                {
                    TeamName = "Çobanlar"
                };

                var takim2 = new Team()
                {
                    TeamName = "Algüller"
                };

                var takim3 = new Team()
                {
                    TeamName = "Bizimkiler"
                };

                context.Teams.Add(takim1);
                context.Teams.Add(takim2);
                context.Teams.Add(takim3);
            }
            #endregion
        }
    }
}
