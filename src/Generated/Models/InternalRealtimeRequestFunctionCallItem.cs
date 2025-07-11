// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeRequestFunctionCallItem : RealtimeItem
    {
        public InternalRealtimeRequestFunctionCallItem(string name, string callId, string arguments) : base(InternalRealtimeItemType.FunctionCall)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(callId, nameof(callId));
            Argument.AssertNotNull(arguments, nameof(arguments));

            Name = name;
            CallId = callId;
            Arguments = arguments;
        }

        internal InternalRealtimeRequestFunctionCallItem(InternalRealtimeItemType kind, string id, IDictionary<string, BinaryData> additionalBinaryDataProperties, string name, string callId, string arguments, ConversationItemStatus? status) : base(kind, id, additionalBinaryDataProperties)
        {
            Name = name;
            CallId = callId;
            Arguments = arguments;
            Status = status;
        }

        public string Name { get; }

        public string CallId { get; }

        public string Arguments { get; }

        public ConversationItemStatus? Status { get; set; }
    }
}
