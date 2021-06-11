#nullable disable

// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using Modern.WindowKit.Input;

namespace Modern.WindowKit.Platform
{
    public interface IStandardCursorFactory
    {
        IPlatformHandle GetCursor(StandardCursorType cursorType);
    }
}
