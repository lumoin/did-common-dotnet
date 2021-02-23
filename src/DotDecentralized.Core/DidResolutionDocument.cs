using DotDecentralized.Core.Did;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotDecentralized.Core
{
    public class DidResolutionDocument
    {
        /// <summary>
        /// https://w3c.github.io/did-core/#json-ld
        /// </summary>
        public Context? Context { get; set; }

        public DidDocument? DidDocument { get; set; }

        //https://w3c-ccg.github.io/did-resolution/#example
        public object? DidResolutionMetadata { get; set; }

        public object? DidDocumentMetadata { get; set; }
    }
}
