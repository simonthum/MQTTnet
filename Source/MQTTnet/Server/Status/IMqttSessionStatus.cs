﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQTTnet.Server.Status
{
    public interface IMqttSessionStatus
    {
        /// <summary>
        /// Gets the client identifier.
        /// Hint: This identifier needs to be unique over all used clients / devices on the broker to avoid connection issues.
        /// </summary>
        string ClientId { get; }

        /// <summary>
        /// Gets the count of messages which are not yet sent to the client but already queued.
        /// </summary>
        long PendingApplicationMessagesCount { get; }

        IDictionary<object, object> Items { get; }

        Task ClearPendingApplicationMessagesAsync();

        Task DeleteAsync();
    }
}