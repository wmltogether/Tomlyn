using System;
using NUnit.Framework;
using Tomlyn.Syntax;
using UnityEngine;
#nullable enable
namespace Tomlyn.Tests
{
    internal static class AssertHelper
    {
        public static void AreEqualNormalizeNewLine(
            string expected,
            string actual,
            bool alwaysDisplay = false,
            string? message = null
        )
        {
            expected = NormalizeEndOfLine(expected);
            actual = NormalizeEndOfLine(actual);
            if (alwaysDisplay || expected != actual)
            {
                DisplayHeader("Actual");
                Debug.Log(actual);
                DisplayHeader("Expected");
                Debug.Log(expected);
            }
            Assert.AreEqual(expected, actual, message ?? string.Empty);
        }

        public static void DisplayHeader(string name)
        {
            Debug.Log("// ----------------------------------------------------------");
            Debug.Log($"// {name}");
            Debug.Log("// ----------------------------------------------------------");
        }

        public static string NormalizeEndOfLine(string text)
        {
            return text.Replace("\r\n", "\n");
        }

        public static string ReplaceLineEndings(this string text, string? newLine = null)
        {
            newLine ??= Environment.NewLine;
            return text.Replace("\r\n", "\n").Replace("\n", newLine);
        }

        public static void Dump(string input, DocumentSyntax doc, string roundtrip)
        {
            Debug.Log("\n");
            DisplayHeader("input");
            Debug.Log(input);

            Debug.Log("\n");
            DisplayHeader("round-trip");
            Debug.Log(roundtrip);

            if (doc.Diagnostics.Count > 0)
            {
                Debug.Log("\n");
                DisplayHeader("messages");

                foreach (var syntaxMessage in doc.Diagnostics)
                {
                    Debug.Log(syntaxMessage);
                }
            }
        }
    }
}
#nullable restore