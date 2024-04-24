public interface LastGameEntity
{
    int ID { get; set; }
    string Title { get; set; }
    int ConsoleID { get; set; }
    int ForumTopicID { get; set; }
    int Flags { get; set; }
    string ImageIcon { get; set; }
    string ImageTitle { get; set; }
    string ImageIngame { get; set; }
    string ImageBoxArt { get; set; }
    string Publisher { get; set; }
    string Developer { get; set; }
    string Genre { get; set; }
    string Released { get; set; }
    bool IsFinal { get; set; }
    string ConsoleName { get; set; }
    string RichPresencePatch { get; set; }
}