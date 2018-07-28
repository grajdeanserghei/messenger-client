using System;
using System.Collections.Generic;
using Messenger.Client.Objects.NlpEntities;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerMessage
    {
        public String Mid { get; set; }

        public int? Seq { get; set; } = null;

        public String Text { get; set; }

        public MessengerAttachment Attachment { get; set; }

        [JsonProperty("quick_replies")]
        public ICollection<MessengerQuickReply> QuickReplies { get; set; }

        [JsonProperty("quick_reply")]
        public MessengerQuickReplyPayload QuickReply { get; set; }

        public Nlp Nlp { get; set; }

    }
}
