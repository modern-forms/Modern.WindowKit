﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using Modern.WindowKit.Input.Raw;
//using Modern.WindowKit.Input.TextInput;
//using Modern.WindowKit.Interactivity;
//using Modern.WindowKit.VisualTree;

namespace Modern.WindowKit.Input
{
    public class KeyboardDevice : IKeyboardDevice, INotifyPropertyChanged
    {
        //private IInputElement? _focusedElement;
        //private IInputRoot? _focusedRoot;

        public event PropertyChangedEventHandler? PropertyChanged;

        //public static IKeyboardDevice Instance => AvaloniaLocator.Current.GetService<IKeyboardDevice>();

        //public IInputManager InputManager => AvaloniaLocator.Current.GetService<IInputManager>();

        //public IFocusManager FocusManager => AvaloniaLocator.Current.GetService<IFocusManager>();
        
        // This should live in the FocusManager, but with the current outdated architecture
        // the source of truth about the input focus is in KeyboardDevice
        //private readonly TextInputMethodManager _textInputManager = new TextInputMethodManager();

        //public IInputElement? FocusedElement
        //{
        //    get
        //    {
        //        return _focusedElement;
        //    }

        //    private set
        //    {
        //        _focusedElement = value;

        //        if (_focusedElement != null && _focusedElement.IsAttachedToVisualTree)
        //        {
        //            _focusedRoot = _focusedElement.VisualRoot as IInputRoot;
        //        }
        //        else
        //        {
        //            _focusedRoot = null;
        //        }
                
        //        RaisePropertyChanged();
        //        _textInputManager.SetFocusedElement(value);
        //    }
        //}

        //private void ClearFocusWithinAncestors(IInputElement? element)
        //{
        //    var el = element;
            
        //    while (el != null)
        //    {
        //        if (el is InputElement ie)
        //        {
        //            ie.IsKeyboardFocusWithin = false;
        //        }

        //        el = (IInputElement?)el.VisualParent;
        //    }
        //}
        
        //private void ClearFocusWithin(IInputElement element, bool clearRoot)
        //{
        //    foreach (var visual in element.VisualChildren)
        //    {
        //        if (visual is IInputElement el && el.IsKeyboardFocusWithin)
        //        {
        //            ClearFocusWithin(el, true);
        //            break;
        //        }
        //    }
            
        //    if (clearRoot)
        //    {
        //        if (element is InputElement ie)
        //        {
        //            ie.IsKeyboardFocusWithin = false;
        //        }
        //    }
        //}

        //private void SetIsFocusWithin(IInputElement? oldElement, IInputElement? newElement)
        //{
        //    if (newElement == null && oldElement != null)
        //    {
        //        ClearFocusWithinAncestors(oldElement);
        //        return;
        //    }
            
        //    IInputElement? branch = null;

        //    var el = newElement;

        //    while (el != null)
        //    {
        //        if (el.IsKeyboardFocusWithin)
        //        {
        //            branch = el;
        //            break;
        //        }

        //        el = el.VisualParent as IInputElement;
        //    }

        //    el = oldElement;

        //    if (el != null && branch != null)
        //    {
        //        ClearFocusWithin(branch, false);
        //    }

        //    el = newElement;
            
        //    while (el != null && el != branch)
        //    {
        //        if (el is InputElement ie)
        //        {
        //            ie.IsKeyboardFocusWithin = true;
        //        }

        //        el = el.VisualParent as IInputElement;
        //    }
        //}
        
        //private void ClearChildrenFocusWithin(IInputElement element, bool clearRoot)
        //{
        //    foreach (var visual in element.VisualChildren)
        //    {
        //        if (visual is IInputElement el && el.IsKeyboardFocusWithin)
        //        {
        //            ClearChildrenFocusWithin(el, true);
        //            break;
        //        }
        //    }
            
        //    if (clearRoot && element is InputElement ie)
        //    {
        //        ie.IsKeyboardFocusWithin = false;
        //    }
        //}

        //public void SetFocusedElement(
        //    IInputElement? element, 
        //    NavigationMethod method,
        //    KeyModifiers keyModifiers)
        //{
        //    if (element != FocusedElement)
        //    {
        //        var interactive = FocusedElement as IInteractive;

        //        if (FocusedElement != null && 
        //            (!FocusedElement.IsAttachedToVisualTree ||
        //             _focusedRoot != element?.VisualRoot as IInputRoot) &&
        //            _focusedRoot != null)
        //        {
        //            ClearChildrenFocusWithin(_focusedRoot, true);
        //        }
                
        //        SetIsFocusWithin(FocusedElement, element);
                
        //        FocusedElement = element;

        //        interactive?.RaiseEvent(new RoutedEventArgs
        //        {
        //            RoutedEvent = InputElement.LostFocusEvent,
        //        });

        //        interactive = element as IInteractive;

        //        interactive?.RaiseEvent(new GotFocusEventArgs
        //        {
        //            RoutedEvent = InputElement.GotFocusEvent,
        //            NavigationMethod = method,
        //            KeyModifiers = keyModifiers,
        //        });
        //    }
        //}

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ProcessRawEvent(RawInputEventArgs e)
        {
            if(e.Handled)
                return;

            //var element = FocusedElement ?? e.Root;

            //if (e is RawKeyEventArgs keyInput)
            //{
            //    switch (keyInput.Type)
            //    {
            //        case RawKeyEventType.KeyDown:
            //        case RawKeyEventType.KeyUp:
            //            var routedEvent = keyInput.Type == RawKeyEventType.KeyDown
            //                ? InputElement.KeyDownEvent
            //                : InputElement.KeyUpEvent;

            //            KeyEventArgs ev = new KeyEventArgs
            //            {
            //                RoutedEvent = routedEvent,
            //                Device = this,
            //                Key = keyInput.Key,
            //                KeyModifiers = KeyModifiersUtils.ConvertToKey(keyInput.Modifiers),
            //                Source = element,
            //            };

            //            IVisual? currentHandler = element;
            //            while (currentHandler != null && !ev.Handled && keyInput.Type == RawKeyEventType.KeyDown)
            //            {
            //                var bindings = (currentHandler as IInputElement)?.KeyBindings;
            //                if (bindings != null)
            //                    foreach (var binding in bindings)
            //                    {
            //                        if (ev.Handled)
            //                            break;
            //                        binding.TryHandle(ev);
            //                    }
            //                currentHandler = currentHandler.VisualParent;
            //            }

            //            element.RaiseEvent(ev);
            //            e.Handled = ev.Handled;
            //            break;
            //    }
            //}

            //if (e is RawTextInputEventArgs text)
            //{
            //    var ev = new TextInputEventArgs()
            //    {
            //        Device = this,
            //        Text = text.Text,
            //        Source = element,
            //        RoutedEvent = InputElement.TextInputEvent
            //    };

            //    element.RaiseEvent(ev);
            //    e.Handled = ev.Handled;
            //}
        }
    }
}
