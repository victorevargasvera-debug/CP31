using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers.Editors;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000091 RID: 145
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SectionsList : global::System.Windows.Controls.ItemsControl
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x00027460 File Offset: 0x00025660
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

		// Token: 0x060008B0 RID: 2224 RVA: 0x000274FD File Offset: 0x000256FD
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Infragistics.Windows.Editors.SectionPresenter();
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00027504 File Offset: 0x00025704
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

		// Token: 0x060008B2 RID: 2226 RVA: 0x000275B2 File Offset: 0x000257B2
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.SectionsListAutomationPeer(this);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000275BC File Offset: 0x000257BC
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000275EC File Offset: 0x000257EC
		internal global::Infragistics.Windows.Editors.SectionsCollection Sections
		{
			get
			{
				return base.ItemsSource as global::Infragistics.Windows.Editors.SectionsCollection;
			}
		}
	}
}
