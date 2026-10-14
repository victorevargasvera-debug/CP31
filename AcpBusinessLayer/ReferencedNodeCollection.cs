using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace AcpBusinessLayer
{
	// Token: 0x0200003B RID: 59
	public class ReferencedNodeCollection : global::System.Collections.ObjectModel.KeyedCollection<string, global::AcpBusinessLayer.FeatureNode>, global::System.IDisposable
	{
		// Token: 0x06000496 RID: 1174 RVA: 0x0006378C File Offset: 0x0006198C
		private ReferencedNodeCollection()
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000637A0 File Offset: 0x000619A0
		internal ReferencedNodeCollection(global::AcpBusinessLayer.Recordset container) : this()
		{
			this.Container = container;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x000637BC File Offset: 0x000619BC
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00063868 File Offset: 0x00061A68
		internal global::AcpBusinessLayer.Recordset Container
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1657454985;
				short num2 = num;
				num = (short)847561097;
				switch (num2 == num)
				{
				}
				num = (short)1260584961;
				if (num != 0)
				{
				}
				num = (short)102236160;
				if (num != 0)
				{
				}
				num = (short)1335296000;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1408106338;
				short num2 = num;
				num = (short)491781986;
				switch (num2 == num)
				{
				}
				num = (short)786694145;
				if (num != 0)
				{
				}
				num = (short)1522597888;
				if (num != 0)
				{
				}
				num = (short)1079377920;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00063918 File Offset: 0x00061B18
		protected override string GetKeyForItem(global::AcpBusinessLayer.FeatureNode item)
		{
			short num = (short)1441267715;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1367474176;
					short num3 = num;
					try
					{
						num = (short)302710788;
						num2 = (int)((global::System.IntPtr)num);
						string result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)751435779;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text = enumerator.Current;
								num = (short)1030029318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_19A;
							case 2:
								goto IL_136;
							case 3:
								num = (short)1553006593;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_E8;
								}
								continue;
							case 5:
							{
								string text;
								result = text;
								num = (short)833552386;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								string text;
								if (base.Dictionary[text] == item)
								{
									num = (short)1607794693;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_EA:
							num = (short)2078736384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_E8:
							goto IL_EA;
						}
						IL_136:
						return result;
						IL_19A:
						goto IL_272;
					}
					finally
					{
						num = (short)647626752;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<string> enumerator;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1CF;
								}
								continue;
							case 1:
								goto IL_204;
							case 2:
								enumerator.Dispose();
								num = (short)398917633;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1CF:
							if (enumerator == null)
							{
								break;
							}
							num = (short)250478594;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_204:;
					}
					goto IL_207;
				}
				case 1:
				{
					num = (short)1690828801;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<string> enumerator = base.Dictionary.Keys.GetEnumerator();
					num = (short)1426849792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (base.Dictionary.Values.Contains(item))
					{
						num = (short)739835905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_272;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					goto IL_207;
				}
				IL_38:
				num = (short)764888273;
				short num4 = num;
				num = (short)370492625;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_272;
				default:
					num = (short)1010565120;
					if (num != 0)
					{
					}
					if (base.Dictionary != null)
					{
						num = (short)1195048964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_272;
				}
				IL_207:
				num = (short)1459617794;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_272:
			return item.ReferenceKey;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00063C08 File Offset: 0x00061E08
		internal void ChangeKey(global::AcpBusinessLayer.FeatureNode item, string newKey)
		{
			short num;
			try
			{
				for (;;)
				{
					IL_00:
					num = (short)512884737;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)515779777;
						short num3 = num;
						num = (short)1014770881;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)442761216;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								if (!base.Contains(item))
								{
									num = (short)928448515;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								base.ChangeItemKey(item, newKey);
								num = (short)1006043144;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_99;
								}
								continue;
							case 2:
								goto IL_1E1;
							case 3:
								this.Container.ValidateReferenceKey(newKey);
								base.ChangeItemKey(item, newKey);
								num = (short)1907621892;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_1E1;
							case 5:
								goto IL_1F8;
							case 6:
								if (base[newKey] != item)
								{
									num = (short)610140169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E1;
							case 7:
								num = (short)249823238;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								num = (short)754581505;
								if (num != 0)
								{
								}
								goto IL_1E1;
							case 9:
								base.Remove(newKey);
								this.Container.ValidateReferenceKey(newKey);
								base.ChangeItemKey(item, newKey);
								num = (short)1113063426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_99:
							if (base.Contains(newKey))
							{
								num = (short)622919687;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							num = (short)1555496960;
							num2 = (int)((global::System.IntPtr)num);
							break;
							IL_1E1:
							num = (short)2023817221;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
				IL_1F8:;
			}
			catch (global::System.Exception)
			{
			}
			num = (short)731906048;
			short num4 = num;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00063E58 File Offset: 0x00062058
		internal void UpdateKey(global::AcpBusinessLayer.FeatureNode item)
		{
			short num = (short)1931040003;
			short num2 = num;
			num = (short)1773753603;
			switch (num2 == num)
			{
			}
			num = (short)1548746752;
			short num3 = num;
			num = (short)35717121;
			if (num != 0)
			{
			}
			num = (short)1177354240;
			if (num != 0)
			{
			}
			this.ChangeKey(item, item.ReferenceKey);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00063F0C File Offset: 0x0006210C
		internal global::AcpBusinessLayer.FeatureNode LookupHelper(string key)
		{
			short num = (short)247726080;
			short num2 = num;
			num = (short)975568897;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)1309999107;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1411710977;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				case 2:
				{
					num = (short)32254276;
					short num4 = num;
					num = (short)1896950084;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8A;
					default:
						goto IL_111;
					}
					break;
				}
				case 3:
					if (base.Contains(key))
					{
						num = (short)1934622722;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12C;
				}
				goto IL_84;
				IL_8A:
				num = (short)1015349248;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_84:
				if (key != null)
				{
					goto IL_8A;
				}
				goto IL_12C;
			}
			IL_111:
			num = (short)2101280768;
			if (num != 0)
			{
			}
			return base[key];
			IL_12C:
			return null;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00064048 File Offset: 0x00062248
		internal void DeleteItem(global::AcpBusinessLayer.FeatureNode item)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1171587072;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)1257504768;
						short num3 = num;
						this.UpdateKey(item);
						base.Remove(item.ReferenceKey);
						num = (short)755695617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_30:
					num = (short)574699104;
					short num4 = num;
					num = (short)1499543136;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)345440256;
						if (num != 0)
						{
						}
						if (!base.Contains(item))
						{
							return;
						}
						num = (short)506134529;
						if (num != 0)
						{
						}
						num = (short)433782786;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00064170 File Offset: 0x00062370
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)242024452;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.a)
					{
						num = (short)1546387465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D7;
				case 1:
					if (disposing)
					{
						num = (short)1690763271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25D;
				case 2:
					goto IL_1D6;
				case 3:
				{
					num = (short)1026792241;
					short num3 = num;
					num = (short)542612273;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A8;
					default:
						num = (short)851771393;
						if (num != 0)
						{
						}
						num = (short)828637184;
						if (num != 0)
						{
						}
						goto IL_1D6;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 5:
				{
					num = (short)1093795840;
					short num4 = num;
					if (base.Items != null)
					{
						num = (short)526909451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25D;
				}
				case 6:
				{
					global::AcpBusinessLayer.Recordset container = this.Container;
					if (container == null)
					{
						num = (short)2048655363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					container.Dispose();
					num = (short)1786707970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					this.b = true;
					num = (short)853016582;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_27C;
				case 9:
					goto IL_1A8;
				case 10:
					return;
				case 11:
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.Items.GetEnumerator();
					num = (short)1280311308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					try
					{
						num = (short)249954308;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1847459843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)777977858;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_36B;
							case 2:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
								if (featureNode == null)
								{
									num = (short)1953169414;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								featureNode.Dispose();
								num = (short)1537540101;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)1676214273;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_2C1;
								}
								continue;
							}
							IL_2C3:
							num = (short)293994496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2C1:
							goto IL_2C3;
						}
						IL_36B:
						goto IL_25D;
					}
					finally
					{
						num = (short)2055798784;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3A1;
								}
								continue;
							case 1:
								goto IL_3D4;
							case 2:
								enumerator.Dispose();
								num = (short)313065473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3A1:
							if (enumerator == null)
							{
								break;
							}
							num = (short)430047234;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3D4:;
					}
					goto IL_3D7;
				}
				IL_58:
				if (this.b)
				{
					num = (short)2009595914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1551564800;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A8:
				num = (short)1686896641;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D6:
				num = (short)1922826245;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25D:
				this.a = true;
				num = (short)288686088;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_27C:
			IL_3D7:
			this.b = false;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0006456C File Offset: 0x0006276C
		public void Dispose()
		{
			short num = (short)561519686;
			short num2 = num;
			num = (short)2002590790;
			switch (num2 == num)
			{
			}
			num = (short)2142896128;
			short num3 = num;
			num = (short)2145779712;
			if (num != 0)
			{
			}
			num = (short)844759041;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000138 RID: 312
		private bool a;

		// Token: 0x04000139 RID: 313
		private bool b;

		// Token: 0x0400013A RID: 314
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpBusinessLayer.Recordset c;
	}
}
