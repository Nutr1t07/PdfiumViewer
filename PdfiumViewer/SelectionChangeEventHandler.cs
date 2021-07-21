using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PdfiumViewer
{
    public class SelectionChangeEventArgs : EventArgs
    {
        /// <summary>
        /// Get text selected.
        /// </summary>
        public string SelectedText { get; private set; }

        public SelectionChangeEventArgs(string selectedText)
        {
            SelectedText = selectedText;
        }
    }
    public delegate void SelectionChangeEventHandler(object sender, SelectionChangeEventArgs e);
    
}
