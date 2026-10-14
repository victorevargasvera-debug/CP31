using System;
using System.Globalization;
using Infragistics.Shared;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200036E RID: 878
	public static class Resources
	{
		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x000BF846 File Offset: 0x000BDA46
		public static global::Infragistics.Shared.ResourceCustomizer Customizer
		{
			get
			{
				return global::ResourceCustomizerLocator.Customizer;
			}
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000BF84D File Offset: 0x000BDA4D
		public static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000BF856 File Offset: 0x000BDA56
		public static string GetString(string name)
		{
			return global::SR.GetString(name);
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x000BF85E File Offset: 0x000BDA5E
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name)
		{
			return global::SR.GetDynamicResourceString(name, null, null);
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x000BF868 File Offset: 0x000BDA68
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x000BF872 File Offset: 0x000BDA72
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args, global::System.Globalization.CultureInfo culture)
		{
			return global::SR.GetDynamicResourceString(name, args, culture);
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000BF87C File Offset: 0x000BDA7C
		public static object GetObject(string name)
		{
			return global::SR.GetObject(name);
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x000BF884 File Offset: 0x000BDA84
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.FieldFixToFarEdgePrompt instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString FieldFixToFarEdgePrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedFieldButton_FixToFarEdgePromptProperty");
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x000BF890 File Offset: 0x000BDA90
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.FieldFixToNearEdgePrompt instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString FieldFixToNearEdgePrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedFieldButton_FixToNearEdgePromptProperty");
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x000BF89C File Offset: 0x000BDA9C
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.FieldUnfixPrompt instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString FieldUnfixPrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedFieldButton_UnfixPromptProperty");
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x000BF8A8 File Offset: 0x000BDAA8
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.FilterDropDownLoadingIndicator instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString FilterDropDownLoadingIndicator
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FilterDropDownLoadingIndicator");
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x000BF8B4 File Offset: 0x000BDAB4
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.GroupByAreaPrompt1 instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString GroupByAreaPrompt1
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("GroupByArea_Prompt1");
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x000BF8C0 File Offset: 0x000BDAC0
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.GroupByAreaPrompt2 instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString GroupByAreaPrompt2
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("GroupByArea_Prompt2");
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x000BF8CC File Offset: 0x000BDACC
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.RecordFixToBottomPrompt instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString RecordFixToBottomPrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedRecordButton_FixToBottomPromptProperty");
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x000BF8D8 File Offset: 0x000BDAD8
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.RecordFixToTopPrompt instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString RecordFixToTopPrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedRecordButton_FixToTopPromptProperty");
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x000BF8E4 File Offset: 0x000BDAE4
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.RecordUnfixPrompt instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString RecordUnfixPrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedRecordButton_UnfixPromptProperty");
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x000BF8F0 File Offset: 0x000BDAF0
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.CollapseCardToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString CollapseCardToolTip
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CardHeaderPresenter_CollapseCardToolTip");
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x000BF8FC File Offset: 0x000BDAFC
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.UnCollapseCardToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString UnCollapseCardToolTip
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CardHeaderPresenter_UnCollapseCardToolTip");
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000BF908 File Offset: 0x000BDB08
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.CollapseEmptyCellsToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString CollapseEmptyCellsToolTip
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CardHeaderPresenter_CollapseEmptyCellsToolTip");
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x000BF914 File Offset: 0x000BDB14
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.UnCollapseEmptyCellsToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString UnCollapseEmptyCellsToolTip
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CardHeaderPresenter_UnCollapseEmptyCellsToolTip");
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x000BF920 File Offset: 0x000BDB20
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.ExportStatusExportingMessage instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString ExportStatusExportingMessage
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("RecordExportStatus_Message_Exporting");
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x000BF92C File Offset: 0x000BDB2C
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.ExportStatusPendingMessage instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString ExportStatusPendingMessage
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("RecordExportStatus_Message_Pending");
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x000BF938 File Offset: 0x000BDB38
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.ExportStatusInitializingMessage instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString ExportStatusInitializingMessage
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("RecordExportStatus_Message_Initializing");
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x000BF944 File Offset: 0x000BDB44
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.CancelExportToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString CancelExportToolTip
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("RecordExportStatus_CancelExportToolTip");
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x000BF950 File Offset: 0x000BDB50
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.RecordFilterTreeNoSearchMatches instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString RecordFilterTreeNoSearchMatches
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("RecordFilterTreeNoSearchMatches");
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x000BF95C File Offset: 0x000BDB5C
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.CustomFilterSelectionControlOkButtonLabel instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString CustomFilterSelectionControlOkButtonLabel
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_OkButtonLabelProperty");
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x000BF968 File Offset: 0x000BDB68
		[global::System.Obsolete("This property is deprecated. Use ResourcesDataPresenter.CustomFilterSelectionControlCancelButtonLabel instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString CustomFilterSelectionControlCancelButtonLabel
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_CancelButtonLabelProperty");
			}
		}
	}
}
