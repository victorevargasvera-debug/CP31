using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using AcpBusinessLayer.Impl;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x0200001B RID: 27
	[global::System.Serializable]
	public class AcpRecRefField : global::AcpBusinessLayer.AcpListField, global::System.Collections.Generic.IEnumerable<string>, global::System.Collections.IEnumerable
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0002CAFC File Offset: 0x0002ACFC
		// (set) Token: 0x06000264 RID: 612 RVA: 0x0002CBA8 File Offset: 0x0002ADA8
		public global::AcpBusinessLayer.Recordset RefRecset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)663126733;
				short num2 = num;
				num = (short)744522445;
				switch (num2 == num)
				{
				}
				num = (short)1287454720;
				short num3 = num;
				num = (short)609615873;
				if (num != 0)
				{
				}
				num = (short)86114304;
				if (num != 0)
				{
				}
				return this.<RefRecset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)1218756538;
				short num2 = num;
				num = (short)877576122;
				switch (num2 == num)
				{
				}
				num = (short)64946176;
				short num3 = num;
				num = (short)409665537;
				if (num != 0)
				{
				}
				num = (short)1936982016;
				if (num != 0)
				{
				}
				this.<RefRecset>k__BackingField = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0002CC5C File Offset: 0x0002AE5C
		// (set) Token: 0x06000266 RID: 614 RVA: 0x0002CD08 File Offset: 0x0002AF08
		public override int DefaultValue
		{
			get
			{
				short num = (short)2106913462;
				short num2 = num;
				num = (short)1623126710;
				switch (num2 == num)
				{
				}
				num = (short)314441728;
				short num3 = num;
				num = (short)1501560833;
				if (num != 0)
				{
				}
				num = (short)1931411456;
				if (num != 0)
				{
				}
				return this.defaultValue;
			}
			set
			{
				short num = (short)1091237008;
				short num2 = num;
				num = (short)1217852560;
				switch (num2 == num)
				{
				}
				num = (short)971964416;
				short num3 = num;
				num = (short)372637697;
				if (num != 0)
				{
				}
				num = (short)1537409024;
				if (num != 0)
				{
				}
				this.defaultValue = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0002CDBC File Offset: 0x0002AFBC
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0002CE6C File Offset: 0x0002B06C
		public int ReferencedIndex
		{
			get
			{
				short num = (short)346947585;
				if (num != 0)
				{
				}
				num = (short)839893820;
				short num2 = num;
				num = (short)1903149884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1036451840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)426442752;
				if (num != 0)
				{
				}
				return this.Value;
			}
			set
			{
				short num = (short)891944963;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1D4;
					case 1:
					{
						num = (short)1812332544;
						short num3 = num;
						num = (short)1132920837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (this.PrependCount > 0)
						{
							num = (short)1214971904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20B;
					case 3:
						num = (short)1313865729;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_74;
						}
						continue;
					case 4:
						goto IL_209;
					case 5:
						if (this.PrependCount == 0)
						{
							num = (short)1926692870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_218;
					case 6:
						num = (short)904658953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (!this.OneBased)
						{
							goto IL_218;
						}
						num = (short)650394256;
						short num4 = num;
						num = (short)814103184;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FD;
						default:
							num = (short)2033057792;
							if (num != 0)
							{
							}
							num = (short)317063169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						num = (short)1336410114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (value == 0)
						{
							num = (short)1821638660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_218;
					}
					IL_74:
					if (value == -1)
					{
						num = (short)1638072328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_FD:
					num = (short)895746055;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D4:
				this.DefaultValue = this.PrependValue;
				return;
				IL_209:
				this.DefaultValue = 1;
				return;
				IL_20B:
				this.DefaultValue = this.indexBase;
				return;
				IL_218:
				this.DefaultValue = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0002D098 File Offset: 0x0002B298
		// (set) Token: 0x0600026A RID: 618 RVA: 0x0002D148 File Offset: 0x0002B348
		public int ReferencedName
		{
			get
			{
				short num = (short)1106891331;
				short num2 = num;
				num = (short)1790235203;
				switch (num2 == num)
				{
				}
				num = (short)1690173441;
				if (num != 0)
				{
				}
				num = (short)2110259200;
				if (num != 0)
				{
				}
				num = (short)1366360064;
				short num3 = num;
				return this.Value;
			}
			set
			{
				short num = (short)1940193280;
				short num2 = num;
				num = (short)842727427;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_142;
					case 1:
						num = (short)1392312322;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)72482817;
						if (num != 0)
						{
						}
						if (this.PrependCount > 0)
						{
							num = (short)488243200;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					}
					IL_60:
					num = (short)1009470670;
					short num4 = num;
					num = (short)69422286;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1519976448;
						if (num != 0)
						{
						}
						if (value != -1)
						{
							goto IL_144;
						}
						break;
					}
					num = (short)2090074113;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_C9:
				this.DefaultValue = this.indexBase;
				return;
				IL_142:
				this.DefaultValue = this.PrependValue;
				return;
				IL_144:
				this.DefaultValue = value + this.indexBase;
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0002D2A8 File Offset: 0x0002B4A8
		public void SetRecset(global::AcpCommonLib.IAcpRecordset recset)
		{
			short num = (short)574160898;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_351;
				case 1:
				{
					num = (short)1751070859;
					short num3 = num;
					num = (short)1761163403;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3DD;
					default:
						num = (short)1666383872;
						if (num != 0)
						{
						}
						if (this.RefRecset != null)
						{
							num = (short)1981743112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_117;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				case 3:
					if (base.Parent.ParentRecset.ContainerDoc.IsOpen)
					{
						num = (short)1527382026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_390;
				case 4:
					return;
				case 5:
					if (base.Parent != null)
					{
						num = (short)347799559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_157;
				case 6:
					goto IL_117;
				case 7:
					num = (short)463208463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.RefRecset.CollectionChanged -= this.a;
					this.RefRecset.ReferenceKeyChanged -= this.a;
					num = (short)935002118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_2C7;
				case 10:
					this.c();
					num = (short)740753408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (this.RefRecset == null)
					{
						goto IL_3DD;
					}
					goto IL_2C7;
				case 12:
					if (this.RefRecset != null)
					{
						num = (short)1463418902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B8;
				case 13:
					goto IL_351;
				case 14:
					goto IL_3AF;
				case 15:
					if (base.Parent.ParentRecset != null)
					{
						num = (short)1403781144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_157;
				case 16:
					goto IL_351;
				case 17:
					if (this.ReferencedNode != null)
					{
						num = (short)1923088403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3AF;
				case 18:
				{
					num = (short)2111897600;
					short num4 = num;
					num = (short)1434976257;
					if (num != 0)
					{
					}
					num = (short)2062155779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					this.ReferencedNode.KeyField.RemoveRecordReference(this);
					num = (short)645136398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_2C2;
				case 21:
					if (base.Parent.ParentRecset.ContainerDoc != null)
					{
						num = (short)1717501970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_390;
				case 22:
					this.RefRecset.CollectionChanged += this.a;
					this.RefRecset.ReferenceKeyChanged += this.a;
					num = (short)1428291604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					this.ReferencedNode = null;
					num = (short)1297678345;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)178978837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_89:
				if (recset == this.RefRecset)
				{
					num = (short)1536098308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2103050241;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_117:
				num = (short)1107820561;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_157:
				this.ResetToDefaultNoConstraints();
				num = (short)1267269645;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C7:
				num = (short)276103173;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_351:
				num = (short)1589051404;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_390:
				this.ResetToDefaultNoConstraints();
				num = (short)1239941136;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3AF:
				this.RefRecset = (recset as global::AcpBusinessLayer.Recordset);
				num = (short)1618739211;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3DD:
				num = (short)1443561495;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_2C2:
			IL_4B8:
			this.UpdateItems();
			base.SetUITimer();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0002D77C File Offset: 0x0002B97C
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)321323008;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num5;
				switch (num2)
				{
				case 0:
				{
					num = (short)1621942035;
					short num3 = num;
					num = (short)715120403;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_127;
					default:
					{
						num = (short)13041665;
						if (num != 0)
						{
						}
						num = (short)951910400;
						if (num != 0)
						{
						}
						num = (short)237174784;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_106;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					if (num5 >= this.RefRecset.Count)
					{
						num = (short)808779788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)379191312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					int num6;
					num6++;
					num = (short)672071690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (this.RefRecset != null)
					{
						num = (short)2078605317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					num5++;
					num = (short)1792606216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)52232203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					int num6 = this.PrependCount;
					num = (short)917307407;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_127;
				case 8:
					goto IL_1B2;
				case 9:
				{
					int num6;
					this.Items[num5 + num6].ItemName = this.RefRecset[num5].ReferenceKey;
					num = (short)2121072644;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					goto IL_275;
				case 11:
					if (this.Items.Count > 0)
					{
						num = (short)462749702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					this.CleanupDuplicates();
					num = (short)1480392718;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_1B2;
				case 14:
					return;
				case 15:
					if (this.Items[0].Temporary)
					{
						num = (short)846462978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_275;
				case 16:
					if (num5 < this.Items.Count)
					{
						num = (short)1119944713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_106:
				if (A_0 is global::AcpBusinessLayer.FeatureNode)
				{
					num = (short)806944775;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_127:
				num = (short)1020329987;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B2:
				num = (short)434176001;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_275:
				num5 = 0;
				num = (short)298057741;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0002DACC File Offset: 0x0002BCCC
		internal int PrependCount
		{
			get
			{
				short num = (short)1792081920;
				short num2 = num;
				num = (short)1797062659;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return 2;
					case 1:
						return 0;
					case 2:
						if (this.PrependUIValue2 != null)
						{
							num = (short)835125248;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 1;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					IL_61:
					num = (short)1593785145;
					short num4 = num;
					num = (short)324025145;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1899560961;
						if (num != 0)
						{
						}
						num = (short)1053949952;
						if (num != 0)
						{
						}
						if (this.PrependUIValue != null)
						{
							num = (short)1339424770;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					num = (short)1999896577;
					num3 = (int)((global::System.IntPtr)num);
				}
				return 0;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0002DC0C File Offset: 0x0002BE0C
		private void a(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_0)
		{
			int num4;
			int num5;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_79;
				}
				short num;
				int num3;
				global::AcpBusinessLayer.FeatureNode featureNode;
				for (;;)
				{
					IL_0A:
					num = (short)1906797364;
					short num2 = num;
					num = (short)225340212;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)118816768;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (this.Items[0].ItemName == featureNode.ReferenceKey)
							{
								num = (short)1224605701;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4++;
							num5++;
							num = (short)61538306;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (this.Items.Count > 0)
							{
								num = (short)131792903;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21B;
						case 2:
							goto IL_219;
						case 3:
							goto IL_159;
						case 4:
							num = (short)579665920;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							num = (short)1650917376;
							short num6 = num;
							num = (short)741998593;
							if (num != 0)
							{
							}
							this.b(featureNode);
							num = (short)1870528515;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (this.Items[0].Temporary)
							{
								num = (short)1415053316;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21B;
						case 7:
							num = (short)708444166;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79;
					}
				}
				IL_79:
				num4 = A_0.OldStartingIndex + this.PrependCount;
				num5 = A_0.NewStartingIndex + this.PrependCount;
				featureNode = (global::AcpBusinessLayer.FeatureNode)A_0.OldItems[0];
				num = (short)1039335425;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_159:
			IL_219:
			IL_21B:
			this.Items.Move(num4, num5);
			this.UpdateValue();
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0002DE48 File Offset: 0x0002C048
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)541458432;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				for (;;)
				{
					IL_1E:
					switch (0)
					{
					case 0:
						goto IL_4F;
					}
					global::System.Collections.Specialized.NotifyCollectionChangedAction action;
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
						{
							bool flag;
							if (!flag)
							{
								num = (short)18612229;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						case 1:
							switch (action)
							{
							case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
								goto IL_F2;
							case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
								num = (short)1508769796;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
							case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
								return;
							case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
								goto IL_3FC;
							default:
								num = (short)2114453511;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 2:
							return;
						case 3:
							try
							{
								num = (short)1212219394;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::AcpBusinessLayer.AcpRecRefItem acpRecRefItem;
										if (acpRecRefItem.Node == (global::AcpBusinessLayer.FeatureNode)A_1.OldItems[0])
										{
											num = (short)1583349761;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
									{
										global::AcpBusinessLayer.ListItem listItem;
										this.Items.Remove(listItem);
										global::AcpBusinessLayer.AcpRecRefItem acpRecRefItem;
										bool flag = acpRecRefItem.Node == this.ReferencedNode;
										num = (short)59113477;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_196;
										}
										continue;
									case 3:
										goto IL_2B8;
									case 4:
										num = (short)1853620227;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_29B;
									case 6:
									{
										global::AcpBusinessLayer.AcpRecRefItem acpRecRefItem;
										if (acpRecRefItem != null)
										{
											num = (short)1292697607;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
										num = (short)1816133632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)535298052;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
										global::AcpBusinessLayer.AcpRecRefItem acpRecRefItem = listItem as global::AcpBusinessLayer.AcpRecRefItem;
										num = (short)1847394310;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_198:
									num = (short)285933576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_196:
									goto IL_198;
								}
								IL_29B:
								IL_2B8:
								goto IL_110;
							}
							finally
							{
								num = (short)1570701314;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_326;
									case 1:
										enumerator.Dispose();
										num = (short)17629184;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2F0;
										}
										continue;
									}
									IL_2F0:
									if (enumerator == null)
									{
										break;
									}
									num = (short)405078017;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_326:;
							}
							goto IL_329;
							IL_110:
							num = (short)1072300032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)1925185536;
							short num3 = num;
							if (global::AcpBusinessLayer.AcpDocument.Closing)
							{
								num = (short)1747058690;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)768933889;
							if (num != 0)
							{
							}
							bool flag = false;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator = this.Items.GetEnumerator();
							num = (short)1768488963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_329;
						case 6:
							goto IL_394;
						case 7:
							return;
						}
						break;
						IL_329:
						num = (short)1016325011;
						short num4 = num;
						num = (short)2073486227;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E;
						default:
							num = (short)1290141696;
							if (num != 0)
							{
							}
							this.UpdateValue();
							num = (short)1118109702;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_4F:
					action = A_1.Action;
					num = (short)1875312641;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				return;
				IL_F2:
				this.a((global::AcpBusinessLayer.FeatureNode)A_1.NewItems[0], A_1.NewStartingIndex);
				return;
				IL_394:
				return;
				IL_3FC:
				this.a(A_1);
				return;
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0002E278 File Offset: 0x0002C478
		private void a(global::AcpBusinessLayer.FeatureNode A_0, int A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_C0;
				case 1:
				{
					num2 = (short)1757575014;
					short num3 = num2;
					num2 = (short)993818470;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)301531136;
						if (num2 != 0)
						{
						}
						num2 = (short)1974534151;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (this.Items.Count > 0)
					{
						num2 = (short)579862532;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_81;
				case 3:
					goto IL_81;
				case 4:
					num2 = (short)1402470409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					this.b(A_0);
					num2 = (short)1151991816;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (this.Items.Count <= num4)
					{
						num2 = (short)1044447232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24D;
				case 7:
					num2 = (short)388104193;
					if (num2 != 0)
					{
					}
					if (this.Items[0].ItemName == A_0.ReferenceKey)
					{
						num2 = (short)1083244544;
						short num5 = num2;
						num2 = (short)1380581381;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num4++;
					num2 = (short)1554186243;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_81;
				case 9:
					if (this.Items[0].Temporary)
					{
						num2 = (short)601882625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_81;
				}
				goto IL_38;
				IL_81:
				num2 = (short)243597318;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_C0:
			global::AcpBusinessLayer.AcpRecRefItem item;
			this.Items.Add(item);
			this.FirePropertyChangedEvent();
			return;
			IL_24D:
			this.Items.Insert(num4, item);
			this.UpdateValue();
			return;
			IL_38:
			item = new global::AcpBusinessLayer.AcpRecRefItem(this, A_0);
			num4 = A_1 + this.PrependCount;
			num2 = (short)474742786;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
		private void b(global::AcpBusinessLayer.FeatureNode A_0)
		{
			short num = (short)314310656;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefSlaveItem> enumerator;
				string[] array;
				int num5;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						num = (short)320602112;
						short num3 = num;
						this.ReferencedNode.KeyField.AddRecordReference(this);
						num = (short)335413254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)1497169921;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_131;
									}
									continue;
								case 2:
								{
									num = (short)865477480;
									short num4 = num;
									num = (short)13247336;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_181;
									default:
										num = (short)2015494144;
										if (num != 0)
										{
										}
										num = (short)1582956547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_1FC;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										goto IL_181;
									}
									global::AcpBusinessLayer.AcpRecRefSlaveItem acpRecRefSlaveItem = enumerator.Current;
									array[num5] = acpRecRefSlaveItem.SlaveField.UIValue;
									num5++;
									num = (short)1110114304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_164:
								num = (short)1770913796;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_131:
								goto IL_164;
								IL_181:
								num = (short)146669570;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1FC:
							goto IL_3FF;
						}
						finally
						{
							num = (short)1289224192;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_233;
									}
									continue;
								case 1:
									goto IL_268;
								case 2:
									enumerator.Dispose();
									num = (short)2071265281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_233:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1492975618;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_268:;
						}
						goto IL_26B;
					case 2:
						goto IL_26B;
					case 3:
						if (this.ReferencedNode != null)
						{
							num = (short)49807362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45A;
					case 4:
						if (this.ReferencedNode.KeyField != null)
						{
							num = (short)1568604160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45A;
					case 5:
						num = (short)1112801281;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1515257857;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1325072388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.SlaveField.UIValue = array[num5];
									num5++;
									num = (short)2127953922;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_314;
									}
									continue;
								case 3:
									goto IL_390;
								case 4:
									num = (short)1601372163;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_316:
								num = (short)1487208448;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_314:
								goto IL_316;
							}
							IL_390:
							goto IL_89;
						}
						finally
						{
							num = (short)1450639360;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3C7;
									}
									continue;
								case 1:
									goto IL_3FC;
								case 2:
									enumerator.Dispose();
									num = (short)1233649665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3C7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)525926402;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3FC:;
						}
						goto IL_3FF;
						IL_89:
						num = (short)1026424835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_F2;
					}
					goto IL_4B;
					IL_26B:
					num = (short)2003238916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FF:
					this.ReferencedNode = A_0;
					num5 = 0;
					enumerator = this.SlaveFields.GetEnumerator();
					num = (short)1646592005;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F2:
				IL_45A:
				base.ForceValid = true;
				base.CallConstraintsX();
				return;
				IL_4B:
				this.Items.RemoveAt(0);
				array = new string[this.SlaveFieldCount];
				num5 = 0;
				enumerator = this.SlaveFields.GetEnumerator();
				num = (short)822870017;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0002E990 File Offset: 0x0002CB90
		private void a(int A_0, int A_1)
		{
			short num;
			int num4;
			int num6;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)824435926;
					short num2 = num;
					num = (short)1339548886;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E1;
					default:
					{
						num = (short)745472000;
						if (num != 0)
						{
						}
						num = (short)49741825;
						if (num != 0)
						{
						}
						num = (short)1738080256;
						short num3 = num;
						int num5;
						switch (num4)
						{
						case 0:
							goto IL_1CF;
						case 1:
							if (base.IsIndexValid != null)
							{
								num = (short)1917321219;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_225;
						case 2:
							if (this.Items[0].Temporary)
							{
								num = (short)1765736452;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B2;
						case 3:
							this.Items[num5 + num6].ItemValidity = base.IsIndexValid(base.Parent, num5 + this.indexBase);
							num = (short)196083720;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num6++;
							num = (short)508493830;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							return;
						case 6:
							goto IL_1B2;
						case 7:
							if (base.Applicable)
							{
								num = (short)2030895114;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_225;
						case 8:
							goto IL_225;
						case 9:
							goto IL_1CF;
						case 10:
							num = (short)2037186561;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (num5 > A_1)
							{
								num = (short)1140457477;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.Items[num5 + num6].ItemName = this.RefRecset[num5].ReferenceKey;
							num = (short)1309147143;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DA;
						IL_1B2:
						num5 = A_0;
						num = (short)1585446912;
						num4 = (int)((global::System.IntPtr)num);
						break;
						IL_1CF:
						num = (short)2062221323;
						num4 = (int)((global::System.IntPtr)num);
						break;
						IL_225:
						num5++;
						num = (short)1344667657;
						num4 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
			}
			IL_DA:
			num6 = this.PrependCount;
			IL_E1:
			num = (short)541392898;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0002EC40 File Offset: 0x0002CE40
		internal void UpdateItems()
		{
			short num = (short)1550123008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_DA;
				}
				int prependCount;
				for (;;)
				{
					IL_27:
					int num3;
					global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
					global::AcpBusinessLayer.ListItem[] array;
					switch (num2)
					{
					case 0:
						goto IL_98F;
					case 1:
						goto IL_6E0;
					case 2:
						num = (short)2122186786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (num3 < 0)
						{
							num = (short)2112815114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_86B;
					case 4:
						goto IL_9D1;
					case 5:
						if (this.Value >= this.indexBase)
						{
							num = (short)2136014881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82B;
					case 6:
						goto IL_195;
					case 7:
						if (this.Items[0].Temporary)
						{
							num = (short)968556586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_275;
					case 8:
					{
						try
						{
							num = (short)540475393;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4B4;
									}
									continue;
								case 2:
									num = (short)139198469;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1125580802;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
									num = (short)941948934;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpBusinessLayer.ListItem listItem;
									listItem.parent = this;
									num = (short)620101632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_56D;
								case 6:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem is global::AcpBusinessLayer.AcpRecRefItem)
									{
										num = (short)2041970692;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_4B6:
								num = (short)284688387;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4B4:
								goto IL_4B6;
							}
							IL_56D:
							goto IL_8CC;
						}
						finally
						{
							num = (short)988348416;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5A4;
									}
									continue;
								case 1:
									goto IL_5DC;
								case 2:
									enumerator.Dispose();
									num = (short)2131623937;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5A4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1231290370;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5DC:;
						}
						goto IL_5DF;
						IL_8CC:
						global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> observableCollection;
						this.Items = observableCollection;
						num = (short)152240150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						int count = this.RefRecset.Count;
						num = (short)1076297769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num3 = this.IndexOfDeepCopy;
						num = (short)1927348240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1623457828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						this.CalculateItemsValidity();
						num = (short)695795727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (this.Items.Count != 0)
						{
							num = (short)2132148224;
							short num4 = num;
							num = (short)1848573963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D1;
					case 14:
						goto IL_5DF;
					case 15:
						goto IL_2BC;
					case 16:
						goto IL_86B;
					case 17:
						goto IL_275;
					case 18:
						if (base.Applicable)
						{
							num = (short)1490485260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC;
					case 19:
					{
						int count;
						int num5;
						if (num5 >= count)
						{
							num = (short)339214336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.Items.Add(new global::AcpBusinessLayer.AcpRecRefItem(this, (global::AcpBusinessLayer.FeatureNode)this.RefRecset[num5], true, true));
						num5++;
						num = (short)98238491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (this.Value != this.PrependValue2)
						{
							num = (short)2028732439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
						if (this.PrependUIValue != null)
						{
							num = (short)1374683138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C3;
					case 22:
						goto IL_98F;
					case 23:
						goto IL_3C3;
					case 24:
						num3 = ((global::AcpBusinessLayer.Recordset)base.Parent.ParentRecset).IndexOf(base.ParentNode) - 1;
						num = (short)344653827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (this.RefRecset.Count > this.Value - this.indexBase)
						{
							num = (short)1748893736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82B;
					case 26:
					{
						try
						{
							acpRecRefField.Items.CopyTo(array, 0);
							goto IL_7B0;
						}
						catch (global::System.Exception)
						{
							goto IL_7B0;
						}
						goto IL_6E0;
						IL_7B0:
						global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem>(array);
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator = observableCollection.GetEnumerator();
						num = (short)2119041032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_195;
					case 28:
						goto IL_434;
					case 29:
						if (this.RefRecset != null)
						{
							num = (short)562102281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_98F;
					case 30:
						if (this.Items.Count <= prependCount)
						{
							num = (short)174325795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.Items.RemoveAt(prependCount);
						num = (short)21037094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (this.Items.Count > 0)
						{
							num = (short)525467662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_275;
					case 32:
						goto IL_46B;
					case 33:
						num = (short)726007833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (this.Value != this.PrependValue)
						{
							goto IL_258;
						}
						return;
					case 35:
						num = (short)1950416925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (this.Items[0].ItemName != this.InvalidText)
						{
							num = (short)686358532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_434;
					case 37:
						if (this.RefRecset != null)
						{
							num = (short)1042939943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 38:
						goto IL_275;
					case 39:
						num = (short)1947664389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						num = (short)1563934565;
						short num6 = num;
						num = (short)1672789861;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_258;
						default:
							goto IL_75F;
						}
						break;
					}
					case 41:
					{
						if (((global::AcpBusinessLayer.Recordset)base.Parent.ParentRecset).NotFirstNoLastAddOnMultiAddOperation)
						{
							num = (short)460980248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = 0;
						num = (short)1328742406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						this.Items.RemoveAt(0);
						num = (short)1526595601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DA;
					IL_195:
					num = (short)311099411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_258:
					num = (short)440532993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_275:
					num = (short)1703804958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BC:
					num = (short)1695547429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C3:
					num = (short)328204301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_434:
					this.UIValue = this.InvalidText;
					base.DirectUIValue = this.InvalidText;
					base.ForceValid = false;
					num = (short)1879310368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5DF:
					num = (short)1785004039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E0:
					num = (short)1956380692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_82B:
					num = (short)1758724117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_86B:
					acpRecRefField = (base.Parent.ParentRecset[num3][base.Parent.FeatureSectionId][base.UIName] as global::AcpBusinessLayer.AcpRecRefField);
					array = new global::AcpBusinessLayer.ListItem[acpRecRefField.Items.Count];
					num = (short)1359085594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_98F:
					num = (short)1475870738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9D1:
					this.Items.Insert(0, new global::AcpBusinessLayer.ListItem(this, this.InvalidText, false, true, true));
					num = (short)865337372;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_46B:
				return;
				IL_75F:
				num = (short)990838784;
				if (num != 0)
				{
				}
				this.ReferencedNode = (global::AcpBusinessLayer.FeatureNode)this.RefRecset[this.Value - this.indexBase];
				this.ReferencedNode.KeyField.AddRecordReference(this);
				base.ForceValid = true;
				return;
				IL_DA:
				num = (short)103481345;
				if (num != 0)
				{
				}
				prependCount = this.PrependCount;
				num = (short)753598495;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0002F68C File Offset: 0x0002D88C
		internal void UpdateValue()
		{
			short num = (short)1628307459;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_281;
				case 1:
					num = (short)2074542092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_A3;
				case 3:
					num = (short)1638465537;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_7F;
					}
					continue;
				case 4:
					global::AcpCommonLib.ConstraintManager.Resume();
					num = (short)504692747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)463863814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (this.ReferencedNode != null)
					{
						num = (short)2029060097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
				{
					bool flag = global::AcpCommonLib.ConstraintManager.Suspend();
					int num3 = this.RefRecset.IndexOf(this.ReferencedNode);
					if (base.Parent != null)
					{
						global::AcpCommonLib.IAcpFeatureNode parent = base.Parent.Parent;
					}
					if (num3 >= 0)
					{
						this.SetValue(num3 + this.indexBase);
					}
					if (flag)
					{
						num = (short)278069252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 8:
				{
					num = (short)832415344;
					short num4 = num;
					num = (short)1709680240;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_281;
					default:
						num = (short)686096384;
						if (num != 0)
						{
						}
						num = (short)514916362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					if (this.PrependCount == 0)
					{
						num = (short)345047042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					if (this.Value == this.PrependValue2)
					{
						num = (short)1554776064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3;
				case 11:
					return;
				case 12:
				{
					num = (short)1116798976;
					short num5 = num;
					if (this.Value != this.PrependValue)
					{
						num = (short)711720968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D8;
				}
				}
				IL_7F:
				if (this.RefRecset != null)
				{
					num = (short)1480065029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A3:
				num = (short)1394147335;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D8:
				num = (short)125960201;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_281:
				goto IL_D8;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0002F954 File Offset: 0x0002DB54
		public string InvalidText
		{
			get
			{
				short num = (short)1333002241;
				if (num != 0)
				{
				}
				num = (short)644087808;
				short num2 = num;
				num = (short)218797774;
				short num3 = num;
				num = (short)1523816142;
				switch (num3 == num)
				{
				}
				num = (short)1157627904;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).InvalidText;
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0002FA0C File Offset: 0x0002DC0C
		public AcpRecRefField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(parent, name, uiLabel)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0002FA24 File Offset: 0x0002DC24
		public AcpRecRefField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] prependStrings, int[] prependValues) : this(parent, name, uiLabel, prependStrings, prependValues, false)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0002FA3F File Offset: 0x0002DC3F
		public AcpRecRefField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] prependStrings, int[] prependValues, bool oneBased) : this(parent, name, uiLabel, prependStrings, prependValues, oneBased, false)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0002FA54 File Offset: 0x0002DC54
		public AcpRecRefField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] prependStrings, int[] prependValues, bool oneBased, bool defaultToFirst) : base(parent, name, uiLabel)
		{
			this.IsFirstRecDefault = defaultToFirst;
			this.indexBase = (oneBased ? 1 : 0);
			if (prependStrings != null)
			{
				this.a(prependStrings, prependValues);
			}
			this.c();
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0002FAA0 File Offset: 0x0002DCA0
		public AcpRecRefField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] prependStrings, int[] prependValues, bool oneBased, bool defaultToFirst, string[] legacyUILabels) : base(parent, name, legacyUILabels, uiLabel)
		{
			this.IsFirstRecDefault = defaultToFirst;
			this.indexBase = (oneBased ? 1 : 0);
			if (prependStrings != null)
			{
				this.a(prependStrings, prependValues);
			}
			this.c();
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0002FAF0 File Offset: 0x0002DCF0
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0002FBAC File Offset: 0x0002DDAC
		public bool IsFirstRecDefault
		{
			get
			{
				short num = (short)788332545;
				if (num != 0)
				{
				}
				num = (short)774176768;
				short num2 = num;
				num = (short)971524987;
				short num3 = num;
				num = (short)1700350843;
				switch (num3 == num)
				{
				}
				num = (short)1371537408;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).IsFirstRecDefault;
			}
			set
			{
				short num = (short)742564581;
				short num2 = num;
				num = (short)934388453;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1374289920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)932708352;
				if (num != 0)
				{
				}
				num = (short)2050162689;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).IsFirstRecDefault = value;
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0002FC68 File Offset: 0x0002DE68
		private void a(string[] A_0, int[] A_1)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (A_1.Length > 1)
					{
						num2 = (short)822345730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					goto IL_143;
				}
				goto IL_25;
			}
			IL_143:
			goto IL_145;
			IL_25:
			this.PrependValue = A_1[0];
			this.PrependUIValue = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_) + A_0[0] + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_);
			this.Items.Add(new global::AcpBusinessLayer.ListItem(this, this.PrependUIValue, true, true));
			num2 = (short)1716857296;
			short num3 = num2;
			num2 = (short)228862416;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_145:
				this.PrependValue2 = A_1[1];
				this.PrependUIValue2 = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_) + A_0[1] + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_);
				this.Items.Add(new global::AcpBusinessLayer.ListItem(this, this.PrependUIValue2, true, true));
				num2 = (short)146276353;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			case 1:
				break;
			default:
			{
				num2 = (short)503971840;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)1987379200;
			if (num2 != 0)
			{
			}
			num2 = (short)275513345;
			if (num2 != 0)
			{
			}
			num2 = (short)502398976;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0002FE20 File Offset: 0x0002E020
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0002FED8 File Offset: 0x0002E0D8
		internal int PrependValue
		{
			get
			{
				short num = (short)267982158;
				short num2 = num;
				num = (short)123606350;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2107572224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)213843969;
				if (num != 0)
				{
				}
				num = (short)226230272;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).PrependValue;
			}
			set
			{
				short num = (short)1557382395;
				short num2 = num;
				num = (short)393594107;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1677000704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2071986177;
				if (num != 0)
				{
				}
				num = (short)1667891200;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).PrependValue = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0002FF90 File Offset: 0x0002E190
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00030048 File Offset: 0x0002E248
		internal string PrependUIValue
		{
			get
			{
				short num = (short)935105637;
				short num2 = num;
				num = (short)1370657893;
				switch (num2 == num)
				{
				}
				num = (short)1902444545;
				if (num != 0)
				{
				}
				num = (short)573243392;
				short num3 = num;
				num = (short)1263337472;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).PrependUIValue;
			}
			set
			{
				short num = (short)1714618369;
				if (num != 0)
				{
				}
				num = (short)351452148;
				short num2 = num;
				num = (short)520862708;
				switch (num2 == num)
				{
				}
				num = (short)1027473408;
				short num3 = num;
				num = (short)533135360;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).PrependUIValue = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00030104 File Offset: 0x0002E304
		// (set) Token: 0x06000283 RID: 643 RVA: 0x000301BC File Offset: 0x0002E3BC
		internal int PrependValue2
		{
			get
			{
				short num = (short)961376411;
				short num2 = num;
				num = (short)2027450523;
				switch (num2 == num)
				{
				}
				num = (short)1740111873;
				if (num != 0)
				{
				}
				num = (short)1219493888;
				short num3 = num;
				num = (short)659750912;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).PrependValue2;
			}
			set
			{
				short num = (short)2025935427;
				short num2 = num;
				num = (short)369644099;
				switch (num2 == num)
				{
				}
				num = (short)1117192193;
				if (num != 0)
				{
				}
				num = (short)1704919040;
				short num3 = num;
				num = (short)1212153856;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).PrependValue2 = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00030274 File Offset: 0x0002E474
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0003032C File Offset: 0x0002E52C
		internal string PrependUIValue2
		{
			get
			{
				short num = (short)1472564632;
				short num2 = num;
				num = (short)1609534872;
				switch (num2 == num)
				{
				}
				num = (short)326041601;
				if (num != 0)
				{
				}
				num = (short)103677952;
				short num3 = num;
				num = (short)1930100736;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).PrependUIValue2;
			}
			set
			{
				short num = (short)497379404;
				short num2 = num;
				num = (short)575236172;
				switch (num2 == num)
				{
				}
				num = (short)667025409;
				if (num != 0)
				{
				}
				num = (short)324403200;
				short num3 = num;
				num = (short)1771503616;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).PrependUIValue2 = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000286 RID: 646 RVA: 0x000303E8 File Offset: 0x0002E5E8
		internal bool IsExactPrepend
		{
			get
			{
				short num = (short)1972764674;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)109182977;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (this.UIValue == this.PrependUIValue2)
						{
							num = (short)536936449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						goto IL_13C;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 3:
					{
						num = (short)346488832;
						short num3 = num;
						num = (short)589889536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_5A:
					if (this.UIValue == this.PrependUIValue)
					{
						break;
					}
					num = (short)622090292;
					short num4 = num;
					num = (short)1091262516;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)1045168128;
						if (num != 0)
						{
						}
						num = (short)1420820483;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return true;
				IL_13C:
				return true;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00030534 File Offset: 0x0002E734
		public global::System.Collections.Generic.IEnumerable<int> PrependValues
		{
			get
			{
				short num = (short)1486506383;
				short num2 = num;
				num = (short)190400911;
				switch (num2 == num)
				{
				}
				num = (short)1649213440;
				if (num != 0)
				{
				}
				num = (short)1206255616;
				short num3 = num;
				num = (short)1274609665;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpRecRefField.<get_PrependValues>d__53 <get_PrependValues>d__ = new global::AcpBusinessLayer.AcpRecRefField.<get_PrependValues>d__53(-2);
				<get_PrependValues>d__.<>4__this = this;
				return <get_PrependValues>d__;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000288 RID: 648 RVA: 0x000305EC File Offset: 0x0002E7EC
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00030698 File Offset: 0x0002E898
		public override int Value
		{
			get
			{
				short num = (short)231467327;
				short num2 = num;
				num = (short)548333887;
				switch (num2 == num)
				{
				}
				num = (short)1515716608;
				if (num != 0)
				{
				}
				num = (short)1270808576;
				short num3 = num;
				num = (short)1925447681;
				if (num != 0)
				{
				}
				return base.Value;
			}
			set
			{
				short num = (short)1555172744;
				short num2 = num;
				num = (short)1993280904;
				switch (num2 == num)
				{
				}
				num = (short)1862991873;
				if (num != 0)
				{
				}
				num = (short)282001408;
				short num3 = num;
				num = (short)1298202624;
				if (num != 0)
				{
				}
				this.SetValue(value);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00030748 File Offset: 0x0002E948
		public override void SetValue(int newValue)
		{
			short num = (short)1239875585;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1272446977;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					global::AcpCommonLib.ConstraintManager.Resume();
					base.CallConstraintsX();
					num = (short)1145278909;
					short num3 = num;
					num = (short)123900349;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)579993600;
						if (num != 0)
						{
						}
						num = (short)2041249794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 2:
					goto IL_E5;
				}
				IL_56:
				bool flag = global::AcpCommonLib.ConstraintManager.Suspend();
				base.SetValue(newValue);
				if (this.DefaultValue == -1 && newValue != -1)
				{
					this.b();
				}
				if (!flag)
				{
					break;
				}
				num = (short)1020067840;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E5:
			num = (short)1687355392;
			short num4 = num;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00030890 File Offset: 0x0002EA90
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00030B14 File Offset: 0x0002ED14
		public override string UIValue
		{
			get
			{
				short num = (short)1190046003;
				short num2 = num;
				num = (short)1163307315;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1FC:
					num = (short)2075852809;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)71368704;
					if (num != 0)
					{
					}
					num = (short)1323696130;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (this.PrependUIValue != null)
						{
							num = (short)788529152;
							short num4 = num;
							num = (short)1231618059;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_194;
					case 1:
						goto IL_267;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					case 3:
						goto IL_1CE;
					case 4:
						if (this.PrependValue == this.Value)
						{
							num = (short)165871617;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)944177157;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this.PrependUIValue2 != null)
						{
							num = (short)1172504582;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_194;
					case 6:
						num = (short)1061945345;
						if (num != 0)
						{
						}
						num = (short)2093809671;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.PrependValue2 == this.Value)
						{
							goto IL_1FC;
						}
						goto IL_194;
					case 8:
						if (this.ReferencedNode == null)
						{
							num = (short)1089470467;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_269;
					case 9:
						goto IL_213;
					case 10:
						goto IL_BE;
					case 11:
						num = (short)1000275972;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_9D:
					if (!base.ForceValid)
					{
						num = (short)1591803914;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)226099200;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_194:
					num = (short)1344733192;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_BE:
				return base.DirectUIValue;
				IL_1CE:
				return base.DirectUIValue;
				IL_213:
				return this.PrependUIValue2;
				IL_267:
				return this.PrependUIValue;
				IL_269:
				return this.ReferencedNode.ReferenceKey;
			}
			set
			{
				int a_ = 17;
				short num = (short)420020284;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (base.Name != global::AcpBusinessLayer.UndoRedo.SetValueTask.b("맢諤触賨뷪苬蛮鋰雲듴駶韸铺裼釾戀昂栄戆月缊䐌䬎丐划✔☖Ⱈ⨚⤜", a_))
						{
							num = (short)667025413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A14;
					case 1:
						if (this.Items[0].Temporary)
						{
							num = (short)2041249818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD4;
					case 2:
						num = (short)1092878382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						bool flag = global::AcpCommonLib.ConstraintManager.Suspend();
						base.DirectUIValue = value;
						this.SetValue(-1);
						if (flag)
						{
							num = (short)847249459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_98F;
					}
					case 4:
						num = (short)904134689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)61210663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.Items.Count > 0)
						{
							num = (short)406388740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C34;
					case 7:
						goto IL_A0E;
					case 8:
						if (this.Items.Count > 0)
						{
							num = (short)293994512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD4;
					case 9:
						goto IL_86C;
					case 10:
						goto IL_98F;
					case 11:
						num = (short)341049345;
						if (num != 0)
						{
						}
						num = (short)511901702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						this.ReferencedNode = (global::AcpBusinessLayer.FeatureNode)this.RefRecset.NodeFromKey(value);
						num = (short)1600782354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)779681851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (this.PrependUIValue2 == value)
						{
							num = (short)1764687883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)500563976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (this.ReferencedNode.KeyField != null)
						{
							num = (short)130154530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D0;
					case 16:
						num = (short)1041498113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_C14;
					case 18:
						goto IL_6D5;
					case 19:
						goto IL_AD4;
					case 20:
						num = (short)518848541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_6D5;
					case 22:
						num = (short)915537947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (base.ValueSetter != null)
						{
							num = (short)1826881543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_803;
					case 24:
						undoableTask = new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(this, value);
						num = (short)858325015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (this.PrependUIValue == value)
						{
							num = (short)652738623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1634992142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						IL_1B9:
						this.Items.RemoveAt(0);
						num = (short)1384513555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (base.ForceValid)
						{
							num = (short)983367689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B18;
					case 28:
						goto IL_955;
					case 29:
						if (value == this.UIValue)
						{
							num = (short)1621229590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B18;
					case 30:
						if (this.Items[0].Temporary)
						{
							num = (short)1429274673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_955;
					case 31:
						if (this.Items[0].Temporary)
						{
							num = (short)579272744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BE;
					case 32:
						this.Items.RemoveAt(0);
						num = (short)2038300734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (this.Items[0].Temporary)
						{
							num = (short)1988689952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C34;
					case 34:
						this.ReferencedNode.KeyField.AddRecordReference(this);
						num = (short)1631060037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_1BE;
					case 36:
						if (this.RefRecset.Count > 0)
						{
							num = (short)2102657036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7DE;
					case 37:
						goto IL_C32;
					case 38:
						this.ReferencedNode.KeyField.RemoveRecordReference(this);
						num = (short)1686962242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (base.Name != global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ꃢ跤蛦蟨藪裬菮냰鷲鯴飶賸闺黼髾氀昂欄猆䀈伊刌与⌐⌒␔‖Ⱈ", a_))
						{
							num = (short)32768043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A14;
					case 40:
						this.Items.RemoveAt(0);
						num = (short)693239843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_C58;
					case 42:
						if (this.ReferencedNode != null)
						{
							num = (short)1941635139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)754515993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						this.Items.Insert(0, new global::AcpBusinessLayer.ListItem(this, value, false, true, true));
						num = (short)1079246900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num = (short)1279852580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_1E1;
					case 46:
						if (!this.Items[0].Temporary)
						{
							num = (short)1617952821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A14;
					case 47:
						goto IL_902;
					case 48:
						base.CallConstraintsX();
						num = (short)44236817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						this.Items.RemoveAt(0);
						num = (short)1628045340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
						{
							num = (short)1715208216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.FirePropertyChangingEvent();
						num = (short)813039688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						global::AcpCommonLib.ConstraintManager.Resume();
						num = (short)1469054986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						goto IL_A14;
					case 53:
						goto IL_75B;
					case 54:
						num = (short)1094909983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						if (base.Parent.FeatureSectionId != 10501)
						{
							num = (short)1127284783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A14;
					case 56:
						num = (short)773718046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_98A;
					case 58:
						if (this.Items.Count != 0)
						{
							num = (short)1988624386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_75B;
					case 59:
						if (this.ReferencedNode.KeyField != null)
						{
							num = (short)1869152294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_714;
					case 60:
						switch (0)
						{
						case 0:
							goto IL_151;
						}
						continue;
					case 61:
						if (this.Items.Count > 0)
						{
							num = (short)1536098358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BE;
					case 62:
						goto IL_C34;
					case 63:
						num = (short)281673789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						num = (short)1731330103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						if (!global::AcpCommonLib.ConstraintManager.Suspended)
						{
							num = (short)1923874864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C14;
					case 66:
						goto IL_714;
					case 67:
						num = (short)1718222863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (this.RefRecset != null)
						{
							num = (short)1851719724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7DE;
					case 69:
						goto IL_5D0;
					case 70:
						if (this.Items.Count > 0)
						{
							num = (short)1275920440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_955;
					case 71:
						if (base.Parent != null)
						{
							num = (short)246743104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_902;
					case 72:
						if (this.ReferencedNode != null)
						{
							num = (short)1035141133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_714;
					}
					IL_151:
					if (value != null)
					{
						num = (short)640352276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_5D0:
					num = (short)1393286400;
					short num3 = num;
					num = (short)934206720;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B9;
					default:
					{
						num = (short)1732247552;
						short num4 = num;
						num = (short)467468288;
						if (num != 0)
						{
						}
						num = (short)1006239814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_1BE:
					this.SetValue(this.PrependValue);
					num = (short)1781137453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D5:
					num = (short)133169194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_714:
					base.ForceValid = true;
					num = (short)1086914628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_75B:
					num = (short)992411719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7DE:
					this.ReferencedNode = null;
					num = (short)1232076821;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_902:
					num = (short)468516864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_955:
					this.SetValue(this.RefRecset.IndexOf(this.ReferencedNode) + this.indexBase);
					num = (short)1655373881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_98F:
					num = (short)2146304065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A14:
					num = (short)1974599683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD4:
					num = (short)2123169850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B18:
					num = (short)1487732786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C14:
					base.SetUITimer();
					num = (short)1748172837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C34:
					this.SetValue(this.PrependValue2);
					num = (short)2026962985;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E1:
				goto IL_C5D;
				IL_803:
				global::AcpCommonLib.UndoRedo.UndoManager.AddTask(undoableTask);
				return;
				IL_86C:
				return;
				IL_98A:
				goto IL_C5D;
				IL_A0E:
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(undoableTask.ToString());
				containerTask.AddTask(undoableTask);
				this.CallValueSetter(containerTask);
				global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
				return;
				IL_C32:
				IL_C58:
				IL_C5D:
				this.FirePropertyChangedEvent();
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00031784 File Offset: 0x0002F984
		protected internal override void FirePropertyChangingEvent()
		{
			int a_ = 11;
			short num = (short)1621622784;
			short num2 = num;
			num = (short)2425904;
			short num3 = num;
			num = (short)725025840;
			switch (num3 == num)
			{
			}
			num = (short)1210908673;
			if (num != 0)
			{
			}
			num = (short)1059979264;
			if (num != 0)
			{
			}
			base.FirePropertyChangedEvent();
			((global::AcpBusinessLayer.FeatureSection)base.Parent).FirePropertyChanging(base.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("苜諞꣠뗢蓤详鳨軪", a_));
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00031868 File Offset: 0x0002FA68
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0003191C File Offset: 0x0002FB1C
		public global::AcpBusinessLayer.FeatureNode ReferencedNode
		{
			get
			{
				short num = (short)1592197120;
				short num2 = num;
				num = (short)354287617;
				if (num != 0)
				{
				}
				num = (short)1141390700;
				short num3 = num;
				num = (short)1330724204;
				switch (num3 == num)
				{
				}
				num = (short)2142568448;
				if (num != 0)
				{
				}
				return this.referencedNode;
			}
			private set
			{
				short num = (short)568262656;
				switch (num)
				{
				default:
				{
					num = (short)355729409;
					if (num != 0)
					{
					}
					string uivalue = this.UIValue;
					this.referencedNode = value;
					this.UpdateValue();
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefSlaveItem> enumerator = this.SlaveFields.GetEnumerator();
					try
					{
						num = (short)1065549855;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::AcpBusinessLayer.AcpRecRefSlaveItem acpRecRefSlaveItem;
							global::AcpBusinessLayer.Recordset recordset;
							switch (num2)
							{
							case 0:
								if (acpRecRefSlaveItem.SlaveField.PrependUIValue == null)
								{
									num = (short)82772009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6FA;
							case 1:
								if (global::AcpCommonLib.AppInfoManager.DndOrImportOperation)
								{
									num = (short)1528889350;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_569;
							case 2:
								if (recordset != null)
								{
									num = (short)1170145297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_569;
							case 3:
								if (this.referencedNode != null)
								{
									num = (short)1854930968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_7A4;
							case 4:
								goto IL_5E1;
							case 5:
								num = (short)1201209369;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)1773076482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								string uivalue2;
								if (!recordset.KeysToNode.Contains(uivalue2))
								{
									goto IL_5E1;
								}
								num = (short)496360913;
								short num3 = num;
								num = (short)272424401;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2FC;
								default:
									num = (short)1509097472;
									if (num != 0)
									{
									}
									num = (short)837812240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
								if (acpRecRefSlaveItem.SlaveField.DirectUIValue != null)
								{
									num = (short)1439825935;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_252;
							case 9:
								num = (short)1263468544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								goto IL_5E1;
							case 11:
								if (this.referencedNode.Parent == recordset.ParentSection.ParentRecset)
								{
									num = (short)1398210598;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_569;
							case 12:
								goto IL_252;
							case 13:
								if (recordset.KeysToNode != null)
								{
									num = (short)1318060066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5E1;
							case 14:
								num = (short)719585293;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
								goto IL_2FC;
							case 16:
							{
								string uivalue2;
								acpRecRefSlaveItem.SlaveField.UIValue = uivalue2;
								num = (short)505348106;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 17:
								num = (short)927268875;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 18:
								if (base.Parent.ParentRecset.ContainerDoc.IsOpen)
								{
									num = (short)64225289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6FA;
							case 19:
								if (!enumerator.MoveNext())
								{
									num = (short)556204064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpRecRefSlaveItem = enumerator.Current;
								num = (short)505872387;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 20:
								recordset = (global::AcpBusinessLayer.Recordset)this.referencedNode[acpRecRefSlaveItem.ChildSectionId].EmbeddedRecset;
								num = (short)1695219713;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 21:
								goto IL_6FA;
							case 22:
								if (base.Parent.ParentRecset.ContainerDoc != null)
								{
									num = (short)991363099;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6FA;
							case 23:
								num = (short)1935212566;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 24:
								num = (short)1687748638;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 25:
								if (this.referencedNode.ReferenceKey == uivalue)
								{
									num = (short)1926823976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_569;
							case 26:
								goto IL_816;
							case 27:
								num = (short)349634578;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 28:
								if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
								{
									num = (short)985137175;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6FA;
							case 29:
								if (this.referencedNode != null)
								{
									num = (short)1361575941;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_569;
							case 30:
								if (this.referencedNode[acpRecRefSlaveItem.ChildSectionId] != null)
								{
									num = (short)1345650708;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_7A4;
							case 31:
								switch (0)
								{
								case 0:
									goto IL_13C;
								}
								continue;
							case 32:
								num = (short)450953242;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 34:
								num = (short)330432519;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 35:
							{
								string uivalue2;
								if (!string.IsNullOrEmpty(uivalue2))
								{
									num = (short)1598554126;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5E1;
							}
							case 36:
								goto IL_77B;
							case 37:
								goto IL_6FA;
							case 38:
								num = (short)1409679389;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 39:
								acpRecRefSlaveItem.SlaveField.SetValue(acpRecRefSlaveItem.SlaveField.defaultValue);
								num = (short)1854668836;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 40:
							{
								string uivalue2 = acpRecRefSlaveItem.SlaveField.UIValue;
								acpRecRefSlaveItem.SlaveField.ResetToDefaultNoConstraints();
								acpRecRefSlaveItem.SlaveField.SetRecset(recordset);
								num = (short)11534371;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 41:
								num = (short)1090715656;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 42:
								goto IL_77B;
							case 43:
								if (acpRecRefSlaveItem.SlaveField.KeyNameField)
								{
									num = (short)1669857319;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpRecRefSlaveItem.SlaveField.ResetToDefaultNoConstraints();
								num = (short)215875626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_13C;
							IL_252:
							acpRecRefSlaveItem.SlaveField.UIValue = acpRecRefSlaveItem.SlaveField.DirectUIValue;
							num = (short)40370213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2FC:
							acpRecRefSlaveItem.SlaveField.DirectUIValue = null;
							num = (short)294322188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_326:
							num = (short)886046739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_13C:
							goto IL_326;
							IL_569:
							num = (short)575668267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5E1:
							acpRecRefSlaveItem.SlaveField.SetUITimer();
							num = (short)405209109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_6FA:
							acpRecRefSlaveItem.SlaveField.CalculateApplicability();
							acpRecRefSlaveItem.SlaveField.CalculateValidity();
							num = (short)1151991841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_77B:
							acpRecRefSlaveItem.SlaveField.SetRecset(recordset);
							num = (short)1672216580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_7A4:
							acpRecRefSlaveItem.SlaveField.b();
							acpRecRefSlaveItem.SlaveField.SetRecset(null);
							num = (short)273743900;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_816:;
					}
					finally
					{
						num = (short)1024196609;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1181548546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_84A;
								}
								continue;
							case 2:
								goto IL_881;
							}
							IL_84A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)472842240;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_881:;
					}
					num = (short)1076166656;
					short num4 = num;
					return;
				}
				}
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000321F4 File Offset: 0x000303F4
		internal override void DeepCopy(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)1222508544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				int num4;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
				bool flag;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_16A;
					case 1:
						goto IL_41B;
					case 2:
						this.UIValue = acpRecRefField.UIValue;
						num = (short)1084489733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)35454977;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.Recordset recset;
									this.SetRecset(recset);
									num = (short)1163591685;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_27E;
									}
									continue;
								case 3:
									goto IL_360;
								case 4:
									num = (short)837484547;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_2E3;
								case 6:
								{
									int num3;
									if (num3 == num4)
									{
										num = (short)45744128;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num3++;
									num = (short)232849410;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)756023300;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.Recordset recset = (global::AcpBusinessLayer.Recordset)enumerator.Current;
									num = (short)394330118;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_309:
								num = (short)1554907143;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_27E:
								goto IL_309;
							}
							IL_2E3:
							IL_360:
							goto IL_16F;
						}
						finally
						{
							num = (short)925778693;
							short num5 = num;
							num = (short)1502036741;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_3E1:
								if (enumerator == null)
								{
									goto IL_41A;
								}
								num = (short)356253696;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1630011392;
								if (num != 0)
								{
								}
								num = (short)1438384129;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1049755650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3E1;
									}
									continue;
								case 2:
									goto IL_418;
								}
								goto IL_3E1;
							}
							IL_418:
							IL_41A:;
						}
						goto Block_4;
					case 4:
					{
						int num3 = 0;
						enumerator = base.ParentNode.EmbeddedRecordsets.GetEnumerator();
						num = (short)1812725763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_5AF;
					case 6:
						if (flag)
						{
							num = (short)1257111556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.SetRecset(acpRecRefField.RefRecset);
						num = (short)1235877898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (flag)
						{
							num = (short)225902600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.RefRecset = acpRecRefField.RefRecset;
						num = (short)607059979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						this.RefRecset = this.RefRecset;
						num = (short)110428160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (base.KeyNameField)
						{
							num = (short)146669568;
							short num6 = num;
							num = (short)873201666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AF;
					case 10:
						goto IL_16F;
					case 11:
						goto IL_20A;
					}
					goto IL_60;
					Block_4:
					try
					{
						IL_41B:
						num = (short)1277820929;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1211498499;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_461;
								}
								continue;
							case 2:
							{
								global::AcpBusinessLayer.Recordset recordset;
								if (acpRecRefField.RefRecset == recordset)
								{
									num = (short)313196551;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num4++;
								num = (short)1089667077;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_53C;
							case 4:
								goto IL_51F;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1595080704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)enumerator.Current;
								num = (short)727252994;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								flag = true;
								num = (short)387842052;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_463:
							num = (short)153944070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_461:
							goto IL_463;
						}
						IL_51F:
						IL_53C:
						goto IL_10D;
					}
					finally
					{
						num = (short)766836737;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1522401282;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_574;
								}
								continue;
							case 2:
								goto IL_5AC;
							}
							IL_574:
							if (enumerator == null)
							{
								break;
							}
							num = (short)310050816;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_5AC:;
					}
					goto IL_5AF;
					IL_10D:
					num = (short)973209606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16F:
					this.DefaultValue = acpRecRefField.Value;
					num = (short)565379081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5AF:
					base.DeepCopy(source);
					num = (short)301268999;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_16A:
				goto IL_626;
				IL_20A:
				num = (short)1672347649;
				if (num != 0)
				{
				}
				IL_626:
				this.UpdateItems();
				return;
				IL_60:
				flag = false;
				acpRecRefField = (global::AcpBusinessLayer.AcpRecRefField)source;
				global::AcpBusinessLayer.Recordset recordset2 = (global::AcpBusinessLayer.Recordset)base.Parent.ParentRecset;
				this.IndexOfDeepCopy = recordset2.IndexOf(source.ParentNode);
				num4 = 0;
				enumerator = acpRecRefField.ParentNode.EmbeddedRecordsets.GetEnumerator();
				num = (short)2011824129;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00032864 File Offset: 0x00030A64
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0003291C File Offset: 0x00030B1C
		private int indexBase
		{
			get
			{
				short num = (short)1846323659;
				short num2 = num;
				num = (short)1228122571;
				switch (num2 == num)
				{
				}
				num = (short)700448768;
				short num3 = num;
				num = (short)334692353;
				if (num != 0)
				{
				}
				num = (short)1256521728;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).IndexBase;
			}
			set
			{
				short num = (short)826636076;
				short num2 = num;
				num = (short)719091500;
				switch (num2 == num)
				{
				}
				num = (short)59965441;
				if (num != 0)
				{
				}
				num = (short)434634752;
				if (num != 0)
				{
				}
				num = (short)91815936;
				short num3 = num;
				((global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl)base.FieldData).IndexBase = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000329D8 File Offset: 0x00030BD8
		public bool OneBased
		{
			get
			{
				short num = (short)1141775110;
				short num2 = num;
				num = (short)344726278;
				switch (num2 == num)
				{
				}
				num = (short)923926528;
				if (num != 0)
				{
				}
				num = (short)2136997889;
				if (num != 0)
				{
				}
				num = (short)1477181440;
				short num3 = num;
				return this.indexBase == 1;
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00032A8C File Offset: 0x00030C8C
		public void AddSlaveField(global::AcpBusinessLayer.AcpRecRefField slave, int sectionID)
		{
			short num = (short)108920841;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefSlaveItem>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					slave.SetRecset(this.ReferencedNode[sectionID].EmbeddedRecset as global::AcpBusinessLayer.Recordset);
					num = (short)1001652231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)227934216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_C4;
				case 3:
					this.slaveFields = new global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefSlaveItem>();
					this.slaveFields.Add(new global::AcpBusinessLayer.AcpRecRefSlaveItem(slave, sectionID));
					num = (short)909705221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.ReferencedNode != null)
					{
						num = (short)1944649729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					goto IL_C4;
				case 6:
					try
					{
						num = (short)517799947;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								slave.SlaveRecRef = true;
								num = (short)995098626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_42B;
							case 2:
								if (this.ReferencedNode != null)
								{
									num = (short)1921646597;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2EB;
							case 3:
								goto IL_34E;
							case 4:
								IL_2E6:
								num = (short)734330881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								num = (short)736493576;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (!enumerator.MoveNext())
								{
									num = (short)113049604;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)2076966921;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								slave.SetRecset(this.ReferencedNode[sectionID].EmbeddedRecset as global::AcpBusinessLayer.Recordset);
								num = (short)1526398986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								if (this.ReferencedNode[sectionID] != null)
								{
									num = (short)1568604167;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2EB;
							case 9:
								if (enumerator.Current.SlaveField == slave)
								{
									num = (short)723910656;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 10:
								goto IL_2EB;
							case 11:
								switch (0)
								{
								case 0:
									goto IL_26C;
								}
								continue;
							}
							IL_2AB:
							num = (short)1132134406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_26C:
							goto IL_2AB;
							IL_2EB:
							num = (short)538966645;
							short num3 = num;
							num = (short)1227422325;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2E6;
							default:
								num = (short)2048262144;
								if (num != 0)
								{
								}
								num = (short)962527235;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_34E:
						return;
						IL_42B:
						goto IL_10C;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					return;
					IL_10C:
					this.slaveFields.Add(new global::AcpBusinessLayer.AcpRecRefSlaveItem(slave, sectionID));
					num = (short)1710817282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return;
				case 8:
					if (this.ReferencedNode[sectionID] != null)
					{
						num = (short)110034944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				}
				IL_4D:
				num = (short)1483210753;
				if (num != 0)
				{
				}
				if (this.slaveFields == null)
				{
					num = (short)111149056;
					short num4 = num;
					num = (short)240582659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				enumerator = this.slaveFields.GetEnumerator();
				num = (short)1926889478;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C4:
				slave.SlaveRecRef = true;
				num = (short)868679684;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00032EF4 File Offset: 0x000310F4
		internal global::System.Collections.Generic.IEnumerable<global::AcpBusinessLayer.AcpRecRefSlaveItem> SlaveFields
		{
			get
			{
				short num = (short)276392037;
				short num2 = num;
				num = (short)81553509;
				switch (num2 == num)
				{
				}
				num = (short)663289857;
				if (num != 0)
				{
				}
				num = (short)1188495360;
				if (num != 0)
				{
				}
				num = (short)1289945088;
				short num3 = num;
				global::AcpBusinessLayer.AcpRecRefField.<get_SlaveFields>d__77 <get_SlaveFields>d__ = new global::AcpBusinessLayer.AcpRecRefField.<get_SlaveFields>d__77(-2);
				<get_SlaveFields>d__.<>4__this = this;
				return <get_SlaveFields>d__;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00032FAC File Offset: 0x000311AC
		internal int SlaveFieldCount
		{
			get
			{
				short num;
				if (this.slaveFields != null)
				{
					num = (short)1111912578;
					short num2 = num;
					num = (short)1810329730;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)560660480;
						if (num != 0)
						{
						}
						return this.slaveFields.Count;
					}
				}
				num = (short)83886081;
				if (num != 0)
				{
				}
				num = (short)44695552;
				short num3 = num;
				return 0;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0003306C File Offset: 0x0003126C
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0003311C File Offset: 0x0003131C
		public bool HasSiblingRecset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)707233617;
				short num2 = num;
				num = (short)993625937;
				switch (num2 == num)
				{
				}
				num = (short)1211891713;
				if (num != 0)
				{
				}
				num = (short)182845440;
				if (num != 0)
				{
				}
				num = (short)194314240;
				short num3 = num;
				return this.<HasSiblingRecset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)1988951968;
				short num2 = num;
				num = (short)1113259936;
				switch (num2 == num)
				{
				}
				num = (short)504102913;
				if (num != 0)
				{
				}
				num = (short)974848000;
				if (num != 0)
				{
				}
				num = (short)1910046720;
				short num3 = num;
				this.<HasSiblingRecset>k__BackingField = value;
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000331CC File Offset: 0x000313CC
		internal void ReferencedNodeDeleted()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefSlaveItem> enumerator;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1768095744;
					short num3 = num2;
					goto IL_CC;
				}
				case 1:
					num2 = (short)133365769;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_2DF;
				case 3:
					if (base.IsEditable == new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable))
					{
						num2 = (short)1575092232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					base.ForceValid = false;
					num2 = (short)1041694730;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_81;
				case 5:
					num2 = (short)1235746817;
					if (num2 != 0)
					{
					}
					try
					{
						num2 = (short)553517062;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_225;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)698220547;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::AcpBusinessLayer.AcpRecRefSlaveItem acpRecRefSlaveItem = enumerator.Current;
								num2 = (short)1526136836;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 3:
								num2 = (short)1915748352;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
							{
								global::AcpBusinessLayer.AcpRecRefSlaveItem acpRecRefSlaveItem;
								if (acpRecRefSlaveItem.SlaveField.ReferencedNode != null)
								{
									num2 = (short)656867333;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 5:
							{
								global::AcpBusinessLayer.AcpRecRefSlaveItem acpRecRefSlaveItem;
								acpRecRefSlaveItem.SlaveField.c();
								num2 = (short)1854930946;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_16D;
								}
								continue;
							}
							IL_16F:
							num2 = (short)386990081;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_16D:
							goto IL_16F;
						}
						IL_225:
						return;
					}
					finally
					{
						num2 = (short)2037645314;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_291;
							case 1:
								enumerator.Dispose();
								num2 = (short)735313920;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_25A;
								}
								continue;
							}
							IL_25A:
							if (enumerator != null)
							{
								num2 = (short)1901854721;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_291:
							num2 = (short)1174624156;
							short num4 = num2;
							num2 = (short)1505843100;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_25A;
							default:
								goto IL_2C7;
							}
						}
						IL_2C7:
						num2 = (short)1503723520;
						if (num2 != 0)
						{
						}
					}
					goto IL_2DF;
				case 6:
					goto IL_330;
				case 7:
					goto IL_81;
				case 8:
					goto IL_104;
				case 9:
					if (!this.Items[0].Temporary)
					{
						num2 = (short)361889792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_330;
				case 10:
					if (this.Items.Count != 0)
					{
						num2 = (short)896335873;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CC;
				case 11:
					if (base.Applicable)
					{
						num2 = (short)1007222786;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_104;
				}
				goto IL_40;
				IL_81:
				enumerator = this.SlaveFields.GetEnumerator();
				num2 = (short)1069219845;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_CC:
				this.Items.Insert(0, new global::AcpBusinessLayer.ListItem(this, this.InvalidText, false, true, true));
				num2 = (short)1530986502;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_104:
				this.c();
				base.SetUITimer();
				num2 = (short)2065104900;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DF:
				num2 = (short)1600323587;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_330:
				this.UIValue = this.InvalidText;
				base.DirectUIValue = this.InvalidText;
				num2 = (short)882245639;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_40:
			this.ReferencedNode = null;
			num2 = (short)714801163;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0003360C File Offset: 0x0003180C
		private void c()
		{
			short num = (short)29818889;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1603533424;
				short num3 = num;
				num = (short)1854470768;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)703004672;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)774963201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.RefRecset.Count > 0)
						{
							num = (short)509870082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23D;
					case 2:
					{
						num = (short)790233088;
						short num4 = num;
						this.ReferencedNode = (this.RefRecset[0] as global::AcpBusinessLayer.FeatureNode);
						this.ReferencedNode.KeyField.AddRecordReference(this);
						num = (short)2078146564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)823066630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_FC;
					case 5:
						goto IL_1CC;
					case 6:
						if (this.IsFirstRecDefault)
						{
							num = (short)1723727879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A9;
					case 7:
						goto IL_1F4;
					case 8:
						if (this.RefRecset != null)
						{
							num = (short)383909888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23D;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_96;
						}
						continue;
					}
					IL_96:
					if (this.PrependUIValue != null)
					{
						num = (short)352845827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1F4:
					this.DefaultValue = this.indexBase;
					num = (short)849346568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1A9:
				this.DefaultValue = this.PrependValue;
				num = (short)229769221;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FC:
			goto IL_23D;
			IL_1CC:
			num = (short)60948481;
			if (num != 0)
			{
			}
			IL_23D:
			base.ForceValid = true;
			base.ResetToDefaultNoConstraints();
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00033864 File Offset: 0x00031A64
		internal override void ResetToDefaultNoConstraints()
		{
			short num = (short)1796276225;
			if (num != 0)
			{
			}
			num = (short)215678998;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					goto IL_199;
				case 1:
					goto IL_199;
				case 2:
					goto IL_2E8;
				case 3:
				{
					num = (short)1125215896;
					short num3 = num;
					num = (short)215445144;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2ED;
					default:
						num = (short)664666112;
						if (num != 0)
						{
						}
						goto IL_34C;
					}
					break;
				}
				case 4:
					if (flag)
					{
						num = (short)1808662533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_448;
				case 5:
					num = (short)702414868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (this.DefaultValue == this.PrependValue2)
					{
						num = (short)1884749833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_199;
				case 7:
					goto IL_1EF;
				case 8:
					if (this.Items[0].ItemName != this.InvalidText)
					{
						num = (short)1720123395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EF;
				case 9:
					goto IL_2ED;
				case 10:
					if (this.Items.Count != 0)
					{
						num = (short)1501757451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34C;
				case 11:
					num = (short)1640103944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					num = (short)1277165568;
					short num4 = num;
					flag = true;
					num = (short)926416911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					num = (short)2055602182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (this.DefaultValue == this.PrependValue)
					{
						num = (short)206962705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1009451027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (this.PrependUIValue != null)
					{
						num = (short)905445397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_199;
				case 16:
					goto IL_21E;
				case 17:
					flag = false;
					num = (short)645136385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					num = (short)1763508234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (this.PrependUIValue2 != null)
					{
						num = (short)1370161165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_199;
				case 20:
					if (this.DefaultValue == -1)
					{
						num = (short)18415634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.ReferencedNode = (this.RefRecset[this.DefaultValue - this.indexBase] as global::AcpBusinessLayer.FeatureNode);
					num = (short)2080440322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)174718990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				}
				IL_A9:
				if (this.RefRecset != null)
				{
					num = (short)1098842124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_199:
				num = (short)480051204;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EF:
				this.UIValue = this.InvalidText;
				base.DirectUIValue = this.InvalidText;
				num = (short)1767178256;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2ED:
				flag = false;
				num = (short)552730624;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34C:
				this.Items.Insert(0, new global::AcpBusinessLayer.ListItem(this, this.InvalidText, false, true, true));
				num = (short)1080033287;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_21E:
			IL_2E8:
			IL_448:
			base.ResetToDefaultNoConstraints();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00033CC0 File Offset: 0x00031EC0
		public override void ResetToDefaultWithUndo()
		{
			short num = (short)148570113;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_84;
			}
			int num2;
			string text;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
					if (this.UIValue.CompareTo(text) != 0)
					{
						num = (short)985333763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				case 1:
					goto IL_232;
				case 2:
					if (this.IsFirstRecDefault)
					{
						num = (short)1058668555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1019478023;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_14E;
				case 4:
					num = (short)1758134274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(this.CreateSetValueTask(text));
					num = (short)1692991504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (this.RefRecset.Count > 0)
					{
						num = (short)135266321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_232;
				case 7:
					if (this.UIValue != this.PrependUIValue)
					{
						num = (short)1721827328;
						short num3 = num;
						num = (short)1982595080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_232;
				case 8:
					text = this.PrependUIValue;
					num = (short)580583425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1593966592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)397410310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_174;
				case 12:
					if (this.RefRecset != null)
					{
						num = (short)931856394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_232;
				case 13:
					if (text != string.Empty)
					{
						num = (short)257425413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				case 14:
					goto IL_232;
				case 15:
					if (this.UIValue != null)
					{
						num = (short)1106771977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				case 16:
					goto IL_293;
				case 17:
					text = this.RefRecset[0].ReferenceKey;
					num = (short)1395261454;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
				{
					num = (short)1111070463;
					short num4 = num;
					num = (short)207591167;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14E;
					default:
						num = (short)372441088;
						if (num != 0)
						{
						}
						if (this.PrependUIValue != null)
						{
							num = (short)2112159748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_174;
					}
					break;
				}
				}
				goto IL_84;
				IL_14E:
				num = (short)1912209421;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_174:
				num = (short)2134704140;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_232:
				num = (short)507641871;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_293:
			IL_37C:
			base.SetUITimer();
			return;
			IL_84:
			text = string.Empty;
			num = (short)341901330;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00034050 File Offset: 0x00032250
		public override void ResetToDefaultWithUndo(global::AcpCommonLib.UndoRedo.ContainerTask taskContainer)
		{
			switch (0)
			{
			case 0:
				goto IL_5C;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.UIValue.CompareTo(text) != 0)
					{
						num2 = (short)1731395587;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_388;
				case 1:
					goto IL_23B;
				case 2:
					if (this.IsFirstRecDefault)
					{
						num2 = (short)353632267;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)988479495;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_153;
				case 4:
					num2 = (short)611713026;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					taskContainer.AddTask(this.CreateSetValueTask(text));
					num2 = (short)78446608;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (this.RefRecset.Count > 0)
					{
						num2 = (short)942669841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23B;
				case 7:
					if (this.UIValue != this.PrependUIValue)
					{
						num2 = (short)1665204224;
						short num3 = num2;
						num2 = (short)2091122696;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23B;
				case 8:
					text = this.PrependUIValue;
					num2 = (short)1344602113;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1980760064;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1734803462;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_179;
				case 12:
					if (this.RefRecset != null)
					{
						num2 = (short)2032140298;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23B;
				case 13:
					if (text != string.Empty)
					{
						num2 = (short)960299013;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_388;
				case 14:
					goto IL_23B;
				case 15:
					if (this.UIValue != null)
					{
						num2 = (short)1052770313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_388;
				case 16:
					goto IL_2A0;
				case 17:
					text = this.RefRecset[0].ReferenceKey;
					num2 = (short)1298071566;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
				{
					num2 = (short)734769064;
					short num4 = num2;
					num2 = (short)653504424;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_153;
					default:
						num2 = (short)18743296;
						if (num2 != 0)
						{
						}
						if (this.PrependUIValue != null)
						{
							num2 = (short)827588612;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_179;
					}
					break;
				}
				}
				goto IL_5C;
				IL_153:
				num2 = (short)567738381;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_179:
				num2 = (short)1559822348;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_23B:
				num2 = (short)1676476431;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_2A0:
			IL_388:
			base.SetUITimer();
			return;
			IL_5C:
			num2 = (short)1701380097;
			if (num2 != 0)
			{
			}
			text = string.Empty;
			num2 = (short)1278672914;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000343EC File Offset: 0x000325EC
		internal override void CreateFieldData(string uiName)
		{
			short num = (short)513340000;
			short num2 = num;
			num = (short)2029515360;
			switch (num2 == num)
			{
			}
			num = (short)1690959872;
			short num3 = num;
			num = (short)2044133377;
			if (num != 0)
			{
			}
			num = (short)409141248;
			if (num != 0)
			{
			}
			base.FieldData = new global::AcpBusinessLayer.Impl.AcpRecRefFieldImpl(uiName);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000344A0 File Offset: 0x000326A0
		public override global::AcpCommonLib.UndoRedo.UndoableTask CopyValueOf(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)93716480;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num3;
			global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
			string uivalue;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					if (acpRecRefField != null)
					{
						num = (short)474546180;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18E;
				case 1:
					goto IL_CD;
				case 2:
					if (!this.UIValue.Equals(uivalue))
					{
						num = (short)539820033;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18E;
				case 3:
					if (this.UIValue != null)
					{
						num = (short)17170437;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88;
				case 4:
					this.DefaultValue = acpRecRefField.DefaultValue;
					uivalue = acpRecRefField.UIValue;
					num = (short)396492803;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)743332092;
					short num4 = num;
					num = (short)2102352124;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)924254208;
						if (num != 0)
						{
						}
						num = (short)507052033;
						if (num != 0)
						{
						}
						num = (short)1164967938;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_50;
			}
			IL_88:
			return this.CreateSetValueTask(uivalue);
			IL_CD:
			goto IL_88;
			IL_18E:
			return null;
			IL_50:
			acpRecRefField = (source as global::AcpBusinessLayer.AcpRecRefField);
			num = (short)1438253056;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0003463C File Offset: 0x0003283C
		public void CleanupDuplicates()
		{
			short num = (short)977272832;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 1:
					if (this.Items[0].Temporary)
					{
						num = (short)821559298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_2B3;
				case 3:
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator = this.Items.GetEnumerator();
					num = (short)1051590662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				case 5:
					num = (short)1897267201;
					if (num != 0)
					{
					}
					if (this.Items[0].ItemName != this.InvalidText)
					{
						num = (short)1789460483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					try
					{
						num = (short)1537976939;
						short num3 = num;
						num = (short)1441180267;
						global::AcpBusinessLayer.ListItem listItem;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_175:
							if (!(this.Items[0].ItemName == listItem.ItemName))
							{
								goto IL_127;
							}
							num = (short)1197408257;
							num2 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)908591104;
							if (num != 0)
							{
							}
							num = (short)1204420610;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						for (;;)
						{
							IL_FB:
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)923205639;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								listItem = enumerator.Current;
								num = (short)1406926853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								this.Items.RemoveAt(0);
								this.UIValue = listItem.ItemName;
								num = (short)711065608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_125;
								}
								continue;
							case 3:
								num = (short)623181828;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_175;
							case 5:
								if (this.Items[0] != listItem)
								{
									num = (short)663224323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 6:
								goto IL_245;
							case 7:
								num = (short)883163142;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_229;
							}
							break;
						}
						IL_125:
						goto IL_127;
						IL_229:
						IL_245:
						return;
						IL_127:
						num = (short)487784448;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_FB;
					}
					finally
					{
						num = (short)325517313;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)493355010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_27B;
								}
								continue;
							case 2:
								goto IL_2B0;
							}
							IL_27B:
							if (enumerator == null)
							{
								break;
							}
							num = (short)860684288;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2B0:;
					}
					goto IL_2B3;
				}
				IL_40:
				num = (short)1633419264;
				short num4 = num;
				if (this.Items.Count == 0)
				{
					num = (short)125566980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1980760065;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B3:
				num = (short)21889029;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00034A08 File Offset: 0x00032C08
		public override void CalculateItemsValidity()
		{
			short num = (short)424476672;
			switch (num)
			{
			default:
			{
				num = (short)1748238336;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1353842688;
					short num3 = num;
					int num4;
					int num5;
					int num7;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_CA;
						}
						continue;
					case 1:
						this.Items[num4].ItemValidity = base.IsIndexValid(base.Parent, this.PrependValue);
						num = (short)880541713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1448607760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num5 = 1;
						goto IL_452;
					case 4:
						if (this.PrependUIValue2 != null)
						{
							num = (short)1996488724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_356;
					case 5:
						this.Items[num4 + 1].ItemValidity = base.IsIndexValid(base.Parent, this.PrependValue2);
						num = (short)1307967503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator = this.Items.GetEnumerator();
						num = (short)21168139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (num4 < this.Items.Count)
						{
							num = (short)2110849025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					case 8:
						return;
					case 9:
						if (num4 + 1 < this.Items.Count)
						{
							num = (short)288030725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_356;
					case 10:
						if (!this.Items[0].Temporary)
						{
							num = (short)1957429250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1717174275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						try
						{
							num = (short)1510473728;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1E4;
									}
									continue;
								case 1:
								{
									global::AcpBusinessLayer.AcpRecRefItem acpRecRefItem;
									acpRecRefItem.ItemValidity = true;
									num = (short)1559560194;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpBusinessLayer.AcpRecRefItem acpRecRefItem;
									if (acpRecRefItem != null)
									{
										num = (short)300941313;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1016397829;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpRecRefItem acpRecRefItem = enumerator.Current as global::AcpBusinessLayer.AcpRecRefItem;
									num = (short)357433347;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									num = (short)1797402042;
									short num6 = num;
									num = (short)864103866;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)15269888;
										if (num != 0)
										{
										}
										num = (short)1257439238;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_2E4;
								}
								IL_1E6:
								num = (short)669122564;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E4:
								goto IL_1E6;
							}
							IL_2E4:
							return;
						}
						finally
						{
							num = (short)1513881601;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1014890498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_31D;
									}
									continue;
								case 2:
									goto IL_353;
								}
								IL_31D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1906507776;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_353:;
						}
						goto IL_356;
					case 12:
						if (this.PrependUIValue != null)
						{
							num = (short)2081095698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					case 13:
						return;
					case 14:
						goto IL_564;
					case 15:
						goto IL_356;
					case 16:
						num5 = 0;
						goto IL_452;
					case 17:
						goto IL_15F;
					case 18:
						num = (short)1472069633;
						if (num != 0)
						{
						}
						num = (short)891486215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (num7 >= this.Items.Count)
						{
							num = (short)1037434888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.Items[num7].ItemValidity = base.IsIndexValid(base.Parent, num7 + this.indexBase - this.PrependCount - num4);
						num7++;
						num = (short)405012494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1291714569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_564;
					case 22:
						if (base.IsIndexValid == null)
						{
							num = (short)752287750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)374865930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CA:
					if (this.Items.Count == 0)
					{
						num = (short)1646526477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1210449942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15F:
					num = (short)1458176004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_356:
					num7 = this.PrependCount + num4;
					num = (short)1704919061;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_452:
					num4 = num5;
					((global::AcpBusinessLayer.FeatureSection)base.Parent).CurrentField = this;
					num = (short)449314828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_564:
					num = (short)1017839635;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00035064 File Offset: 0x00033264
		private void b()
		{
			short num = (short)2103115777;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (this.IsFirstRecDefault)
					{
						num = (short)1819475971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2000248875;
					short num3 = num;
					num = (short)891707435;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_61;
					default:
						goto IL_F2;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					goto IL_61;
				case 3:
					goto IL_93;
				}
				IL_35:
				if (this.PrependUIValue != null)
				{
					num = (short)1075249154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_61:
				num = (short)2112749568;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_54:
			this.DefaultValue = this.indexBase;
			return;
			IL_93:
			num = (short)216006657;
			if (num != 0)
			{
			}
			goto IL_54;
			IL_F2:
			num = (short)427556864;
			if (num != 0)
			{
			}
			num = (short)1526792192;
			short num4 = num;
			this.DefaultValue = this.PrependValue;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000351B0 File Offset: 0x000333B0
		internal override global::AcpCommonLib.UndoRedo.UndoableTask CreateSetValueTask(string newValue)
		{
			short num;
			global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask modifyRecRefDataTask;
			for (;;)
			{
				num = (short)1656356865;
				if (num != 0)
				{
				}
				modifyRecRefDataTask = new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(this, newValue);
				if (base.ValueSetter == null)
				{
					return modifyRecRefDataTask;
				}
				num = (short)1072760647;
				short num2 = num;
				num = (short)2028865351;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_72;
				}
			}
			IL_72:
			num = (short)698744832;
			if (num != 0)
			{
			}
			num = (short)799801344;
			short num3 = num;
			global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(modifyRecRefDataTask.ToString());
			containerTask.AddTask(modifyRecRefDataTask);
			this.CallValueSetter(containerTask);
			return containerTask;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00035290 File Offset: 0x00033490
		internal override int CompareToHelper(global::AcpBusinessLayer.AcpFieldBase otherField)
		{
			switch (0)
			{
			case 0:
				goto IL_A2;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
			int result;
			for (;;)
			{
				IL_0A:
				num = (short)2028063220;
				short num2 = num;
				num = (short)1278069236;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1038417920;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (acpRecRefField.UIValue != this.InvalidText)
						{
							num = (short)2135818250;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21D;
					case 1:
						if (acpRecRefField.UIValue != null)
						{
							num = (short)298254339;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						if (acpRecRefField == null)
						{
							num = (short)308281355;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)594935824;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)65077260;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)990511113;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (acpRecRefField.UIValue != null)
						{
							num = (short)2014183438;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21D;
					case 6:
						return result;
					case 7:
						result = -1;
						num = (short)2083979272;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						return result;
					case 9:
						num = (short)1900544001;
						if (num != 0)
						{
						}
						if (this.UIValue != this.InvalidText)
						{
							num = (short)1049231377;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					case 10:
						result = this.UIValue.CompareTo(acpRecRefField.UIValue);
						num = (short)291307535;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						result = 1;
						num = (short)705298438;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_1D0;
					case 13:
						return result;
					case 14:
						num = (short)210305024;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						return result;
					case 16:
					{
						num = (short)1007747072;
						short num4 = num;
						if (this.UIValue != null)
						{
							num = (short)1034158084;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					}
					case 17:
						num = (short)469499909;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A2;
					IL_E5:
					num = (short)877133825;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_21D:
					result = 1;
					num = (short)216137741;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1D0:
				if (!(acpRecRefField.UIValue != this.InvalidText))
				{
					break;
				}
				num = (short)1860370439;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_A2:
			result = 0;
			acpRecRefField = (otherField as global::AcpBusinessLayer.AcpRecRefField);
			num = (short)1778647042;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000355EC File Offset: 0x000337EC
		public void RefreshRecRefItems()
		{
			short num = (short)2050228225;
			if (num != 0)
			{
			}
			num = (short)277151744;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator = this.Items.GetEnumerator();
			try
			{
				num = (short)1047527429;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1367408642;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpRecRefItem acpRecRefItem = enumerator.Current as global::AcpBusinessLayer.AcpRecRefItem;
						num = (short)149094406;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)2085093379;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_19E;
					case 4:
					{
						global::AcpBusinessLayer.AcpRecRefItem acpRecRefItem;
						acpRecRefItem.ItemName = acpRecRefItem.Node.ReferenceKey;
						num = (short)201949183;
						short num4 = num;
						num = (short)1290174463;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)382730240;
							if (num != 0)
							{
							}
							num = (short)1577451520;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					case 6:
					{
						global::AcpBusinessLayer.AcpRecRefItem acpRecRefItem;
						if (acpRecRefItem != null)
						{
							num = (short)2006908932;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_D8:
					num = (short)726859777;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_9D:
					goto IL_D8;
				}
				IL_19E:;
			}
			finally
			{
				num = (short)1138294786;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)511901697;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_205;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1D0;
						}
						continue;
					}
					IL_1D0:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1932525568;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_205:;
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00035820 File Offset: 0x00033A20
		public global::System.Collections.Generic.IEnumerator<string> GetEnumerator()
		{
			short num = (short)1288748854;
			short num2 = num;
			num = (short)2038742838;
			switch (num2 == num)
			{
			}
			num = (short)1243873280;
			short num3 = num;
			num = (short)1918763009;
			if (num != 0)
			{
			}
			num = (short)1068564480;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.AcpRecRefField.<GetEnumerator>d__97 <GetEnumerator>d__ = new global::AcpBusinessLayer.AcpRecRefField.<GetEnumerator>d__97(0);
			<GetEnumerator>d__.<>4__this = this;
			return <GetEnumerator>d__;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000358D8 File Offset: 0x00033AD8
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)443011135;
			short num2 = num;
			num = (short)1660538943;
			switch (num2 == num)
			{
			}
			num = (short)1592721408;
			short num3 = num;
			num = (short)91422721;
			if (num != 0)
			{
			}
			num = (short)1718484992;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00035984 File Offset: 0x00033B84
		protected override void Dispose(bool disposing)
		{
			short num = (short)705363974;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_151;
				case 1:
					if (!this.disposedValue)
					{
						num = (short)130351105;
						if (num != 0)
						{
						}
						num = (short)1936392196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B5;
				case 2:
					this.isDisposeInProgress = true;
					this.a();
					num = (short)1607335941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (disposing)
					{
						num = (short)456261634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BC;
				case 4:
					num = (short)256704515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_BC;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 7:
					return;
				}
				goto IL_45;
				for (;;)
				{
					IL_BC:
					this.disposedValue = true;
					num = (short)242124511;
					short num3 = num;
					num = (short)741639903;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_F9;
					}
				}
				IL_F9:
				num = (short)654376960;
				short num4 = num;
				num = (short)1513750528;
				if (num != 0)
				{
				}
				num = (short)2069037056;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45:
				if (this.isDisposeInProgress)
				{
					num = (short)2122645511;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)201457665;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			IL_151:
			IL_1B5:
			this.isDisposeInProgress = false;
			base.Dispose(disposing);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00035B54 File Offset: 0x00033D54
		private void a()
		{
			short num = (short)159776770;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.RefRecset.CollectionChanged -= this.a;
					this.RefRecset.ReferenceKeyChanged -= this.a;
					this.RefRecset.Dispose();
					num = (short)1318649857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)1011875840;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				}
				IL_58:
				if (this.RefRecset == null)
				{
					break;
				}
				num = (short)2056188330;
				short num4 = num;
				num = (short)951447978;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)35586049;
					if (num != 0)
					{
					}
					num = (short)1070923776;
					if (num != 0)
					{
					}
					num = (short)1412694016;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0400007C RID: 124
		private int defaultValue;

		// Token: 0x0400007D RID: 125
		public const int NullReference = -1;

		// Token: 0x0400007E RID: 126
		private int IndexOfDeepCopy;

		// Token: 0x0400007F RID: 127
		private global::AcpBusinessLayer.FeatureNode referencedNode;

		// Token: 0x04000080 RID: 128
		private global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefSlaveItem> slaveFields;

		// Token: 0x04000081 RID: 129
		private bool disposedValue;

		// Token: 0x04000082 RID: 130
		private bool isDisposeInProgress;
	}
}
