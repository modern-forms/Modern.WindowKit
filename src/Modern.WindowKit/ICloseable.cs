﻿#nullable disable

using System;

namespace Modern.Forms
{
    /// <summary>
    /// Represents a class that can be closed.
    /// </summary>
    public interface ICloseable
    {
        /// <summary>
        /// Raised when the class is closed.
        /// </summary>
        event EventHandler Closed;
    }
}
