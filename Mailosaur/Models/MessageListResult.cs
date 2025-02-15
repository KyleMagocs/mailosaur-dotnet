namespace Mailosaur.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The result of a message listing request.
    /// </summary>
    public class MessageListResult
    {
        /// <summary>
        /// Gets or sets the individual summaries of each message forming the
        /// result. Summaries are returned sorted by received date, with the
        /// most recently-received messages appearing first.
        /// </summary>
        public IList<MessageSummary> Items { get; set; }

    }
}
