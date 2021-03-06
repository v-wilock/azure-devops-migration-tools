﻿using System;
using System.Collections.Generic;

namespace VstsSyncMigrator.Engine.Configuration.Processing
{
    public class LinkMigrationConfig : ITfsProcessingConfig
    {
        public string QueryBit { get; set; }
        /// <inheritdoc />
        public bool Enabled { get; set; }

        /// <inheritdoc />
        public Type Processor
        {
            get { return typeof(LinkMigrationContext); }
        }

        /// <inheritdoc />
        public bool IsProcessorCompatible(IReadOnlyList<ITfsProcessingConfig> otherProcessors)
        {
            return true;
        }
    }
}