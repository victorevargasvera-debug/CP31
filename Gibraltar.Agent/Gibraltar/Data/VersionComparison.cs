using System;
using System.Text;

namespace Gibraltar.Data
{
	// Token: 0x020000EF RID: 239
	internal class VersionComparison : global::System.IComparable<global::Gibraltar.Data.VersionComparison>
	{
		// Token: 0x060009E1 RID: 2529 RVA: 0x00017EC4 File Offset: 0x000160C4
		public VersionComparison(global::System.Version version) : this(version.ToString())
		{
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00017ED4 File Offset: 0x000160D4
		public VersionComparison(string versionString)
		{
			if (string.IsNullOrEmpty(versionString))
			{
				this.m_VersionArray = new int[]
				{
					-1
				};
				return;
			}
			string[] array = versionString.Split(new char[]
			{
				'.'
			});
			int num = array.Length;
			this.m_VersionArray = new int[num];
			for (int i = 0; i < num; i++)
			{
				int num2;
				if (!int.TryParse(array[i], out num2))
				{
					if (!(array[i] == "*") && (i != num - 1 || !string.IsNullOrEmpty(array[i])))
					{
						throw new global::Gibraltar.GibraltarException(string.Format("Unrecognized component [{0}] \"{1}\" in version string \"{2}\".", i, array[i], versionString));
					}
					num2 = -1;
				}
				this.m_VersionArray[i] = num2;
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00017FAC File Offset: 0x000161AC
		public int CompareTo(global::Gibraltar.Data.VersionComparison other)
		{
			if (other == null)
			{
				return int.MaxValue;
			}
			int num = 0;
			for (int i = 0; i < this.m_VersionArray.Length; i++)
			{
				if (this.m_VersionArray[i] >= 0)
				{
					if (other.m_VersionArray.Length > i && other.m_VersionArray[i] >= 0)
					{
						num = this.m_VersionArray[i] - other.m_VersionArray[i];
					}
					else
					{
						num = this.m_VersionArray[i];
					}
				}
				if (num != 0)
				{
					break;
				}
			}
			return num;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00018034 File Offset: 0x00016234
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append((this.m_VersionArray[0] < 0) ? "*" : this.m_VersionArray[0].ToString());
			for (int i = 1; i < this.m_VersionArray.Length; i++)
			{
				stringBuilder.Append(".");
				stringBuilder.Append((this.m_VersionArray[i] < 0) ? "*" : this.m_VersionArray[i].ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000263 RID: 611
		private readonly int[] m_VersionArray;
	}
}
