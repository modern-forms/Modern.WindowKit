#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modern.WindowKit.Platform;

namespace Modern.WindowKit.Controls
{
    public abstract class FileDialog : FileSystemDialog
    {
        public List<FileDialogFilter> Filters { get; set; } = new List<FileDialogFilter>();
        public string InitialFileName { get; set; }        
    }

    public abstract class FileSystemDialog : SystemDialog
    {
        [Obsolete("Use Directory")]
        public string InitialDirectory
        {
            get => Directory;
            set => Directory = value;
        }
        public string Directory { get; set; }
    }

    public class SaveFileDialog : FileDialog
    {
        public string DefaultExtension { get; set; }

        public async Task<string> ShowAsync(IWindowBaseImpl parent)
        {
            if(parent == null)
                throw new ArgumentNullException(nameof(parent));
            return ((await AvaloniaGlobals.SystemDialogImplementation
                 .ShowFileDialogAsync(this, parent)) ??
             Array.Empty<string>()).FirstOrDefault();
        }
    }

    public class OpenFileDialog : FileDialog
    {
        public bool AllowMultiple { get; set; }

        public Task<string[]> ShowAsync(IWindowBaseImpl parent)
        {
            if(parent == null)
                throw new ArgumentNullException(nameof(parent));
            return AvaloniaGlobals.SystemDialogImplementation.ShowFileDialogAsync(this, parent);
        }
    }

    public class OpenFolderDialog : FileSystemDialog
    {
        [Obsolete("Use Directory")]
        public string DefaultDirectory
        {
            get => Directory;
            set => Directory = value;
        }
        public Task<string> ShowAsync(IWindowBaseImpl parent)
        {
            if(parent == null)
                throw new ArgumentNullException(nameof(parent));
            return AvaloniaGlobals.SystemDialogImplementation.ShowFolderDialogAsync(this, parent);
        }
    }

    public abstract class SystemDialog
    {
        public string Title { get; set; }
    }

    public class FileDialogFilter
    {
        public string Name { get; set; }
        public List<string> Extensions { get; set; } = new List<string>();
    }
}
