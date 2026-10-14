using System;
using System.Reflection;
using System.Reflection.Emit;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x020001A0 RID: 416
	internal class SessionAssemblyInfo : global::Gibraltar.Monitor.Internal.IDisplayable, global::System.IComparable<global::Gibraltar.Monitor.SessionAssemblyInfo>, global::System.IEquatable<global::Gibraltar.Monitor.SessionAssemblyInfo>
	{
		// Token: 0x0600124F RID: 4687 RVA: 0x000354C4 File Offset: 0x000336C4
		public SessionAssemblyInfo(global::System.Reflection.Assembly target, bool includeLocation)
		{
			this.m_Packet = new global::Gibraltar.Monitor.Internal.AssemblyInfoPacket();
			this.m_Packet.FullName = target.FullName;
			this.m_Packet.GlobalAssemblyCache = target.GlobalAssemblyCache;
			this.m_Packet.ImageRuntimeVersion = target.ImageRuntimeVersion;
			if (includeLocation && !(target.ManifestModule is global::System.Reflection.Emit.ModuleBuilder))
			{
				try
				{
					this.m_Packet.Location = target.CodeBase;
				}
				catch
				{
				}
			}
			global::System.Reflection.AssemblyName name = target.GetName();
			this.m_Packet.Name = name.Name;
			this.m_Packet.ProcessorArchitecture = name.ProcessorArchitecture;
			this.m_Packet.CultureName = name.CultureInfo.Name;
			this.m_Packet.Version = name.Version.ToString();
			try
			{
				foreach (global::System.Reflection.CustomAttributeData customAttributeData in global::System.Reflection.CustomAttributeData.GetCustomAttributes(target))
				{
					if (customAttributeData.Constructor.ReflectedType == typeof(global::System.Reflection.AssemblyFileVersionAttribute))
					{
						this.m_Packet.FileVersion = (customAttributeData.ConstructorArguments[0].Value as string);
						break;
					}
				}
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(this, exception);
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00035650 File Offset: 0x00033850
		internal SessionAssemblyInfo(global::Gibraltar.Monitor.Internal.AssemblyInfoPacket packet)
		{
			this.m_Packet = packet;
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x00035660 File Offset: 0x00033860
		public string Caption
		{
			get
			{
				return this.m_Packet.Name;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00035670 File Offset: 0x00033870
		public string Description
		{
			get
			{
				return this.m_Packet.FullName;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00035680 File Offset: 0x00033880
		public global::System.Guid Id
		{
			get
			{
				return this.m_Packet.ID;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00035690 File Offset: 0x00033890
		public string CultureName
		{
			get
			{
				return this.m_Packet.CultureName;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x000356A0 File Offset: 0x000338A0
		public string FullName
		{
			get
			{
				return this.m_Packet.FullName;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x000356B0 File Offset: 0x000338B0
		public string ImageRuntimeVersion
		{
			get
			{
				return this.m_Packet.ImageRuntimeVersion;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x000356C0 File Offset: 0x000338C0
		public string Location
		{
			get
			{
				return this.m_Packet.Location;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x000356D0 File Offset: 0x000338D0
		public string Name
		{
			get
			{
				return this.m_Packet.Name;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x000356E0 File Offset: 0x000338E0
		public global::System.Reflection.ProcessorArchitecture ProcessorArchitecture
		{
			get
			{
				return this.m_Packet.ProcessorArchitecture;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x000356F0 File Offset: 0x000338F0
		public bool GlobalAssemblyCache
		{
			get
			{
				return this.m_Packet.GlobalAssemblyCache;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x00035700 File Offset: 0x00033900
		public string Version
		{
			get
			{
				return this.m_Packet.Version;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x00035710 File Offset: 0x00033910
		public string FileVersion
		{
			get
			{
				return this.m_Packet.FileVersion;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x00035720 File Offset: 0x00033920
		public global::System.DateTimeOffset LoadedTimeStamp
		{
			get
			{
				return this.m_Packet.Timestamp;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x00035730 File Offset: 0x00033930
		internal global::Gibraltar.Monitor.Internal.AssemblyInfoPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00035738 File Offset: 0x00033938
		public int CompareTo(global::Gibraltar.Monitor.SessionAssemblyInfo other)
		{
			return this.Name.CompareTo(other.Name);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0003574C File Offset: 0x0003394C
		public bool Equals(global::Gibraltar.Monitor.SessionAssemblyInfo other)
		{
			return other != null && this.FullName == other.FullName;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00035768 File Offset: 0x00033968
		public override bool Equals(object obj)
		{
			global::Gibraltar.Monitor.SessionAssemblyInfo other = obj as global::Gibraltar.Monitor.SessionAssemblyInfo;
			return this.Equals(other);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00035788 File Offset: 0x00033988
		public override int GetHashCode()
		{
			return this.m_Packet.GetHashCode();
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00035798 File Offset: 0x00033998
		public static bool operator ==(global::Gibraltar.Monitor.SessionAssemblyInfo left, global::Gibraltar.Monitor.SessionAssemblyInfo right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000357AC File Offset: 0x000339AC
		public static bool operator !=(global::Gibraltar.Monitor.SessionAssemblyInfo left, global::Gibraltar.Monitor.SessionAssemblyInfo right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x000357C4 File Offset: 0x000339C4
		public static bool operator <(global::Gibraltar.Monitor.SessionAssemblyInfo left, global::Gibraltar.Monitor.SessionAssemblyInfo right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000357D0 File Offset: 0x000339D0
		public static bool operator >(global::Gibraltar.Monitor.SessionAssemblyInfo left, global::Gibraltar.Monitor.SessionAssemblyInfo right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x04000632 RID: 1586
		private readonly global::Gibraltar.Monitor.Internal.AssemblyInfoPacket m_Packet;
	}
}
