﻿#nullable disable

using System;
//using Modern.WindowKit.Controls.Primitives.PopupPositioning;
using Avalonia.Native.Interop;
using Modern.WindowKit.Platform;

namespace Modern.WindowKit.Native
{
    internal class PopupImpl : WindowBaseImpl, IPopupImpl
    {
        private readonly IAvaloniaNativeFactory _factory;
        private readonly AvaloniaNativePlatformOptions _opts;
        public PopupImpl(IAvaloniaNativeFactory factory,
            AvaloniaNativePlatformOptions opts//,
            /*IWindowBaseImpl parent*/) : base(opts)
        {
            _factory = factory;
            _opts = opts;
            using (var e = new PopupEvents(this))
            {
                Init(factory.CreatePopup(e), factory.CreateScreens());
            }
            //PopupPositioner = new ManagedPopupPositioner(new OsxManagedPopupPositionerPopupImplHelper(parent, MoveResize));
        }

        private void MoveResize(PixelPoint position, Size size, double scaling)
        {
            Position = position;
            Resize(size);
            //TODO: We ignore the scaling override for now
        }

        class PopupEvents : WindowBaseEvents, IAvnWindowEvents
        {
            readonly PopupImpl _parent;

            public PopupEvents(PopupImpl parent) : base(parent)
            {
                _parent = parent;
            }

            bool IAvnWindowEvents.Closing()
            {
                return true;
            }

            void IAvnWindowEvents.WindowStateChanged(AvnWindowState state)
            {
            }
        }

        public override IPopupImpl CreatePopup() => new PopupImpl(_factory, _opts/*, this*/);
        //public IPopupPositioner PopupPositioner { get; }
    }
}
