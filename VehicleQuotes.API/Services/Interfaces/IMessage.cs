namespace ALDQuoteService.Services
{
    /// <summary>
    /// Simple interface for an integration message which can be published
    /// onto the message queue
    /// </summary>
    public interface IMessage
    {
        string Id { get; set; }
        string Status { get; set; }
    }

    public class Message : IMessage
    {
        public Message(string id, string status)
        {
            this.Id = id;
            this.Status = status;
        }

        public string Id { get; set; }
        public string Status { get; set; }
    }
}
