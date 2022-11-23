using RazorPagesGame.Models;

namespace RazorPagesGame.Services;
public static class GameService
{
    static List<Game> Games { get; }
    static int nextId = 3;
    static GameService()
    {
        Games = new List<Game>
                {
                    new Game { Id = 1, Name = "Genshin Impact", Developer = "Mihoyo", 
                                Player=GamePlayer.MassiveMultiplayer, Years = 2020, 
                                Description= "Nice gacha game", Genre = "RPG" },
                    new Game { Id = 2, Name = "Arknights", Developer = "Hypergliph", 
                                Player=GamePlayer.Singleplayer, Years = 2018, 
                                Description= "Nice tower defense game", Genre = "RPG" },
                };
    }

    public static List<Game> GetAll() => Games;

    public static Game? Get(int id) => Games.FirstOrDefault(p => p.Id == id);

    public static void Add(Game Game)
    {
        Game.Id = nextId++;
        Games.Add(Game);
    }

    public static void Delete(int id)
    {
        var Game = Get(id);
        if (Game is null)
            return;

        Games.Remove(Game);
    }

    public static void Update(Game Game)
    {
        var index = Games.FindIndex(p => p.Id == Game.Id);
        if (index == -1)
            return;

        Games[index] = Game;
    }
}