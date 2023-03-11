// This script copies the files we use from Avalonia into the Modern.Forms repo.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// Paths to the local repositories
// This assumes the repositories are siblings, but you can change that here if needed
// - /code
//   - /Avalonia
//   - /Modern.WindowKit
string avalonia_repo_path = Path.Combine ("..", "Avalonia");
string modern_windowkit_repo_path = "..";

string avalonia_path = Path.Combine (avalonia_repo_path, "src");
string modern_windowkit_path = Path.Combine (modern_windowkit_repo_path, "src", "Modern.WindowKit");

CopyFile ("Avalonia.Base/Platform/AlphaFormat.cs", "AlphaFormat.cs");
CopyFile ("Avalonia.Base/Platform/Storage/FileIO/BclStorageFile.cs", "BclStorageFile.cs");
CopyFile ("Avalonia.Base/Platform/Storage/FileIO/BclStorageFolder.cs", "BclStorageFolder.cs");
CopyFile ("Avalonia.Base/Platform/Storage/FileIO/BclStorageProvider.cs", "BclStorageProvider.cs");
CopyFile ("Avalonia.Base/Media/Imaging/BitmapInterpolationMode.cs", "BitmapInterpolationMode.cs");
//CopyFile ("Avalonia.Input/Cursors.cs", "Cursors.cs");
CopyFile ("Avalonia.Base/EnumExtensions.cs", "EnumExtensions.cs");
CopyFile ("Avalonia.Base/Input/DataFormats.cs", "DataFormats.cs");
CopyFile ("Avalonia.Base/Input/DataObject.cs", "DataObject.cs");
CopyFile ("Avalonia.Base/Threading/Dispatcher.cs", "Dispatcher.cs");
CopyFile ("Avalonia.Base/Threading/DispatcherPriority.cs", "DispatcherPriority.cs");
CopyFile ("Avalonia.Controls/Platform/ExtendClientAreaChromeHints.cs", "ExtendClientAreaChromeHints.cs");
CopyFile ("Avalonia.Base/Platform/Storage/FilePickerFileType.cs", "FilePickerFileType.cs");
CopyFile ("Avalonia.Base/Platform/Storage/FilePickerFileTypes.cs", "FilePickerFileTypes.cs");
CopyFile ("Avalonia.Base/Platform/Storage/FilePickerOpenOptions.cs", "FilePickerOpenOptions.cs");
CopyFile ("Avalonia.Base/Platform/Storage/FilePickerSaveOptions.cs", "FilePickerSaveOptions.cs");
CopyFile ("Avalonia.Base/Platform/Storage/FolderPickerOpenOptions.cs", "FolderPickerOpenOptions.cs");
CopyFile ("Avalonia.Base/Platform/IBitmapImpl.cs", "IBitmapImpl.cs");
CopyFile ("Avalonia.Base/Input/Platform/IClipboard.cs", "IClipboard.cs");
CopyFile ("Avalonia.Base/Input/ICloseable.cs", "ICloseable.cs");
CopyFile ("Avalonia.Base/Input/IDataObject.cs", "IDataObject.cs");
CopyFile ("Avalonia.Base/Threading/IDispatcher.cs", "IDispatcher.cs");
CopyFile ("Avalonia.Controls/Platform/Surfaces/IFramebufferPlatformSurface.cs", "IFramebufferPlatformSurface.cs");
CopyFile ("Avalonia.Base/Input/IInputDevice.cs", "IInputDevice.cs");
CopyFile ("Avalonia.Base/Input/IKeyboardDevice.cs", "IKeyboardDevice.cs");
CopyFile ("Avalonia.Base/Platform/ILockedFramebuffer.cs", "ILockedFramebuffer.cs");
CopyFile ("Avalonia.Base/Input/IMouseDevice.cs", "IMouseDevice.cs");
CopyFile ("Avalonia.Base/Platform/IPlatformHandle.cs", "IPlatformHandle.cs");
CopyFile ("Avalonia.Controls/Platform/IPlatformNativeSurfaceHandle.cs", "IPlatformNativeSurfaceHandle.cs");
CopyFile ("Avalonia.Base/Platform/IPlatformSettings.cs", "IPlatformSettings.cs");
CopyFile ("Avalonia.Base/Platform/IPlatformThreadingInterface.cs", "IPlatformThreadingInterface.cs");
CopyFile ("Avalonia.Base/Input/IPointer.cs", "IPointer.cs");
CopyFile ("Avalonia.Base/Input/IPointerDevice.cs", "IPointerDevice.cs");
CopyFile ("Avalonia.Controls/Platform/IPopupImpl.cs", "IPopupImpl.cs");
CopyFile ("Avalonia.Controls/Primitives/PopupPositioning/IPopupPositioner.cs", "IPopupPositioner.cs");
CopyFile ("Avalonia.Base/Platform/IRuntimePlatform.cs", "IRuntimePlatform.cs");
CopyFile ("Avalonia.Controls/Platform/IScreenImpl.cs", "IScreenImpl.cs");
//CopyFile ("Avalonia.Input/Platform/IStandardCursorFactory.cs", "IStandardCursorFactory.cs");
CopyFile ("Avalonia.Base/Platform/Storage/IStorageBookmarkItem.cs", "IStorageBookmarkItem.cs");
CopyFile ("Avalonia.Base/Platform/Storage/IStorageFile.cs", "IStorageFile.cs");
CopyFile ("Avalonia.Base/Platform/Storage/IStorageFolder.cs", "IStorageFolder.cs");
CopyFile ("Avalonia.Base/Platform/Storage/IStorageItem.cs", "IStorageItem.cs");
CopyFile ("Avalonia.Base/Platform/Storage/IStorageProvider.cs", "IStorageProvider.cs");
CopyFile ("Avalonia.Controls/Platform/ITopLevelImpl.cs", "ITopLevelImpl.cs");
CopyFile ("Avalonia.Controls/Platform/ITopLevelImplWithStorageProvider.cs", "ITopLevelImplWithStorageProvider.cs");
CopyFile ("Avalonia.Controls/Platform/IWindowBaseImpl.cs", "IWindowBaseImpl.cs");
CopyFile ("Avalonia.Controls/Platform/IWindowImpl.cs", "IWindowImpl.cs");
CopyFile ("Avalonia.Controls/Platform/IWindowingPlatform.cs", "IWindowingPlatform.cs");
CopyFile ("Avalonia.Base/Platform/IWriteableBitmapImpl.cs", "IWriteableBitmapImpl.cs");
CopyFile ("Avalonia.Base/Threading/JobRunner.cs", "JobRunner.cs");
CopyFile ("Avalonia.Base/Input/Key.cs", "Key.cs");
CopyFile ("Avalonia.Base/Input/KeyboardDevice.cs", "KeyboardDevice.cs");
CopyFile ("Avalonia.Base/Platform/LockedFramebuffer.cs", "LockedFramebuffer.cs");
CopyFile ("Avalonia.Controls/Primitives/PopupPositioning/ManagedPopupPositioner.cs", "ManagedPopupPositioner.cs");
CopyFile ("Avalonia.Controls/Primitives/PopupPositioning/ManagedPopupPositionerPopupImplHelper.cs", "ManagedPopupPositionerPopupImplHelper.cs");
CopyFile ("Avalonia.Base/Utilities/MathUtilities.cs", "MathUtilities.cs");
CopyFile ("Avalonia.Base/Input/MouseDevice.cs", "MouseDevice.cs");
CopyFile ("Avalonia.Base/Metadata/NotClientImplementableAttribute.cs", "NotClientImplementableAttribute.cs");
CopyFile ("Avalonia.Base/Platform/Storage/PickerOptions.cs", "PickerOptions.cs");
CopyFile ("Avalonia.Base/Platform/PixelFormat.cs", "PixelFormat.cs");
CopyFile ("Avalonia.Base/PixelPoint.cs", "PixelPoint.cs");
CopyFile ("Avalonia.Base/PixelRect.cs", "PixelRect.cs");
CopyFile ("Avalonia.Base/PixelSize.cs", "PixelSize.cs");
CopyFile ("Avalonia.Base/Platform/PlatformHandle.cs", "PlatformHandle.cs");
CopyFile ("Avalonia.Base/Point.cs", "Point.cs");
CopyFile ("Avalonia.Base/Input/Pointer.cs", "Pointer.cs");
CopyFile ("Shared/RawEventGrouping.cs", "RawEventGrouper.cs");
CopyFile ("Avalonia.Base/Input/Raw/RawInputEventArgs.cs", "RawInputEventArgs.cs");
CopyFile ("Avalonia.Base/Input/Raw/RawKeyEventArgs.cs", "RawKeyEventArgs.cs");
CopyFile ("Avalonia.Base/Input/Raw/RawPointerEventArgs.cs", "RawPointerEventArgs.cs");
CopyFile ("Avalonia.Base/Input/Raw/RawMouseWheelEventArgs.cs", "RawMouseWheelEventArgs.cs");
CopyFile ("Avalonia.Base/Input/Raw/RawTextInputEventArgs.cs", "RawTextInputEventArgs.cs");
CopyFile ("Avalonia.Base/Input/Raw/RawTouchEventArgs.cs", "RawTouchEventArgs.cs");
CopyFile ("Avalonia.Base/Rect.cs", "Rect.cs");
//CopyFile ("Avalonia.Input/RuntimeInfo.cs", "RuntimeInfo.cs");
CopyFile ("Avalonia.Controls/Platform/Screen.cs", "Screen.cs");
CopyFile ("Avalonia.Controls/Platform/ScreenHelper.cs", "ScreenHelper.cs");
CopyFile ("Avalonia.Controls/Screens.cs", "Screens.cs");
CopyFile ("Avalonia.Controls/ApplicationLifetimes/ShutdownRequestedEventArgs.cs", "ShutdownRequestedEventArgs.cs");
CopyFile ("Avalonia.Base/Size.cs", "Size.cs");
CopyFile ("Avalonia.Base/Platform/StandardRuntimePlatform.cs", "StandardRuntimePlatform.cs");
CopyFile ("Avalonia.Base/Platform/Storage/StorageItemProperties.cs", "StorageItemProperties.cs");
CopyFile ("Avalonia.Base/Platform/Storage/FileIO/StorageProviderHelpers.cs", "StorageProviderHelpers.cs");
CopyFile ("Avalonia.Base/Utilities/StringBuilderCache.cs", "StringBuilderCache.cs");
CopyFile ("Avalonia.Base/Utilities/StringTokenizer.cs", "StringTokenizer.cs");
CopyFile ("Avalonia.Base/Thickness.cs", "Thickness.cs");
CopyFile ("Avalonia.Base/Input/TouchDevice.cs", "TouchDevice.cs");
CopyFile ("Avalonia.Base/Platform/Internal/UnmanagedBlob.cs", "UnmanagedBlob.cs");
CopyFile ("Avalonia.Base/Metadata/UnstableAttribute.cs", "UnstableAttribute.cs");
CopyFile ("Avalonia.Base/Vector.cs", "Vector.cs");
CopyFile ("Avalonia.Controls/WindowEdge.cs", "WindowEdge.cs");
CopyFile ("Avalonia.Controls/WindowState.cs", "WindowState.cs");
CopyFile ("Avalonia.Base/Platform/ICursorFactory.cs", "ICursorFactory.cs");
CopyFile ("Avalonia.Base/Platform/ICursorImpl.cs", "ICursorImpl.cs");
CopyFile ("Avalonia.Controls/WindowTransparencyLevel.cs", "WindowTransparencyLevel.cs");
CopyFile ("Avalonia.Controls/WindowClosingEventArgs.cs", "WindowClosingEventArgs.cs");
CopyFile ("Avalonia.Controls/AcrylicPlatformCompensationLevels.cs", "AcrylicPlatformCompensationLevels.cs");

// Mac Backend
CopyFile ("Avalonia.Native/AvaloniaNativeApplicationPlatform.cs", "Avalonia.Mac/AvaloniaNativeApplicationPlatform.cs");
CopyFile ("Avalonia.Native/AvaloniaNativePlatform.cs", "Avalonia.Mac/AvaloniaNativePlatform.cs");
CopyFile ("Avalonia.Native/AvaloniaNativePlatformExtensions.cs", "Avalonia.Mac/AvaloniaNativePlatformExtensions.cs");
CopyFile ("Avalonia.Native/CallbackBase.cs", "Avalonia.Mac/CallbackBase.cs");
CopyFile ("Avalonia.Native/ClipboardImpl.cs", "Avalonia.Mac/ClipboardImpl.cs");
CopyFile ("Avalonia.Native/Cursor.cs", "Avalonia.Mac/Cursor.cs");
CopyFile ("Avalonia.Native/DeferredFramebuffer.cs", "Avalonia.Mac/DeferredFramebuffer.cs");
CopyFile ("Avalonia.Native/DynLoader.cs", "Avalonia.Mac/DynLoader.cs");
CopyFile ("Avalonia.Native/Extensions.cs", "Avalonia.Mac/Extensions.cs");
CopyFile ("Avalonia.Native/Helpers.cs", "Avalonia.Mac/Helpers.cs");
CopyFile ("Avalonia.Native/PlatformThreadingInterface.cs", "Avalonia.Mac/PlatformThreadingInterface.cs");
CopyFile ("Avalonia.Native/PopupImpl.cs", "Avalonia.Mac/PopupImpl.cs");
CopyFile ("Avalonia.Native/ScreenImpl.cs", "Avalonia.Mac/ScreenImpl.cs");
CopyFile ("Avalonia.Native/SystemDialogs.cs", "Avalonia.Mac/SystemDialogs.cs");
CopyFile ("Avalonia.Native/WindowImpl.cs", "Avalonia.Mac/WindowImpl.cs");
CopyFile ("Avalonia.Native/WindowImplBase.cs", "Avalonia.Mac/WindowImplBase.cs");

// Windows Backend
CopyFile ("Windows/Avalonia.Win32/ClipboardFormats.cs", "Avalonia.Win32/ClipboardFormats.cs");
CopyFile ("Windows/Avalonia.Win32/ClipboardImpl.cs", "Avalonia.Win32/ClipboardImpl.cs");
CopyFile ("Windows/Avalonia.Win32/CursorFactory.cs", "Avalonia.Win32/CursorFactory.cs");
CopyFile ("Windows/Avalonia.Win32/DataObject.cs", "Avalonia.Win32/DataObject.cs");
CopyFile ("Windows/Avalonia.Win32/FramebufferManager.cs", "Avalonia.Win32/FramebufferManager.cs");
CopyFile ("Windows/Avalonia.Win32/WinRT/IBlurHost.cs", "Avalonia.Win32/IBlurHost.cs");
CopyFile ("Windows/Avalonia.Win32/Input/KeyInterop.cs", "Avalonia.Win32/KeyInterop.cs");
CopyFile ("Windows/Avalonia.Win32/OleDataObject.cs", "Avalonia.Win32/OleDataObject.cs");
CopyFile ("Windows/Avalonia.Win32/PlatformConstants.cs", "Avalonia.Win32/PlatformConstants.cs");
CopyFile ("Windows/Avalonia.Win32/PopupImpl.cs", "Avalonia.Win32/PopupImpl.cs");
CopyFile ("Windows/Avalonia.Win32/ScreenImpl.cs", "Avalonia.Win32/ScreenImpl.cs");
//CopyFile ("Windows/Avalonia.Win32/SystemDialogImpl.cs", "Avalonia.Win32/SystemDialogImpl.cs");
CopyFile ("Windows/Avalonia.Win32/Win32Platform.cs", "Avalonia.Win32/Win32Platform.cs");
//CopyFile ("Windows/Avalonia.Win32/WindowFramebuffer.cs", "Avalonia.Win32/WindowFramebuffer.cs");
CopyFile ("Windows/Avalonia.Win32/WindowImpl.cs", "Avalonia.Win32/WindowImpl.cs");
CopyFile ("Windows/Avalonia.Win32/WindowImpl.AppWndProc.cs", "Avalonia.Win32/WindowImpl.AppWndProc.cs");
CopyFile ("Windows/Avalonia.Win32/Input/WindowsKeyboardDevice.cs", "Avalonia.Win32/WindowsKeyboardDevice.cs");
CopyFile ("Windows/Avalonia.Win32/Input/WindowsMouseDevice.cs", "Avalonia.Win32/WindowsMouseDevice.cs");
CopyFile ("Windows/Avalonia.Win32/WinScreen.cs", "Avalonia.Win32/WinScreen.cs");
CopyFile ("Windows/Avalonia.Win32/Win32StorageProvider.cs", "Avalonia.Win32/Win32StorageProvider.cs");
CopyFile ("Windows/Avalonia.Win32/Win32TypeExtensions.cs", "Avalonia.Win32/Win32TypeExtensions.cs");
//CopyFile ("Windows/Avalonia.Win32/Interop/UnmanagedMethods.cs", "Avalonia.Win32/Interop/UnmanagedMethods.cs");

// X11 Backend
CopyFile ("Avalonia.X11/NativeDialogs/CompositeStorageProvider.cs", "Avalonia.X11/CompositeStorageProvider.cs");
CopyFile ("Avalonia.X11/NativeDialogs/Gtk.cs", "Avalonia.X11/Gtk.cs");
CopyFile ("Avalonia.X11/NativeDialogs/GtkNativeFileDialogs.cs", "Avalonia.X11/GtkNativeFileDialogs.cs");
CopyFile ("Avalonia.X11/Keysyms.cs", "Avalonia.X11/Keysyms.cs");
CopyFile ("Avalonia.X11/TransparencyHelper.cs", "Avalonia.X11/TransparencyHelper.cs");
CopyFile ("Avalonia.Base/Platform/Interop/Utf8Buffer.cs", "Avalonia.X11/Utf8Buffer.cs");
CopyFile ("Avalonia.X11/X11Atoms.cs", "Avalonia.X11/X11Atoms.cs");
CopyFile ("Avalonia.X11/X11Clipboard.cs", "Avalonia.X11/X11Clipboard.cs");
CopyFile ("Avalonia.X11/X11CursorFactory.cs", "Avalonia.X11/X11CursorFactory.cs");
CopyFile ("Avalonia.X11/X11Enums.cs", "Avalonia.X11/X11Enums.cs");
CopyFile ("Avalonia.X11/X11Exception.cs", "Avalonia.X11/X11Exception.cs");
CopyFile ("Avalonia.X11/X11Framebuffer.cs", "Avalonia.X11/X11Framebuffer.cs");
CopyFile ("Avalonia.X11/X11FramebufferSurface.cs", "Avalonia.X11/X11FramebufferSurface.cs");
CopyFile ("Avalonia.X11/X11Globals.cs", "Avalonia.X11/X11Globals.cs");
CopyFile ("Avalonia.X11/X11Info.cs", "Avalonia.X11/X11Info.cs");
CopyFile ("Avalonia.X11/X11KeyTransform.cs", "Avalonia.X11/X11KeyTransform.cs");
CopyFile ("Avalonia.X11/X11Platform.cs", "Avalonia.X11/X11Platform.cs");
CopyFile ("Avalonia.X11/X11PlatformThreading.cs", "Avalonia.X11/X11PlatformThreading.cs");
CopyFile ("Avalonia.X11/X11Screens.cs", "Avalonia.X11/X11Screens.cs");
CopyFile ("Avalonia.X11/X11Structs.cs", "Avalonia.X11/X11Structs.cs");
CopyFile ("Avalonia.X11/X11Window.cs", "Avalonia.X11/X11Window.cs");
CopyFile ("Avalonia.X11/X11Window.Ime.cs", "Avalonia.X11/X11Window.Ime.cs");
CopyFile ("Avalonia.X11/X11Window.Xim.cs", "Avalonia.X11/X11Window.Xim.cs");
CopyFile ("Avalonia.X11/XError.cs", "Avalonia.X11/XError.cs");
CopyFile ("Avalonia.X11/XI2Manager.cs", "Avalonia.X11/XI2Manager.cs");
CopyFile ("Avalonia.X11/XIStructs.cs", "Avalonia.X11/XIStructs.cs");
CopyFile ("Avalonia.X11/XLib.cs", "Avalonia.X11/XLib.cs");

// Skia Backend
CopyFile ("Skia/Avalonia.Skia/Helpers/ImageSavingHelper.cs", "Avalonia.Skia/ImageSavingHelper.cs");
CopyFile ("Skia/Avalonia.Skia/Helpers/PixelFormatHelper.cs", "Avalonia.Skia/PixelFormatHelper.cs");
CopyFile ("Skia/Avalonia.Skia/SkiaOptions.cs", "Avalonia.Skia/SkiaOptions.cs");
CopyFile ("Skia/Avalonia.Skia/SkiaPlatform.cs", "Avalonia.Skia/SkiaPlatform.cs");
CopyFile ("Skia/Avalonia.Skia/SkiaSharpExtensions.cs", "Avalonia.Skia/SkiaSharpExtensions.cs");
CopyFile ("Skia/Avalonia.Skia/WriteableBitmapImpl.cs", "Avalonia.Skia/WriteableBitmapImpl.cs");

// Mac Native Bits
var native_dir = Path.Combine (avalonia_path, "..", "native", "Avalonia.Native");
var mfmb_dir = Path.Combine ("..", "..", "Modern.Forms.Mac.Backend");

DirectoryCopy (Path.Combine (native_dir, "inc"), Path.Combine (mfmb_dir, "inc"), true);
DirectoryCopy (Path.Combine (native_dir, "src"), Path.Combine (mfmb_dir, "src"), true);

//CopyFile ("Avalonia.Native/avn.idl", "../../../../Modern.Forms.Mac.Backend/src/avn.idl");

private void CopyFile (string src, string dst)
{
    var full_src = Path.Combine (avalonia_path, src);
    var full_dst = Path.Combine (modern_windowkit_path, dst);

    var text = File.ReadAllText (full_src);

    // Convert namespaces to WindowKit
    text = text.Replace ("namespace Avalonia", "namespace Modern.WindowKit");
    text = text.Replace ("using Avalonia", "using Modern.WindowKit");
    text = text.Replace ("using static Avalonia", "using static Modern.WindowKit");
    text = text.Replace ("using IDataObject = Avalonia.Input.IDataObject", "using IDataObject = Modern.WindowKit.Input.IDataObject");
    text = text.Replace ("class OleDataObject : Avalonia.Input.IDataObject", "class OleDataObject : Modern.WindowKit.Input.IDataObject");

    // Some namespaces we do not use
    text = Comment (text, "using Modern.WindowKit.Animation");
    text = Comment (text, "using Modern.WindowKit.Animation.Animators");
    text = Comment (text, "using Modern.WindowKit.Interactivity");
    text = Comment (text, "using Modern.WindowKit.Media");
    text = Comment (text, "using Modern.WindowKit.OpenGL");
    text = Comment (text, "using Modern.WindowKit.Rendering");
    text = Comment (text, "using Modern.WindowKit.VisualTree");
    text = Comment (text, "using Modern.WindowKit.X11.Glx");
    text = Comment (text, "using JetBrains.Annotations");
    text = Comment (text, "using System.ComponentModel.DataAnnotation");
    text = Comment (text, "using System.Reactive.Linq");

    // MicroCom namespaces
    text = text.Replace ("using Modern.WindowKit.Native.Interop", "using Modern.WindowKit.Mac.Interop");
    text = text.Replace ("using MicroCom.Runtime", "using Modern.WindowKit.MicroCom");

    // We don't use Avalonia's DI
    text = text.Replace ("AvaloniaLocator.Current.GetService<ICursorFactory>()", "AvaloniaGlobals.GetService<ICursorFactory>()");
    text = text.Replace ("AvaloniaLocator.Current.GetService<IPlatformThreadingInterface>()", "AvaloniaGlobals.GetService<IPlatformThreadingInterface>()");
    text = text.Replace ("AvaloniaLocator.Current.GetService<ISystemDialogImpl>()", "AvaloniaGlobals.GetService<ISystemDialogImpl>()");
    text = text.Replace ("AvaloniaLocator.Current.GetService<IRuntimePlatform>()", "AvaloniaGlobals.GetService<IRuntimePlatform>()");
    text = text.Replace ("AvaloniaLocator.Current?.GetService<IRuntimePlatform>()", "AvaloniaGlobals.GetService<IRuntimePlatform>()");
    text = text.Replace ("AvaloniaLocator.Current.GetRequiredService<ICursorFactory>()", "AvaloniaGlobals.GetRequiredService<ICursorFactory>()");
    text = text.Replace ("AvaloniaLocator.Current.GetRequiredService<IPlatformThreadingInterface>()", "AvaloniaGlobals.GetRequiredService<IPlatformThreadingInterface>()");
    text = text.Replace ("AvaloniaLocator.Current.GetRequiredService<ISystemDialogImpl>()", "AvaloniaGlobals.GetRequiredService<ISystemDialogImpl>()");
    text = text.Replace ("AvaloniaLocator.Current.GetRequiredService<IRuntimePlatform>()", "AvaloniaGlobals.GetRequiredService<IRuntimePlatform>()");
    text = text.Replace ("AvaloniaLocator.Current?.GetRequiredService<IRuntimePlatform>()", "AvaloniaGlobals.GetRequiredService<IRuntimePlatform>()");

    // Other fixups
    text = Comment (text, "Contract.Requires");
    text = Comment (text, "Animation.Animation.RegisterAnimator");
    text = Comment (text, "[Pure]");
    
    text = text.Replace("////using Modern.WindowKit", "//using Modern.WindowKit");

    // File specific fixups
    switch (Path.GetFileName (dst)) {
        case "ICloseable.cs":
            text = text.Replace ("namespace Modern.WindowKit.Input", "namespace Modern.WindowKit");
            break;
        case "PixelPoint.cs":
        case "Point.cs":
        case "Pointer.cs":
        case "RawTextInputEventArgs.cs":
        case "X11CursorFactory.cs":
        case "AvaloniaNativePlatform.cs":
            text = text.Replace ("public interface", "public partial interface");
            text = text.Replace ("readonly struct", "readonly partial struct");
            text = text.Replace ("public class", "public partial class");
            //text = text.Replace ("class X11CursorFactory", "partial class X11CursorFactory");
            text = text.Replace ("class AvaloniaNativePlatform", "partial class AvaloniaNativePlatform");
            text = text.Replace ("private static partial CursorFontShape[] GetAllCursorShapes();", "private static CursorFontShape[] GetAllCursorShapes() => Enum.GetValues(typeof(CursorFontShape)).Cast<CursorFontShape>().ToArray();");
            break;
        case "ISystemDialogImpl.cs":
        case "SystemDialog.cs":
        case "SystemDialogs.cs":
            text = text.Replace ("Window parent", "WindowKit.Platform.IWindowBaseImpl parent");
            text = text.Replace ("?.PlatformImpl", "");
            text = text.Replace ("IWindowImpl parentWindow", "IWindowBaseImpl parentWindow");
            text = text.Replace ("Window window", "WindowKit.Platform.IWindowBaseImpl window");
            text = text.Replace ("string title, IWindowImpl parent", "string title, IWindowBaseImpl parent");
            break;
        case "GtkNativeFileDialogs.cs":
            text = text.Replace ("?.PlatformImpl", "");
            text = text.Replace ("IWindowImpl parentWindow", "IWindowBaseImpl parentWindow");
            text = text.Replace ("string title, IWindowImpl parent", "string title, IWindowBaseImpl parent");
            break;
        case "KeyInterop.cs":
            text = text.Replace ("static class", "public static class");
            break;
        case "IWindowImpl.cs":
            text = text.Replace ("IWindowIconImpl", "SkiaSharp.SKBitmap");
            break;
        case "PopupImpl.cs":        // Mac
            text = text.Replace ("base(factory, opts, glFeature)", "base(factory, opts)");
            text = text.Replace ("context?.Context", "null");
            text = text.Replace ("_factory, _opts, _glFeature, this", "_factory, _opts, this");
            text = text.Replace ("factory.CreateScreens(), context);", "factory.CreateScreens());");
            text = text.Replace ("e, _glFeature.SharedContext.Context", "e, null");
            break;
        case "WindowImpl.cs":
            // Win
            text = text.Replace ("ShowInTaskbar = false", "ShowInTaskbar = true");
            text = text.Replace ("if (!_shown)", "if ((Handle?.Handle ?? IntPtr.Zero) == IntPtr.Zero)");
            // Mac
            text = text.Replace (", AvaloniaNativePlatformOptions opts,", ", AvaloniaNativePlatformOptions opts");
            text = text.Replace ("AvaloniaNativeGlPlatformGraphics glFeature) : base(factory, opts, glFeature)", ") : base(factory, opts)");
            text = text.Replace ("context?.Context", "null");
            text = text.Replace ("factory.CreateScreens(), context);", "factory.CreateScreens());");
            text = text.Replace ("internal class WindowImpl", "internal partial class WindowImpl");
            text = text.Replace ("return true.AsComBool();", "return false.AsComBool();");
            text = text.Replace ("e, glFeature.SharedContext.Context", "e, null");
            break;
        case "WindowImplBase.cs":   // Mac
            text = text.Replace ("unsafe class", "unsafe partial class");
            text = text.Replace ("get => AvnAutomationPeer.Wrap(_parent.GetAutomationPeer());", "get => null;");
            text = text.Replace ("IFramebufferPlatformSurface, ITopLevelImplWithNativeControlHost, ITopLevelImplWithStorageProvider", "IFramebufferPlatformSurface, ITopLevelImplWithStorageProvider //, ITopLevelImplWithNativeControlHost");
            text = text.Replace ("abstract class WindowBaseImpl", "abstract partial class WindowBaseImpl");
            text = text.Replace ("AvaloniaNativePlatformOptions opts,", "AvaloniaNativePlatformOptions opts)");
            text = text.Replace ("IAvnScreens screens, IGlContext glContext", "IAvnScreens screens");
            text = text.Replace ("_inputRoot, text)", "_inputRoot, text, RawInputModifiers.None)");
            text = text.Replace ("AvaloniaLocator.Current.GetService<IKeyboardDevice>()", "AvaloniaNativePlatform.KeyboardDevice");
            break;
        case "WindowImpl.AppWndProc.cs":    // Win
            text = text.Replace ("new string((char)ToInt32(wParam), 1));", "new string((char)ToInt32(wParam), 1), WindowsKeyboardDevice.Instance.Modifiers);");
            break;
        case "X11Platform.cs":
            text = text.Replace ("Avalonia.X11.X11Screens", "X11.X11Screens");
            break;
        case "X11Window.Ime.cs":
            text = text.Replace ("UpdateImePosition() => _imeControl?", "UpdateImePosition() { } // => _imeControl?");
            text = text.Replace ("_inputRoot, text),", "_inputRoot, text, (RawInputModifiers)ev.KeyEvent.state),");
            text = text.Replace ("[NotNull] ", "");
            break;
        case "RawEventGrouper.cs":
            text = text.Replace ("PooledList", "List");
            break;
        case "StandardRuntimePlatform.cs":
            text = text.Replace ("public class", "internal class");
            break;
        case "DataObject.cs":
            text = text.Replace ("Avalonia.Win32.Interop.FORMATETC", "Modern.WindowKit.Win32.Interop.FORMATETC");
            break;
        case "ScreenImpl.cs":
            text = text.Replace ("ref Rect", "ref Modern.WindowKit.Win32.Interop.Rect");
            break;
    }

    var dest_lines = File.Exists (full_dst) ? CommentDiffs (text, full_dst) : new[] { text };
    File.WriteAllLines (full_dst, dest_lines, Encoding.UTF8);
}

// We prefer to comment unused stuff so we can tell stuff we've disabled versus new stuff in diffs
private string Comment (string text, string str) => text.Replace (str, "//" + str);

// Try to remove stuff we've commented from the new files for easier diffs
private string[] CommentDiffs (string text, string dest)
{
    var dest_lines = File.ReadAllLines (dest);

    var src_lines = new List<string> ();
    using var sw = new StringReader (text);
    string s;

    while ((s = sw.ReadLine ()) != null)
        src_lines.Add (s);

    for (var i = 0; i < Math.Min (src_lines.Count, dest_lines.Length); i++) {
        if (StripWhitespace (src_lines[i]) == StripWhitespace (dest_lines[i]))
            src_lines[i] = dest_lines[i];
    }

    return src_lines.ToArray ();
}

private string StripWhitespace (string str) => str.Replace (" ", "").Replace ("\t", "").Replace ("/", "").Replace ("/*", "").Replace ("*/", "");

private static void DirectoryCopy (string sourceDirName, string destDirName, bool copySubDirs)
{
    // Get the subdirectories for the specified directory.
    var dir = new DirectoryInfo (sourceDirName);

    if (!dir.Exists)
    {
        throw new DirectoryNotFoundException(
            "Source directory does not exist or could not be found: "
            + sourceDirName);
    }

    var dirs = dir.GetDirectories ();
    
    // If the destination directory doesn't exist, create it.
    if (!Directory.Exists (destDirName))
    {
        Directory.CreateDirectory (destDirName);
    }
    
    // Get the files in the directory and copy them to the new location.
    var files = dir.GetFiles ();
    
    foreach (FileInfo file in files)
    {
        var temppath = Path.Combine (destDirName, file.Name);
        file.CopyTo (temppath, true);
    }

    // If copying subdirectories, copy them and their contents to new location.
    if (copySubDirs)
    {
        foreach (var subdir in dirs)
        {
            var temppath = Path.Combine (destDirName, subdir.Name);
            DirectoryCopy (subdir.FullName, temppath, copySubDirs);
        }
    }
}
