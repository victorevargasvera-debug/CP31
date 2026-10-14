namespace SpecialFeatures.Ucl.UclWide
{
    using AcpUI;
    using AcpUI.Common;
    using AcpUILib;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Markup;

    public class PageUclWide : AcpPageFeature, IAcpPageFeature, IComponentConnector
    {
        private bool a;
        internal AcpThemeBase ThemeBaseObj;
        internal Hyperlink HLinkUclWideGen;
        internal Hyperlink HLinkUCLWideLabtool;
        internal StackPanel MyStackPanel;
        internal AcpExpander ExpUclWideGen;
        internal AcpGroupBox GrpBoxGeneral;
        internal Grid StdGridGeneralGrp;
        internal AcpCustomViewCheckBox CVBtnUclEdit;
        internal AcpLabel LblUclEdit;
        internal AcpCheckBox ChkBoxUclEdit;
        internal AcpRtdButton RTDBtnUclEdit;
        internal AcpCustomViewCheckBox CVBtnHotListEdit;
        internal AcpLabel LblHotListEdit;
        internal AcpCheckBox ChkBoxHotListEdit;
        internal AcpRtdButton RTDBtnHotListEdit;
        internal AcpCustomViewCheckBox CVBtnPhoneNumEdit;
        internal AcpLabel LblPhoneNumEdit;
        internal AcpCheckBox ChkBoxPhoneNumEdit;
        internal AcpRtdButton RTDBtnPhoneNumEdit;
        internal AcpCustomViewCheckBox CVBtnRadioIdEdit;
        internal AcpLabel LblRadioIdEdit;
        internal AcpCheckBox ChkBoxRadioIdEdit;
        internal AcpRtdButton RTDBtnRadioIdEdit;
        internal AcpCustomViewCheckBox CVBtnOrderableItem;
        internal AcpLabel LblOrderableItemTest;
        internal AcpOrderableListBox OrderableItemTest;
        internal Grid CompGrpBoxGeneral;
        internal AcpCopyButton CpyBtnUclEdit;
        internal AcpCheckBox UclEditComp;
        internal AcpCopyButton CpyBtnHotListEdit;
        internal AcpCheckBox HotListEditComp;
        internal AcpCopyButton CpyBtnPhoneNumEdit;
        internal AcpCheckBox PhoneNumEditComp;
        internal AcpCopyButton CpyBtnRadioIdEdit;
        internal AcpCheckBox RadioIdEditComp;
        internal AcpCopyButton CpyBtnDataOderItem;
        internal AcpOrderableListBox DataOderItemComp;
        internal AcpExpander ExpUCLWideLabtool;
        internal AcpGroupBox GrpBoxLabtool;
        internal Grid StdGridLabtoolGrp;
        internal AcpCustomViewCheckBox CVBtnMaxContacts;
        internal AcpLabel LblMaxContacts;
        internal AcpTextBox TxtBoxMaxContactNumbers;
        internal AcpRtdButton RTDBtnMaxContacts;
        internal AcpCustomViewCheckBox CVBtnContactsCombDataMax;
        internal AcpLabel LblContactsCombinedDataMax;
        internal AcpTextBox TxtBoxContactsCombDataMax;
        internal AcpRtdButton RTDBtnContactsCombDataMax;
        internal AcpCustomViewCheckBox CVBtnMaxHotlistContacts;
        internal AcpLabel LblMaxHotlistContacts;
        internal AcpTextBox TxtBoxMaxHotlistContacts;
        internal AcpRtdButton RTDBtnMaxHotlistContacts;
        internal Grid CompGrpBoxLabtool;
        internal AcpCopyButton CpyBtnMaxContacts;
        internal AcpViewOnlyCtrl MaxContactsComp;
        internal AcpCopyButton CpyBtnContactsCombDataMax;
        internal AcpViewOnlyCtrl ContactsCombDataMaxComp;
        internal AcpCopyButton CpyBtnMaxHotlistContacts;
        internal AcpViewOnlyCtrl MaxHotlistContactsComp;
        private bool b;

        public PageUclWide();
        private void HLinkUclWideClick(object A_0, RoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

