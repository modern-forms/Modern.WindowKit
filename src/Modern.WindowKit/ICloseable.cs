using System;

namespace Modern.WindowKit
{
    public interface ICloseable
    {
        event EventHandler? Closed;
    }
}
