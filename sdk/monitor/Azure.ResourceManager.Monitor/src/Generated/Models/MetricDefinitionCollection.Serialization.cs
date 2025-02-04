// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class MetricDefinitionCollection
    {
        internal static MetricDefinitionCollection DeserializeMetricDefinitionCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MonitorMetricDefinition> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<MonitorMetricDefinition> array = new List<MonitorMetricDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorMetricDefinition.DeserializeMonitorMetricDefinition(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MetricDefinitionCollection(value);
        }
    }
}
