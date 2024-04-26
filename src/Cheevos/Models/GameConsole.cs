namespace PolyhydraGames.RACheevos.Models;
 
    public class GameConsole
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string IconURL { get; set; }
        public bool Active { get; set; }
        public bool IsGameSystem { get; set; }
    }