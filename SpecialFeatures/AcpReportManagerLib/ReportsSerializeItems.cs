using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Windows;
using AcpUtility;
using CommonResources;

namespace SpecialFeatures.AcpReportManagerLib
{
	// Token: 0x0200024B RID: 587
	[global::System.Serializable]
	public sealed class ReportsSerializeItems : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06001D41 RID: 7489 RVA: 0x00003FFD File Offset: 0x000021FD
		public ReportsSerializeItems()
		{
			this.sField = new global::System.Collections.Generic.Dictionary<string, int>();
			base..ctor();
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x002B0514 File Offset: 0x002AE714
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 4;
			short num;
			try
			{
				num = (short)2098633464;
				short num2 = num;
				num = (short)245078776;
				switch (num2 == num)
				{
				}
				num = (short)1231552513;
				if (num != 0)
				{
				}
				num = (short)1435435008;
				if (num != 0)
				{
				}
				info.AddValue(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힆ﮈﮎ얐漢爵욢힤풦삨쒪쎬", a_), 1);
				info.AddValue(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆ﮊﶎ햒爵", a_), this.sField);
			}
			catch (global::System.Exception ex)
			{
				global::System.Windows.MessageBox.Show(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲆ릈권ꊎ놐꒔", a_).AcpStringFormat(new object[]
				{
					global::CommonResources.AppResources.Feature_Name_Error,
					ex
				}));
			}
			num = (short)208535552;
			short num3 = num;
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x002B0638 File Offset: 0x002AE838
		internal ReportsSerializeItems(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 13;
			this.sField = new global::System.Collections.Generic.Dictionary<string, int>();
			base..ctor();
			if (info != null)
			{
				for (;;)
				{
					try
					{
						global::SpecialFeatures.AcpReportManagerLib.Global.printTemplateVersion = (int)info.GetInt16(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏ﶓ캙鍊킟캡얣튥춧ﲩ즫\udcad쎯\udbb1\udbb3\ud8b5", a_));
					}
					catch
					{
						global::SpecialFeatures.AcpReportManagerLib.Global.printTemplateVersion = 0;
					}
					try
					{
						info.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슏秊\uda9bﮝ솟횡톣풥춧", a_));
						break;
					}
					catch (global::System.Exception ex)
					{
						global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횏鍊뺝쎡즣쎥袧\udeab\udcad\udfaf삱钳鮵颷솹費쎽", a_).AcpStringFormat(new object[]
						{
							ex
						}));
						break;
					}
				}
				try
				{
					this.sField = (global::System.Collections.Generic.Dictionary<string, int>)info.GetValue(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슏秊\uda9bﮝ솟횡톣풥춧", a_), typeof(global::System.Collections.Generic.Dictionary<string, int>));
					return;
				}
				catch (global::System.Exception ex2)
				{
					global::System.Windows.MessageBox.Show(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊑ뚕떗몙꾝\udd9f", a_).AcpStringFormat(new object[]
					{
						global::CommonResources.AppResources.Feature_Name_Error,
						ex2
					}));
					return;
				}
			}
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("憐ﲑ秊", a_));
		}

		// Token: 0x04000EB5 RID: 3765
		internal global::System.Collections.Generic.Dictionary<string, int> sField;
	}
}
