using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000203 RID: 515
	[global::System.Serializable]
	public class PhoneCallListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001941 RID: 6465 RVA: 0x00003CDD File Offset: 0x00001EDD
		public PhoneCallListRecset() : base(global::CommonResources.AppResources.Phone_Number_List, true, false, null)
		{
			base.Id = 2207;
			base.UIName = global::CommonResources.AppResources.Phone_Number_List;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00217CC0 File Offset: 0x00215EC0
		protected PhoneCallListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 5;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			base.UIName = global::CommonResources.AppResources.Phone_Number_List;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00217D04 File Offset: 0x00215F04
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1728066432;
			short num2 = num;
			num = (short)554316672;
			switch (num2 == num)
			{
			}
			num = (short)974913536;
			short num3 = num;
			num = (short)1231552513;
			if (num != 0)
			{
			}
			num = (short)1730150400;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.Contact.PhoneCallList(this);
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x00217DB8 File Offset: 0x00215FB8
		public override int MaxPool
		{
			get
			{
				short num = (short)1221838815;
				short num2 = num;
				num = (short)1826539487;
				switch (num2 == num)
				{
				}
				num = (short)1782513664;
				short num3 = num;
				num = (short)1139539969;
				if (num != 0)
				{
				}
				num = (short)63832064;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset._MaxPool;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x00217E68 File Offset: 0x00216068
		public override int Max
		{
			get
			{
				short num = (short)861405185;
				if (num != 0)
				{
				}
				num = (short)1175905786;
				short num2 = num;
				num = (short)1327359482;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1949499392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)321388544;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset._Max;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x00217F14 File Offset: 0x00216114
		public bool HasDiffs
		{
			get
			{
				short num = (short)974830187;
				short num2 = num;
				num = (short)1413724779;
				switch (num2 == num)
				{
				}
				num = (short)1565786112;
				short num3 = num;
				num = (short)1609629696;
				if (num != 0)
				{
				}
				num = (short)1341521921;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x00217FC4 File Offset: 0x002161C4
		public override int CounterToMax
		{
			get
			{
				short num = (short)1038680064;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					int num4;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
					for (;;)
					{
						IL_27:
						num = (short)1046478848;
						short num3 = num;
						switch (num2)
						{
						case 0:
							if (5 - num4 >= this.Max - base.Count)
							{
								num = (short)1886846977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B1;
						case 1:
							goto IL_12A;
						case 2:
							num = (short)123076609;
							if (num != 0)
							{
								goto IL_E3;
							}
							goto IL_E3;
							IL_E3:
							goto IL_12F;
							try
							{
								for (;;)
								{
									IL_12F:
									num = (short)1222705156;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											num = (short)1977510700;
											short num5 = num;
											num = (short)1171417900;
											switch ((num5 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_12F;
											default:
											{
												num = (short)1707409408;
												if (num != 0)
												{
												}
												if (!enumerator.MoveNext())
												{
													num = (short)1086062593;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
												num4 += acpRecordset.Count;
												num = (short)1727791106;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											break;
										}
										case 1:
											num = (short)1103953923;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											goto IL_232;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_16A;
											}
											continue;
										}
										IL_196:
										num = (short)1910243328;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_16A:
										goto IL_196;
									}
								}
								IL_232:
								goto IL_E5;
							}
							finally
							{
								num = (short)14548994;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)2025914369;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_2A0;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_26A;
										}
										continue;
									}
									IL_26A:
									if (enumerator == null)
									{
										break;
									}
									num = (short)203161600;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2A0:;
							}
							goto IL_2A3;
							IL_E5:
							num = (short)395378688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63;
					}
					IL_12A:
					IL_2A3:
					return this.Max - base.Count;
					IL_2B1:
					return 5 - num4;
					IL_63:
					num4 = 0;
					global::AcpBusinessLayer.Recordset recordset = (global::SpecialFeatures.Ucl.Contact.UclContactRecset)base.ParentSection.ParentRecset;
					global::SpecialFeatures.Ucl.Contact.UclContact uclContact = (global::SpecialFeatures.Ucl.Contact.UclContact)base.ParentSection.Parent;
					int index = uclContact.Parent.IndexOf(uclContact);
					enumerator = recordset[index].EmbeddedRecordsets.GetEnumerator();
					num = (short)1982660610;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x002182A4 File Offset: 0x002164A4
		public override int GetCounterToMaxCopiesOf(int index)
		{
			short num = (short)966369545;
			short num2 = num;
			num = (short)1998758153;
			switch (num2 == num)
			{
			}
			num = (short)1425473536;
			if (num != 0)
			{
			}
			num = (short)1051459584;
			short num3 = num;
			num = (short)185597953;
			if (num != 0)
			{
			}
			return this.CounterToMax;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00218354 File Offset: 0x00216554
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)470243354;
			short num2 = num;
			num = (short)1291409434;
			switch (num2 == num)
			{
			}
			num = (short)2009399296;
			if (num != 0)
			{
			}
			num = (short)555483136;
			short num3 = num;
			num = (short)176029697;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.a(record);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0021840C File Offset: 0x0021660C
		protected override void OnFinishedMoveRecord(global::AcpCommonLib.IAcpFeatureNode record, global::AcpCommonLib.IAcpFeatureNode targetRecord)
		{
			short num = (short)1155935720;
			short num2 = num;
			num = (short)1564683752;
			switch (num2 == num)
			{
			}
			num = (short)64159744;
			if (num != 0)
			{
			}
			num = (short)401670144;
			short num3 = num;
			num = (short)579862529;
			if (num != 0)
			{
			}
			base.OnFinishedMoveRecord();
			this.a(record, targetRecord);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x002184C4 File Offset: 0x002166C4
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (this.Count == 2)
					{
						num2 = (short)445906945;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16F;
				case 1:
					(this[1][10414] as global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection).UclPhone_ListinfoPhoneCategory_A00034Object.CalculateValidity();
					num2 = (short)958529538;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_106;
				case 3:
					num2 = (short)367067136;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)578551809;
					if (num2 != 0)
					{
					}
					if (this != null)
					{
						num2 = (short)787415043;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16F;
				}
				break;
			}
			IL_24:
			num2 = (short)2093598804;
			short num3 = num2;
			num2 = (short)873318484;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_106:
				num2 = (short)1483997184;
				short num4 = num2;
				break;
			}
			default:
			{
				num2 = (short)516161536;
				if (num2 != 0)
				{
				}
				num2 = (short)469499908;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			IL_16F:
			(A_0[10414] as global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection).UclPhone_CombinedID_A00035_Valid = true;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00218658 File Offset: 0x00216858
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0, global::AcpCommonLib.IAcpFeatureNode A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (this.Count == 2)
					{
						num2 = (short)941031425;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					(this[0][10414] as global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection).UclPhone_ListinfoPhoneCategory_A00034Object.CalculateValidity();
					(this[1][10414] as global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection).UclPhone_ListinfoPhoneCategory_A00034Object.CalculateValidity();
					num2 = (short)1771569154;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_12B;
				case 3:
					num2 = (short)52232192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this != null)
					{
						num2 = (short)382271491;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				break;
			}
			IL_24:
			num2 = (short)1440693106;
			short num3 = num2;
			num2 = (short)505101170;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_12B:
				num2 = (short)902955008;
				short num4 = num2;
				break;
			}
			default:
			{
				num2 = (short)328007680;
				if (num2 != 0)
				{
				}
				num2 = (short)908722177;
				if (num2 != 0)
				{
				}
				num2 = (short)951648260;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x002187F8 File Offset: 0x002169F8
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneCallListRecset()
		{
			short num = (short)590230758;
			short num2 = num;
			num = (short)1225340134;
			switch (num2 == num)
			{
			}
			num = (short)1295056897;
			if (num != 0)
			{
			}
			num = (short)1608712192;
			short num3 = num;
			num = (short)1013776384;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset._Max = int.MaxValue;
		}

		// Token: 0x04000CA6 RID: 3238
		public static int _MaxPool;

		// Token: 0x04000CA7 RID: 3239
		public static int _Max;
	}
}
