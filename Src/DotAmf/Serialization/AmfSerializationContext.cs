﻿using DotAmf.Data;

namespace DotAmf.Serialization
{
    /// <summary>
    /// AMF serialization context.
    /// </summary>
    public struct AmfSerializationContext
    {
        /// <summary>
        /// AMF version.
        /// </summary>
        public AmfVersion AmfVersion;

        /// <summary>
        /// AMF data contract resolver.
        /// </summary>
        public IAmfContractResolver ContractResolver;
    }
}