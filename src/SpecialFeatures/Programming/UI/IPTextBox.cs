namespace SpecialFeatures.Programming.UI
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    internal class IPTextBox : TextBox
    {
        private int a;
        private int b;
        private bool c;

        public IPTextBox();
        private bool a(ref string A_0, out int A_1);
        protected override void OnLostFocus(RoutedEventArgs e);
        protected override void OnPreviewKeyDown(KeyEventArgs e);
        protected override void OnPreviewTextInput(TextCompositionEventArgs e);
        private void PasteCanExecute(object A_0, CanExecuteRoutedEventArgs A_1);
        private void PasteOnExecute(object A_0, ExecutedRoutedEventArgs A_1);

        internal int Min { get; set; }

        internal int Max { get; set; }
    }
}

