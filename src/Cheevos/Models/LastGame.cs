namespace PolyhydraGames.RACheevos.Models;
public class LastGame
{
    public int ID { get; set; }
    public string Title { get; set; }
    public int ConsoleID { get; set; }
    public string ConsoleName { get; set; }
    public int ForumTopicID { get; set; }
    public int Flags { get; set; }
    public string ImageIcon { get; set; }
    public string ImageTitle { get; set; }
    public string ImageIngame { get; set; }
    public string ImageBoxArt { get; set; }
    public string Publisher { get; set; }
    public string Developer { get; set; }
    public string Genre { get; set; }
    public string Released { get; set; }
    public int IsFinal { get; set; }
}