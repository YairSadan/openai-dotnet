// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    internal partial class InternalComputerActionDoubleClick : ComputerCallAction
    {
        public InternalComputerActionDoubleClick(int x, int y) : base(ComputerCallActionKind.DoubleClick)
        {
            X = x;
            Y = y;
        }

        internal InternalComputerActionDoubleClick(ComputerCallActionKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, int x, int y) : base(kind, additionalBinaryDataProperties)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
