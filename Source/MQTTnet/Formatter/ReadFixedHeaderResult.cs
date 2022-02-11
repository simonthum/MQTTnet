// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MQTTnet.Formatter
{
    public struct ReadFixedHeaderResult
    {
        public static ReadFixedHeaderResult Cancelled = new ReadFixedHeaderResult
        {
            IsCancelled = true
        };
        
        public static ReadFixedHeaderResult ConnectionClosed = new ReadFixedHeaderResult
        {
            IsConnectionClosed = true
        };
        
        public bool IsCancelled { get; set; }
        
        public bool IsConnectionClosed { get; set; }

        public MqttFixedHeader FixedHeader { get; set; }
    }
}
