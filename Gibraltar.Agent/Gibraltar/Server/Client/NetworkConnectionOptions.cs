using System;
using System.Diagnostics;

namespace Gibraltar.Server.Client
{
	// Token: 0x020000D3 RID: 211
	[global::System.Diagnostics.DebuggerDisplay("{HostName}:{Port} UseSsl: {UseSsl}")]
	internal class NetworkConnectionOptions : global::System.IComparable<global::Gibraltar.Server.Client.NetworkConnectionOptions>, global::System.IEquatable<global::Gibraltar.Server.Client.NetworkConnectionOptions>
	{
		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x000134F0 File Offset: 0x000116F0
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x000134F8 File Offset: 0x000116F8
		public int Port { get; set; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00013504 File Offset: 0x00011704
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x0001350C File Offset: 0x0001170C
		public string HostName { get; set; }

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00013518 File Offset: 0x00011718
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00013520 File Offset: 0x00011720
		public bool UseSsl { get; set; }

		// Token: 0x060008CC RID: 2252 RVA: 0x0001352C File Offset: 0x0001172C
		public global::Gibraltar.Server.Client.NetworkConnectionOptions Clone()
		{
			return new global::Gibraltar.Server.Client.NetworkConnectionOptions
			{
				HostName = this.HostName,
				Port = this.Port,
				UseSsl = this.UseSsl
			};
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00013568 File Offset: 0x00011768
		public override string ToString()
		{
			return string.Format("{0}:{1} UseSsl: {2}", this.HostName, this.Port, this.UseSsl);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000135A0 File Offset: 0x000117A0
		public int CompareTo(global::Gibraltar.Server.Client.NetworkConnectionOptions other)
		{
			if (other == null)
			{
				return 1;
			}
			if (this == other)
			{
				return 0;
			}
			int num = 0;
			if (this.HostName != other.HostName)
			{
				if (this.HostName == null)
				{
					num = -1;
				}
				else if (other.HostName == null)
				{
					num = 1;
				}
				else
				{
					num = string.Compare(this.HostName, other.HostName, global::System.StringComparison.OrdinalIgnoreCase);
				}
			}
			if (num == 0)
			{
				num = this.Port.CompareTo(other.Port);
			}
			if (num == 0)
			{
				num = this.UseSsl.CompareTo(other.UseSsl);
			}
			return num;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00013648 File Offset: 0x00011848
		public override bool Equals(object obj)
		{
			global::Gibraltar.Server.Client.NetworkConnectionOptions other = obj as global::Gibraltar.Server.Client.NetworkConnectionOptions;
			return this.Equals(other);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00013668 File Offset: 0x00011868
		public bool Equals(global::Gibraltar.Server.Client.NetworkConnectionOptions other)
		{
			return this.CompareTo(other) == 0;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0001367C File Offset: 0x0001187C
		public override int GetHashCode()
		{
			if (this.m_HashCode == 0)
			{
				this.CalculateHash();
			}
			return this.m_HashCode;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0001369C File Offset: 0x0001189C
		public static bool operator ==(global::Gibraltar.Server.Client.NetworkConnectionOptions left, global::Gibraltar.Server.Client.NetworkConnectionOptions right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000136B0 File Offset: 0x000118B0
		public static bool operator !=(global::Gibraltar.Server.Client.NetworkConnectionOptions left, global::Gibraltar.Server.Client.NetworkConnectionOptions right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000136C8 File Offset: 0x000118C8
		public static bool operator <(global::Gibraltar.Server.Client.NetworkConnectionOptions left, global::Gibraltar.Server.Client.NetworkConnectionOptions right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000136D4 File Offset: 0x000118D4
		public static bool operator >(global::Gibraltar.Server.Client.NetworkConnectionOptions left, global::Gibraltar.Server.Client.NetworkConnectionOptions right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000136E0 File Offset: 0x000118E0
		private void CalculateHash()
		{
			int num = this.UseSsl.GetHashCode();
			num ^= this.Port.GetHashCode();
			if (this.HostName != null)
			{
				num ^= this.HostName.ToLowerInvariant().GetHashCode();
			}
			this.m_HashCode = num;
		}

		// Token: 0x040001E6 RID: 486
		private volatile int m_HashCode;
	}
}
