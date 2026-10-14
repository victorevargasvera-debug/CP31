using System;
using System.Globalization;
using Infragistics.Shared;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200032D RID: 813
	public static class Resources
	{
		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x000AAE0E File Offset: 0x000A900E
		public static global::Infragistics.Shared.ResourceCustomizer Customizer
		{
			get
			{
				return global::ResourceCustomizerLocator.Customizer;
			}
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000AAE15 File Offset: 0x000A9015
		public static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000AAE1E File Offset: 0x000A901E
		public static string GetString(string name)
		{
			return global::SR.GetString(name);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000AAE26 File Offset: 0x000A9026
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name)
		{
			return global::SR.GetDynamicResourceString(name, null, null);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x000AAE30 File Offset: 0x000A9030
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000AAE3A File Offset: 0x000A903A
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args, global::System.Globalization.CultureInfo culture)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000AAE44 File Offset: 0x000A9044
		public static object GetObject(string name)
		{
			return global::SR.GetObject(name);
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x000AAE4C File Offset: 0x000A904C
		public static global::Infragistics.Shared.DynamicResourceString FieldFixToFarEdgePrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedFieldButton_FixToFarEdgePromptProperty");
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x000AAE58 File Offset: 0x000A9058
		public static global::Infragistics.Shared.DynamicResourceString FieldFixToNearEdgePrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedFieldButton_FixToNearEdgePromptProperty");
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x000AAE64 File Offset: 0x000A9064
		public static global::Infragistics.Shared.DynamicResourceString FieldUnfixPrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedFieldButton_UnfixPromptProperty");
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x000AAE70 File Offset: 0x000A9070
		public static global::Infragistics.Shared.DynamicResourceString FilterDropDownLoadingIndicator
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FilterDropDownLoadingIndicator");
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x000AAE7C File Offset: 0x000A907C
		public static global::Infragistics.Shared.DynamicResourceString GroupByAreaPrompt1
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("GroupByArea_Prompt1");
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x000AAE88 File Offset: 0x000A9088
		public static global::Infragistics.Shared.DynamicResourceString GroupByAreaPrompt2
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("GroupByArea_Prompt2");
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x000AAE94 File Offset: 0x000A9094
		public static global::Infragistics.Shared.DynamicResourceString RecordFixToBottomPrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedRecordButton_FixToBottomPromptProperty");
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x000AAEA0 File Offset: 0x000A90A0
		public static global::Infragistics.Shared.DynamicResourceString RecordFixToTopPrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedRecordButton_FixToTopPromptProperty");
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x000AAEAC File Offset: 0x000A90AC
		public static global::Infragistics.Shared.DynamicResourceString RecordUnfixPrompt
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FixedRecordButton_UnfixPromptProperty");
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x000AAEB8 File Offset: 0x000A90B8
		public static global::Infragistics.Shared.DynamicResourceString CollapseCardToolTip
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CardHeaderPresenter_CollapseCardToolTip");
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x000AAEC4 File Offset: 0x000A90C4
		public static global::Infragistics.Shared.DynamicResourceString UnCollapseCardToolTip
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CardHeaderPresenter_UnCollapseCardToolTip");
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x000AAED0 File Offset: 0x000A90D0
		public static global::Infragistics.Shared.DynamicResourceString CollapseEmptyCellsToolTip
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CardHeaderPresenter_CollapseEmptyCellsToolTip");
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x000AAEDC File Offset: 0x000A90DC
		public static global::Infragistics.Shared.DynamicResourceString UnCollapseEmptyCellsToolTip
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CardHeaderPresenter_UnCollapseEmptyCellsToolTip");
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06002731 RID: 10033 RVA: 0x000AAEE8 File Offset: 0x000A90E8
		public static global::Infragistics.Shared.DynamicResourceString ExportStatusExportingMessage
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("RecordExportStatus_Message_Exporting");
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x000AAEF4 File Offset: 0x000A90F4
		public static global::Infragistics.Shared.DynamicResourceString ExportStatusPendingMessage
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("RecordExportStatus_Message_Pending");
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002733 RID: 10035 RVA: 0x000AAF00 File Offset: 0x000A9100
		public static global::Infragistics.Shared.DynamicResourceString ExportStatusInitializingMessage
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("RecordExportStatus_Message_Initializing");
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000AAF0C File Offset: 0x000A910C
		public static global::Infragistics.Shared.DynamicResourceString CancelExportToolTip
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("RecordExportStatus_CancelExportToolTip");
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x000AAF18 File Offset: 0x000A9118
		public static global::Infragistics.Shared.DynamicResourceString RecordFilterTreeNoSearchMatches
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("RecordFilterTreeNoSearchMatches");
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x000AAF24 File Offset: 0x000A9124
		public static global::Infragistics.Shared.DynamicResourceString CustomFilterSelectionControlOkButtonLabel
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_OkButtonLabelProperty");
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x000AAF30 File Offset: 0x000A9130
		public static global::Infragistics.Shared.DynamicResourceString CustomFilterSelectionControlCancelButtonLabel
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_CancelButtonLabelProperty");
			}
		}
	}
}
