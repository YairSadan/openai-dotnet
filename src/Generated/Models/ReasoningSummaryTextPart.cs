// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Responses
{
    public partial class ReasoningSummaryTextPart : ReasoningSummaryPart
    {
        public ReasoningSummaryTextPart(string text) : base(InternalReasoningItemSummaryPartType.SummaryText)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
        }

        internal ReasoningSummaryTextPart(InternalReasoningItemSummaryPartType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, string text) : base(kind, additionalBinaryDataProperties)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}
