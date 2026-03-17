using System.Collections;
using NUnit.Framework;
using Tomlyn;
using Tomlyn.Model;
using Tomlyn.Parsing;
using UnityEngine;
using UnityEngine.TestTools;
#nullable enable
namespace Tomlyn.Tests
{
    [TestFixture]
    public sealed class DoubleFormattingTests
    {
        private sealed class Model
        {
            public double Value { get; set; }
        }

        [Test]
        public void SerializeDeserialize_Double_Roundtrips()
        {
            const double value = 126.92842769438576;

            var toml = TomlSerializer.Serialize(new Model { Value = value });
            var roundtrip = TomlSerializer.Deserialize<Model>(toml);

            Assert.That(roundtrip, Is.Not.Null);
            Assert.That(roundtrip!.Value, Is.EqualTo(value));
        }
    }
}
