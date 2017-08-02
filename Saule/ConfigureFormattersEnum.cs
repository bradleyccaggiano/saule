﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saule
{
    /// <summary>
    /// Configuration enum for formatters
    /// </summary>
    public enum ConfigureFormattersEnum
    {
        /// <summary>
        /// Formatter will be inserted at the start of the collection
        /// </summary>
        AddFormatterToStart = 0,

        /// <summary>
        /// Formatter will be inserted at the end of the collection
        /// </summary>
        AddFormatterToEnd = 1,

        /// <summary>
        /// Other formatters will be cleared
        /// </summary>
        OverwriteOtherFormatters = 2,
    }
}
