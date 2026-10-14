using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000092 RID: 146
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DisplayCharactersList : global::System.Windows.Controls.ItemsControl
	{
		// Token: 0x060008B5 RID: 2229 RVA: 0x000275FC File Offset: 0x000257FC
		static DisplayCharactersList()
		{
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.StackPanel));
			frameworkElementFactory.SetValue(global::System.Windows.Controls.StackPanel.OrientationProperty, global::Infragistics.KnownBoxes.OrientationHorizontalBox);
			global::System.Windows.Controls.ItemsPanelTemplate itemsPanelTemplate = new global::System.Windows.Controls.ItemsPanelTemplate(frameworkElementFactory);
			itemsPanelTemplate.Seal();
			global::System.Windows.Controls.ItemsControl.ItemsPanelProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.DisplayCharactersList), new global::System.Windows.FrameworkPropertyMetadata(itemsPanelTemplate));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.DisplayCharactersList), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.DisplayCharactersList)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.DisplayCharactersList), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00027699 File Offset: 0x00025899
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Infragistics.Windows.Editors.DisplayCharacterPresenter();
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000276A0 File Offset: 0x000258A0
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);
			global::Infragistics.Windows.Editors.DisplayCharacterPresenter displayCharacterPresenter = element as global::Infragistics.Windows.Editors.DisplayCharacterPresenter;
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = item as global::Infragistics.Windows.Editors.DisplayCharBase;
			if (displayCharacterPresenter != null && displayCharBase != null)
			{
				displayCharacterPresenter.Initialize(displayCharBase);
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000276D0 File Offset: 0x000258D0
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			if (result.Height <= 4.0)
			{
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayCharsCollection = base.ItemsSource as global::Infragistics.Windows.Editors.DisplayCharsCollection;
				global::Infragistics.Windows.Editors.SectionBase sectionBase = (displayCharsCollection != null) ? displayCharsCollection.Section : null;
				if (sectionBase != null)
				{
					global::Infragistics.Windows.Editors.XamMaskedEditor maskedEdit = sectionBase.MaskedEdit;
				}
				double lineHeight = global::Infragistics.Windows.Editors.Utils.GetLineHeight(this);
				if (result.Height < lineHeight)
				{
					result.Height = lineHeight;
				}
			}
			return result;
		}
	}
}
