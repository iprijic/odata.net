using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExperimentsLib
{
    [JsonSerializable(typeof(Customer))]
    [JsonSerializable(typeof(IEnumerable<Customer>))]
    [JsonSerializable(typeof(JsonSerializerSourceGenerationPayloadWriter.ResponseWrapper))]
    [JsonSerializable(typeof(string))]
    internal partial class SourceGenerationContext : JsonSerializerContext
    {
    }
}
