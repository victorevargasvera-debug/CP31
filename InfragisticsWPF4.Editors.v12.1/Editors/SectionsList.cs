using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers.Editors;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200008A RID: 138
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SectionsList : global::System.Windows.Controls.ItemsControl
	{
		// Token: 0x06000841 RID: 2113 RVA: 0x000256C4 File Offset: 0x000238C4
		static SectionsList()
		{
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.StackPanel));
			frameworkElementFactory.SetValue(global::System.Windows.Controls.StackPanel.OrientationProperty, global::Infragistics.KnownBoxes.OrientationHorizontalBox);
			global::System.Windows.Controls.ItemsPanelTemplate itemsPanelTemplate = new global::System.Windows.Controls.ItemsPanelTemplate(frameworkElementFactory);
			itemsPanelTemplate.Seal();
			global::System.Windows.Controls.ItemsControl.ItemsPanelProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.SectionsList), new global::System.Windows.FrameworkPropertyMetadata(itemsPanelTemplate));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.SectionsList), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.SectionsList)));
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.SectionsList), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Style()));
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00025761 File Offset: 0x00023961
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Infragistics.Windows.Editors.SectionPresenter();
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00025768 File Offset: 0x00023968
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			global::System.Windows.Size result = base.MeasureOverride(constraint);
			global::System.Windows.FontStyle fontStyle = base.FontStyle;
			if (fontStyle == global::System.Windows.FontStyles.Italic || fontStyle == global::System.Windows.FontStyles.Oblique)
			{
				double fontSize = base.FontSize;
				global::System.Windows.FontWeight fontWeight = base.FontWeight;
				double num = 8.0;
				if (fontWeight == global::System.Windows.FontWeights.Bold || fontWeight == global::System.Windows.FontWeights.Black || fontWeight == global::System.Windows.FontWeights.Heavy || fontWeight == global::System.Windows.FontWeights.UltraBold || fontWeight == global::System.Windows.FontWeights.ExtraBold)
				{
					num = 6.0;
				}
				result.Width += fontSize / num;
			}
			return result;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00025816 File Offset: 0x00023A16
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.SectionsListAutomationPeer(this);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00025820 File Offset: 0x00023A20
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);
			global::Infragistics.Windows.Editors.SectionPresenter sectionPresenter = element as global::Infragistics.Windows.Editors.SectionPresenter;
			global::Infragistics.Windows.Editors.SectionBase sectionBase = item as global::Infragistics.Windows.Editors.SectionBase;
			if (sectionPresenter != null && sectionBase != null)
			{
				sectionPresenter.Initialize(sectionBase);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00025850 File Offset: 0x00023A50
		internal global::Infragistics.Windows.Editors.SectionsCollection Sections
		{
			get
			{
				return base.ItemsSource as global::Infragistics.Windows.Editors.SectionsCollection;
			}
		}
	}
}
