using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000033 RID: 51
	public abstract class ConditionalFormattingRuleBase : global::Infragistics.DependencyObjectNotifier, global::Infragistics.Controls.Grids.IConditionalFormattingRule, global::System.ComponentModel.INotifyPropertyChanged, global::Infragistics.IProvidePropertyPersistenceSettings
	{
		// Token: 0x06000254 RID: 596 RVA: 0x0000C098 File Offset: 0x0000A298
		protected internal static global::System.Windows.Style CreateStyle(global::System.Windows.Media.Color color)
		{
			global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl));
			global::System.Windows.Media.Brush value = new global::System.Windows.Media.SolidColorBrush(color);
			style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.BackgroundProperty, value));
			style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.AltBackgroundProperty, new global::System.Windows.Media.SolidColorBrush(color)));
			return style;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		protected internal static double CalculateColorSlope(double minValue, double maxValue, byte minColor, byte maxColor)
		{
			double num = maxValue - minValue;
			if (num == 0.0)
			{
				return 0.0;
			}
			return (double)(maxColor - minColor) / num;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000C11D File Offset: 0x0000A31D
		protected internal static double CalculateYIntercept(double slope, double value, byte colorValue)
		{
			return (double)colorValue - slope * value;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000C125 File Offset: 0x0000A325
		// (set) Token: 0x06000258 RID: 600 RVA: 0x0000C12D File Offset: 0x0000A32D
		public global::Infragistics.Controls.Grids.Column Column { get; protected internal set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000C136 File Offset: 0x0000A336
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0000C148 File Offset: 0x0000A348
		public bool IsTerminalRule
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.IsTerminalRuleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.IsTerminalRuleProperty, value);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000C15C File Offset: 0x0000A35C
		private static void IsTerminalRuleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase conditionalFormattingRuleBase = (global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase)obj;
			conditionalFormattingRuleBase.OnPropertyChanged("IsTerminalRule");
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0000C17B File Offset: 0x0000A37B
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0000C18D File Offset: 0x0000A38D
		public global::Infragistics.Controls.Grids.StyleScope StyleScope
		{
			get
			{
				return (global::Infragistics.Controls.Grids.StyleScope)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.StyleScopeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.StyleScopeProperty, value);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		private static void StyleScopeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase conditionalFormattingRuleBase = (global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase)obj;
			conditionalFormattingRuleBase.OnPropertyChanged("StyleScope");
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000C1BF File Offset: 0x0000A3BF
		// (set) Token: 0x06000260 RID: 608 RVA: 0x0000C1D1 File Offset: 0x0000A3D1
		public bool ShouldRefreshOnDataChange
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.ShouldRefreshOnDataChangeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.ShouldRefreshOnDataChangeProperty, value);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		private static void ShouldRefreshOnDataChangeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase conditionalFormattingRuleBase = (global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase)obj;
			conditionalFormattingRuleBase.OnPropertyChanged("ShouldRefreshOnDataChange");
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000C203 File Offset: 0x0000A403
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0000C215 File Offset: 0x0000A415
		public global::System.Windows.Visibility CellValueVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CellValueVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CellValueVisibilityProperty, value);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000C228 File Offset: 0x0000A428
		private static void CellValueVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase conditionalFormattingRuleBase = (global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase)obj;
			conditionalFormattingRuleBase.OnPropertyChanged("CellValueVisibility");
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000C247 File Offset: 0x0000A447
		// (set) Token: 0x06000266 RID: 614 RVA: 0x0000C259 File Offset: 0x0000A459
		public global::Infragistics.EvaluationStage RuleExecution
		{
			get
			{
				return (global::Infragistics.EvaluationStage)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.RuleExecutionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.RuleExecutionProperty, value);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000C26C File Offset: 0x0000A46C
		private static void RuleExecutionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase conditionalFormattingRuleBase = (global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase)obj;
			conditionalFormattingRuleBase.OnPropertyChanged("RuleExecution");
		}

		// Token: 0x06000268 RID: 616
		protected internal abstract global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy();

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000C28B File Offset: 0x0000A48B
		bool global::Infragistics.Controls.Grids.IConditionalFormattingRule.IsTerminalRule
		{
			get
			{
				return this.IsTerminalRule;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000C293 File Offset: 0x0000A493
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0000C29B File Offset: 0x0000A49B
		global::Infragistics.Controls.Grids.Column global::Infragistics.Controls.Grids.IConditionalFormattingRule.Column
		{
			get
			{
				return this.Column;
			}
			set
			{
				this.Column = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
		global::Infragistics.Controls.Grids.StyleScope global::Infragistics.Controls.Grids.IConditionalFormattingRule.StyleScope
		{
			get
			{
				return this.StyleScope;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000C2AC File Offset: 0x0000A4AC
		bool global::Infragistics.Controls.Grids.IConditionalFormattingRule.ShouldRefreshOnDataChange
		{
			get
			{
				return this.ShouldRefreshOnDataChange;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
		global::System.Windows.Visibility global::Infragistics.Controls.Grids.IConditionalFormattingRule.CellValueVisibility
		{
			get
			{
				return this.CellValueVisibility;
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000C2BC File Offset: 0x0000A4BC
		global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy global::Infragistics.Controls.Grids.IConditionalFormattingRule.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
		global::Infragistics.EvaluationStage global::Infragistics.Controls.Grids.IConditionalFormattingRule.RuleExecution
		{
			get
			{
				return this.RuleExecution;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000C2CC File Offset: 0x0000A4CC
		protected virtual global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				if (this._propertiesThatShouldntBePersisted == null)
				{
					this._propertiesThatShouldntBePersisted = new global::System.Collections.Generic.List<string>
					{
						"Column"
					};
				}
				return this._propertiesThatShouldntBePersisted;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000C2FF File Offset: 0x0000A4FF
		protected virtual global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000C302 File Offset: 0x0000A502
		protected virtual void FinishedLoadingPersistence()
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000C304 File Offset: 0x0000A504
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PropertiesToIgnore
		{
			get
			{
				return this.PropertiesToIgnore;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000C30C File Offset: 0x0000A50C
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PriorityProperties
		{
			get
			{
				return this.PriorityProperties;
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000C314 File Offset: 0x0000A514
		void global::Infragistics.IProvidePropertyPersistenceSettings.FinishedLoadingPersistence()
		{
			this.FinishedLoadingPersistence();
		}

		// Token: 0x0400009B RID: 155
		public static readonly global::System.Windows.DependencyProperty IsTerminalRuleProperty = global::System.Windows.DependencyProperty.Register("IsTerminalRule", typeof(bool), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.IsTerminalRuleChanged)));

		// Token: 0x0400009C RID: 156
		public static readonly global::System.Windows.DependencyProperty StyleScopeProperty = global::System.Windows.DependencyProperty.Register("StyleScope", typeof(global::Infragistics.Controls.Grids.StyleScope), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.StyleScope.Cell, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.StyleScopeChanged)));

		// Token: 0x0400009D RID: 157
		public static readonly global::System.Windows.DependencyProperty ShouldRefreshOnDataChangeProperty = global::System.Windows.DependencyProperty.Register("ShouldRefreshOnDataChange", typeof(bool), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.ShouldRefreshOnDataChangeChanged)));

		// Token: 0x0400009E RID: 158
		public static readonly global::System.Windows.DependencyProperty CellValueVisibilityProperty = global::System.Windows.DependencyProperty.Register("CellValueVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CellValueVisibilityChanged)));

		// Token: 0x0400009F RID: 159
		public static readonly global::System.Windows.DependencyProperty RuleExecutionProperty = global::System.Windows.DependencyProperty.Register("RuleExecution", typeof(global::Infragistics.EvaluationStage), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase), new global::System.Windows.PropertyMetadata(global::Infragistics.EvaluationStage.PriorToFilteringAndPaging, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.RuleExecutionChanged)));

		// Token: 0x040000A0 RID: 160
		private global::System.Collections.Generic.List<string> _propertiesThatShouldntBePersisted;
	}
}
