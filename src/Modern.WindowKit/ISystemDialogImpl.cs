#nullable disable

using System.Threading.Tasks;
using Modern.WindowKit.Platform;

namespace Modern.WindowKit.Controls.Platform
{
    /// <summary>
    /// Defines a platform-specific system dialog implementation.
    /// </summary>
    public interface ISystemDialogImpl
    {
        /// <summary>
        /// Shows a file dialog.
        /// </summary>
        /// <param name="dialog">The details of the file dialog to show.</param>
        /// <param name="parent">The parent window.</param>
        /// <returns>A task returning the selected filenames.</returns>
        Task<string[]> ShowFileDialogAsync(FileDialog dialog, IWindowBaseImpl parent);

        Task<string> ShowFolderDialogAsync(OpenFolderDialog dialog, IWindowBaseImpl parent);   
    }
}
