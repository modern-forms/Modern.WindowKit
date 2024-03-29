﻿using Modern.WindowKit.Input.Raw;
using Modern.WindowKit.Metadata;

namespace Modern.WindowKit.Input
{
    [PrivateApi]
    public interface IPointerDevice : IInputDevice
    {
        /// <summary>
        /// Gets a pointer for specific event args.
        /// </summary>
        /// <remarks>
        /// If pointer doesn't exist or wasn't yet created this method will return null.
        /// </remarks>
        /// <param name="ev">Raw pointer event args associated with the pointer.</param>
        /// <returns>The pointer.</returns>
        IPointer? TryGetPointer(RawPointerEventArgs ev);
    }
}
