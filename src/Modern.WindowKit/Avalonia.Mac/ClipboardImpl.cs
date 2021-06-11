#nullable disable

// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Modern.WindowKit.Input.Platform;
using Avalonia.Native.Interop;
using Modern.WindowKit.Platform.Interop;

namespace Modern.WindowKit.Native
{
    class ClipboardImpl : IClipboard
    {
        private IAvnClipboard _native;

        public ClipboardImpl(IAvnClipboard native)
        {
            _native = native;
        }

        public Task ClearAsync()
        {
            _native.Clear();

            return Task.CompletedTask;
        }

        public unsafe Task<string> GetTextAsync()
        {
            using (var text = _native.GetText())
            {
                var result = System.Text.Encoding.UTF8.GetString((byte*)text.Pointer(), text.Length());

                return Task.FromResult(result);
            }
        }

        public Task SetTextAsync(string text)
        {
            _native.Clear();

            if (text != null)
            {
                using (var buffer = new Utf8Buffer(text))
                {
                    _native.SetText(buffer.DangerousGetHandle());
                }
            }

            return Task.CompletedTask;
        }
    }
}
