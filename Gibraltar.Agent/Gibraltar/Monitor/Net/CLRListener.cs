using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Loupe.Extensibility.Data;
using Microsoft.Win32;

namespace Gibraltar.Monitor.Net
{
	// Token: 0x020001D4 RID: 468
	internal class CLRListener : global::System.IDisposable
	{
		// Token: 0x06001636 RID: 5686 RVA: 0x000432B4 File Offset: 0x000414B4
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x000432C4 File Offset: 0x000414C4
		public void Initialize(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (!this.m_MasterEventsEnabled)
				{
					this.RegisterMasterEvents();
				}
				if (configuration.EnableAssemblyEvents)
				{
					if (!this.m_AssemblyEventsEnabled)
					{
						this.RegisterAssemblyEvents();
					}
				}
				else if (this.m_AssemblyEventsEnabled)
				{
					this.UnregisterAssemblyEvents();
				}
				if (configuration.EnableAssemblyLoadFailureEvents)
				{
					if (!this.m_AssemblyLoadFailureEventsEnabled)
					{
						this.RegisterAssemblyLoadFailureEvents();
					}
				}
				else if (this.m_AssemblyLoadFailureEventsEnabled)
				{
					this.UnregisterAssemblyLoadFailureEvents();
				}
				if (configuration.EnableNetworkEvents)
				{
					if (!this.m_NetworkEventsEnabled)
					{
						this.RegisterNetworkEvents();
					}
				}
				else if (this.m_NetworkEventsEnabled)
				{
					this.UnregisterNetworkEvents();
				}
				if (configuration.EnablePowerEvents)
				{
					if (!this.m_PowerEventsEnabled)
					{
						this.RegisterPowerEvents();
					}
				}
				else if (this.m_PowerEventsEnabled)
				{
					this.UnregisterPowerEvents();
				}
				if (configuration.EnableUserEvents)
				{
					if (!this.m_UserEventsEnabled)
					{
						this.RegisterUserEvents();
					}
				}
				else if (this.m_UserEventsEnabled)
				{
					this.UnregisterUserEvents();
				}
			}
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00043414 File Offset: 0x00041614
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_Disposed)
			{
				if (this.m_MasterEventsEnabled)
				{
					this.UnregisterMasterEvents();
				}
				if (this.m_AssemblyEventsEnabled)
				{
					this.UnregisterAssemblyEvents();
				}
				if (this.m_NetworkEventsEnabled)
				{
					this.UnregisterNetworkEvents();
				}
				if (this.m_PowerEventsEnabled)
				{
					this.UnregisterPowerEvents();
				}
				if (this.m_UserEventsEnabled)
				{
					this.UnregisterUserEvents();
				}
				this.m_Disposed = true;
			}
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00043490 File Offset: 0x00041690
		private void RegisterAssemblyEvents()
		{
			try
			{
				this.m_AssemblyEventsEnabled = true;
				global::System.AppDomain.CurrentDomain.AssemblyLoad += this.AppDomain_AssemblyLoad;
			}
			catch
			{
			}
			try
			{
				this.EnsureAssembliesRecorded();
			}
			catch
			{
			}
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x000434F4 File Offset: 0x000416F4
		private void UnregisterAssemblyEvents()
		{
			try
			{
				global::System.AppDomain.CurrentDomain.AssemblyLoad -= this.AppDomain_AssemblyLoad;
			}
			catch
			{
			}
			finally
			{
				this.m_AssemblyEventsEnabled = false;
			}
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00043548 File Offset: 0x00041748
		private void RegisterAssemblyLoadFailureEvents()
		{
			try
			{
				this.m_AssemblyLoadFailureEventsEnabled = true;
				global::System.AppDomain.CurrentDomain.AssemblyResolve += this.AppDomain_AssemblyResolve;
			}
			catch
			{
			}
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00043590 File Offset: 0x00041790
		private void UnregisterAssemblyLoadFailureEvents()
		{
			try
			{
				global::System.AppDomain.CurrentDomain.AssemblyResolve -= this.AppDomain_AssemblyResolve;
			}
			catch
			{
			}
			finally
			{
				this.m_AssemblyLoadFailureEventsEnabled = false;
			}
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x000435E4 File Offset: 0x000417E4
		private void RegisterMasterEvents()
		{
			try
			{
				this.m_MasterEventsEnabled = true;
				global::System.AppDomain currentDomain = global::System.AppDomain.CurrentDomain;
				currentDomain.DomainUnload += global::Gibraltar.Monitor.Net.CLRListener.AppDomain_DomainUnload;
				currentDomain.ProcessExit += global::Gibraltar.Monitor.Net.CLRListener.AppDomain_ProcessExit;
				global::Microsoft.Win32.SystemEvents.EventsThreadShutdown += this.SystemEvents_EventsThreadShutdown;
				global::System.Windows.Forms.Application.ApplicationExit += global::Gibraltar.Monitor.Net.CLRListener.Application_ApplicationExit;
				global::Microsoft.Win32.SystemEvents.TimeChanged += this.SystemEvents_TimeChanged;
				global::Microsoft.Win32.SystemEvents.SessionEnding += this.SystemEvents_SessionEnding;
			}
			catch
			{
			}
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00043680 File Offset: 0x00041880
		private void UnregisterMasterEvents()
		{
			try
			{
				global::System.AppDomain currentDomain = global::System.AppDomain.CurrentDomain;
				currentDomain.DomainUnload -= global::Gibraltar.Monitor.Net.CLRListener.AppDomain_DomainUnload;
				currentDomain.ProcessExit -= global::Gibraltar.Monitor.Net.CLRListener.AppDomain_ProcessExit;
				global::Microsoft.Win32.SystemEvents.EventsThreadShutdown -= this.SystemEvents_EventsThreadShutdown;
				global::System.Windows.Forms.Application.ApplicationExit -= global::Gibraltar.Monitor.Net.CLRListener.Application_ApplicationExit;
				global::Microsoft.Win32.SystemEvents.SessionEnding -= this.SystemEvents_SessionEnding;
				global::Microsoft.Win32.SystemEvents.TimeChanged -= this.SystemEvents_TimeChanged;
			}
			catch
			{
			}
			finally
			{
				this.m_MasterEventsEnabled = false;
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00043728 File Offset: 0x00041928
		private void RegisterNetworkEvents()
		{
			try
			{
				this.m_NetworkEventsEnabled = true;
				global::System.Net.NetworkInformation.NetworkChange.NetworkAddressChanged += this.NetworkChange_NetworkAddressChanged;
				global::System.Net.NetworkInformation.NetworkChange.NetworkAvailabilityChanged += this.NetworkChange_NetworkAvailabilityChanged;
			}
			catch
			{
			}
			try
			{
				this.EnsureNetworkInterfacesRecorded();
			}
			catch
			{
			}
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00043798 File Offset: 0x00041998
		private void UnregisterNetworkEvents()
		{
			try
			{
				global::System.Net.NetworkInformation.NetworkChange.NetworkAddressChanged -= this.NetworkChange_NetworkAddressChanged;
				global::System.Net.NetworkInformation.NetworkChange.NetworkAvailabilityChanged -= this.NetworkChange_NetworkAvailabilityChanged;
			}
			catch
			{
			}
			finally
			{
				this.m_NetworkEventsEnabled = false;
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x000437F8 File Offset: 0x000419F8
		private void RegisterPowerEvents()
		{
			if (global::Gibraltar.Monitor.Log.SessionSummary.AgentAppType != global::Loupe.Extensibility.Data.ApplicationType.AspNet)
			{
				try
				{
					this.m_PowerEventsEnabled = true;
					global::Microsoft.Win32.SystemEvents.PowerModeChanged += this.SystemEvents_PowerModeChanged;
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
				}
			}
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0004384C File Offset: 0x00041A4C
		private void UnregisterPowerEvents()
		{
			try
			{
				global::Microsoft.Win32.SystemEvents.PowerModeChanged -= this.SystemEvents_PowerModeChanged;
			}
			catch
			{
			}
			finally
			{
				this.m_PowerEventsEnabled = false;
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0004389C File Offset: 0x00041A9C
		private void RegisterUserEvents()
		{
			try
			{
				this.m_UserEventsEnabled = true;
				if (global::Gibraltar.Monitor.Log.SessionSummary.AgentAppType == global::Loupe.Extensibility.Data.ApplicationType.Console || global::Gibraltar.Monitor.Log.SessionSummary.AgentAppType == global::Loupe.Extensibility.Data.ApplicationType.Windows)
				{
					global::Microsoft.Win32.SystemEvents.DisplaySettingsChanged += this.SystemEvents_DisplaySettingsChanged;
					global::Microsoft.Win32.SystemEvents.SessionSwitch += this.SystemEvents_SessionSwitch;
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00043914 File Offset: 0x00041B14
		private void UnregisterUserEvents()
		{
			try
			{
				global::Microsoft.Win32.SystemEvents.DisplaySettingsChanged -= this.SystemEvents_DisplaySettingsChanged;
				global::Microsoft.Win32.SystemEvents.SessionSwitch -= this.SystemEvents_SessionSwitch;
			}
			catch
			{
			}
			finally
			{
				this.m_UserEventsEnabled = false;
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00043974 File Offset: 0x00041B74
		private void EnsureAssembliesRecorded()
		{
			foreach (global::System.Reflection.Assembly newAssembly in global::System.AppDomain.CurrentDomain.GetAssemblies())
			{
				this.RecordAssembly(newAssembly);
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x000439B4 File Offset: 0x00041BB4
		private void EnsureNetworkInterfacesRecorded()
		{
			this.RecordNetworkState(false);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x000439C0 File Offset: 0x00041BC0
		private global::Gibraltar.Monitor.SessionAssemblyInfo RecordAssembly(global::System.Reflection.Assembly newAssembly)
		{
			global::Gibraltar.Monitor.SessionAssemblyInfo sessionAssemblyInfo = null;
			object assemblyLock = this.m_AssemblyLock;
			lock (assemblyLock)
			{
				string fullName = newAssembly.FullName;
				if (!string.IsNullOrEmpty(fullName) && !this.m_Assemblies.ContainsKey(fullName))
				{
					sessionAssemblyInfo = new global::Gibraltar.Monitor.SessionAssemblyInfo(newAssembly, !global::Gibraltar.Monitor.Log.SessionSummary.PrivacyEnabled);
					this.m_Assemblies.Add(fullName, sessionAssemblyInfo);
					global::Gibraltar.Monitor.Log.Write(sessionAssemblyInfo.Packet);
				}
				global::System.Threading.Monitor.PulseAll(this.m_AssemblyLock);
			}
			return sessionAssemblyInfo;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00043A54 File Offset: 0x00041C54
		internal static string FormatDataRate(long bpsRate)
		{
			long num = bpsRate % 1000L;
			long num2 = bpsRate / 1000L;
			string text = "Kbps";
			if (num2 >= 10000L || (num2 >= 1000L && num == 0L))
			{
				num = num2 % 1000L;
				num2 /= 1000L;
				if (num2 >= 10000L || (num2 >= 1000L && num == 0L))
				{
					num = num2 % 1000L;
					num2 /= 1000L;
					text = "Gbps";
				}
				else
				{
					text = "Mbps";
				}
			}
			string result;
			if (num == 0L)
			{
				result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0} {1}", new object[]
				{
					num2,
					text
				});
			}
			else
			{
				string text2 = string.Empty;
				while (num > 0L)
				{
					text2 += num / 100L;
					num = num * 10L % 1000L;
				}
				result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1} {2}", new object[]
				{
					num2,
					text2,
					text
				});
			}
			return result;
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00043B78 File Offset: 0x00041D78
		private void RecordNetworkState(bool logChanges)
		{
			global::System.Net.NetworkInformation.NetworkInterface[] allNetworkInterfaces;
			try
			{
				allNetworkInterfaces = global::System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
			}
			catch
			{
				this.UnregisterNetworkEvents();
				return;
			}
			object networkStatesLock = this.m_NetworkStatesLock;
			lock (networkStatesLock)
			{
				foreach (global::System.Net.NetworkInformation.NetworkInterface networkInterface in allNetworkInterfaces)
				{
					if (networkInterface.NetworkInterfaceType != global::System.Net.NetworkInformation.NetworkInterfaceType.Loopback && networkInterface.NetworkInterfaceType != global::System.Net.NetworkInformation.NetworkInterfaceType.Tunnel)
					{
						global::Gibraltar.Monitor.Net.CLRListener.NetworkState networkState;
						if (!this.m_NetworkStates.TryGetValue(networkInterface.Id, out networkState))
						{
							networkState = new global::Gibraltar.Monitor.Net.CLRListener.NetworkState(networkInterface);
							this.m_NetworkStates.Add(networkState.Id, networkState);
							if (logChanges)
							{
								string description = global::Gibraltar.Monitor.Net.CLRListener.FormatNetworkAdapterState(networkState);
								global::Gibraltar.Monitor.Net.CLRListener.LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "System.Events.Network", "Network Interface Detected", description, new object[0]);
							}
						}
						else
						{
							bool flag = false;
							string text = string.Empty;
							global::Gibraltar.Monitor.Net.CLRListener.NetworkState networkState2 = new global::Gibraltar.Monitor.Net.CLRListener.NetworkState(networkInterface);
							if (networkState2.OperationalStatus != networkState.OperationalStatus)
							{
								flag = true;
								text += string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Operational Status Changed from {0} to {1}\r\n", new object[]
								{
									networkState.OperationalStatus,
									networkState2.OperationalStatus
								});
							}
							if (networkState2.Speed != networkState.Speed)
							{
								flag = true;
								text += string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Speed Changed from {0} to {1}\r\n", new object[]
								{
									global::Gibraltar.Monitor.Net.CLRListener.FormatDataRate(networkState.Speed),
									global::Gibraltar.Monitor.Net.CLRListener.FormatDataRate(networkState2.Speed)
								});
							}
							if (global::Gibraltar.Monitor.Net.CLRListener.IPConfigurationChanged(networkState, networkState2))
							{
								flag = true;
								text += "TCP/IP Configuration Changed.\r\n";
							}
							if (flag)
							{
								this.m_NetworkStates.Remove(networkState.Id);
								this.m_NetworkStates.Add(networkState2.Id, networkState2);
								if (logChanges)
								{
									string text2 = global::Gibraltar.Monitor.Net.CLRListener.FormatNetworkAdapterState(networkState2);
									global::Gibraltar.Monitor.Net.CLRListener.LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "System.Events.Network", "Network Interface Changes Detected", "\r\n{0}\r\nNew State:\r\n{1}", new object[]
									{
										text,
										text2
									});
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00043DC4 File Offset: 0x00041FC4
		private static bool IPConfigurationChanged(global::Gibraltar.Monitor.Net.CLRListener.NetworkState previousState, global::Gibraltar.Monitor.Net.CLRListener.NetworkState newState)
		{
			if (previousState.GatewayAddresses != null && newState.GatewayAddresses == null)
			{
				return true;
			}
			if (previousState.GatewayAddresses == null && newState.GatewayAddresses != null)
			{
				return true;
			}
			if (previousState.GatewayAddresses != null && newState.GatewayAddresses != null)
			{
				if (previousState.GatewayAddresses.Count != newState.GatewayAddresses.Count)
				{
					return true;
				}
				foreach (global::System.Net.NetworkInformation.GatewayIPAddressInformation gatewayIPAddressInformation in newState.GatewayAddresses)
				{
					bool flag = false;
					foreach (global::System.Net.NetworkInformation.GatewayIPAddressInformation gatewayIPAddressInformation2 in newState.GatewayAddresses)
					{
						if (gatewayIPAddressInformation.Address.Equals(gatewayIPAddressInformation2.Address))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						return true;
					}
				}
			}
			if (previousState.UnicastIPAddresses != null && newState.UnicastIPAddresses == null)
			{
				return true;
			}
			if (previousState.UnicastIPAddresses == null && newState.UnicastIPAddresses != null)
			{
				return true;
			}
			if (previousState.UnicastIPAddresses != null && newState.UnicastIPAddresses != null)
			{
				if (previousState.UnicastIPAddresses.Count != newState.UnicastIPAddresses.Count)
				{
					return true;
				}
				foreach (global::System.Net.NetworkInformation.UnicastIPAddressInformation unicastIPAddressInformation in newState.UnicastIPAddresses)
				{
					bool flag2 = false;
					foreach (global::System.Net.NetworkInformation.UnicastIPAddressInformation unicastIPAddressInformation2 in newState.UnicastIPAddresses)
					{
						if (unicastIPAddressInformation.Address.Equals(unicastIPAddressInformation2.Address))
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						return true;
					}
				}
			}
			if (previousState.DnsAddresses != null && newState.DnsAddresses == null)
			{
				return true;
			}
			if (previousState.DnsAddresses == null && newState.DnsAddresses != null)
			{
				return true;
			}
			if (previousState.DnsAddresses != null && newState.DnsAddresses != null)
			{
				if (previousState.DnsAddresses.Count != newState.DnsAddresses.Count)
				{
					return true;
				}
				foreach (global::System.Net.IPAddress ipaddress in newState.DnsAddresses)
				{
					bool flag3 = false;
					foreach (global::System.Net.IPAddress obj in newState.DnsAddresses)
					{
						if (ipaddress.Equals(obj))
						{
							flag3 = true;
							break;
						}
					}
					if (!flag3)
					{
						return true;
					}
				}
			}
			if (previousState.WinsServersAddresses != null && newState.WinsServersAddresses == null)
			{
				return true;
			}
			if (previousState.WinsServersAddresses == null && newState.WinsServersAddresses != null)
			{
				return true;
			}
			if (previousState.WinsServersAddresses != null && newState.WinsServersAddresses != null)
			{
				if (previousState.WinsServersAddresses.Count != newState.WinsServersAddresses.Count)
				{
					return true;
				}
				foreach (global::System.Net.IPAddress ipaddress2 in newState.WinsServersAddresses)
				{
					bool flag4 = false;
					foreach (global::System.Net.IPAddress obj2 in newState.WinsServersAddresses)
					{
						if (ipaddress2.Equals(obj2))
						{
							flag4 = true;
							break;
						}
					}
					if (!flag4)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0004422C File Offset: 0x0004242C
		private static string FormatNetworkAdapterState(global::Gibraltar.Monitor.Net.CLRListener.NetworkState adapterState)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1024);
			stringBuilder.AppendFormat("Name: {0}\r\n", adapterState.Name);
			stringBuilder.AppendFormat("Interface Type: {0}\r\n", adapterState.NetworkInterfaceType);
			stringBuilder.AppendFormat("Description: {0}\r\n", adapterState.Description);
			string arg;
			switch (adapterState.OperationalStatus)
			{
			case global::System.Net.NetworkInformation.OperationalStatus.Up:
				arg = "UP: The network interface is up; it can transmit data packets.";
				break;
			case global::System.Net.NetworkInformation.OperationalStatus.Down:
				arg = "DOWN: The network interface is unable to transmit data packets.";
				break;
			case global::System.Net.NetworkInformation.OperationalStatus.Testing:
				arg = "TESTING: The network interface is running tests.";
				break;
			case global::System.Net.NetworkInformation.OperationalStatus.Unknown:
				arg = "UNKNOWN: The network interface status is not known.";
				break;
			case global::System.Net.NetworkInformation.OperationalStatus.Dormant:
				arg = "DORMANT: The network interface is not in a condition to transmit data packets; it is waiting for an external event.";
				break;
			case global::System.Net.NetworkInformation.OperationalStatus.NotPresent:
				arg = "NOT PRESENT: The network interface is unable to transmit data packets because of a missing component, typically a hardware component.";
				break;
			case global::System.Net.NetworkInformation.OperationalStatus.LowerLayerDown:
				arg = "LOWER LAYER DOWN: The network interface is unable to transmit data packets because it runs on top of one or more other interfaces, and at least one of these 'lower layer' interfaces is down.";
				break;
			default:
				arg = adapterState.OperationalStatus.ToString();
				break;
			}
			stringBuilder.AppendFormat("Status: {0}\r\n", arg);
			if (adapterState.OperationalStatus == global::System.Net.NetworkInformation.OperationalStatus.Up)
			{
				stringBuilder.AppendFormat("Maximum Speed: {0}\r\n", global::Gibraltar.Monitor.Net.CLRListener.FormatDataRate(adapterState.Speed));
				stringBuilder.AppendFormat("DNS Servers: {0}\r\n", global::Gibraltar.Monitor.Net.CLRListener.FormatIPAddressList(adapterState.DnsAddresses));
				stringBuilder.AppendFormat("WINS Servers: {0}\r\n", global::Gibraltar.Monitor.Net.CLRListener.FormatIPAddressList(adapterState.WinsServersAddresses));
				stringBuilder.AppendFormat("Gateways: {0}\r\n", global::Gibraltar.Monitor.Net.CLRListener.FormatGatewayIPAddressList(adapterState.GatewayAddresses));
				stringBuilder.AppendFormat("IPv4 Addresses: {0}\r\n", global::Gibraltar.Monitor.Net.CLRListener.FormatUnicastAddressList(adapterState.UnicastIPAddresses, global::System.Net.Sockets.AddressFamily.InterNetwork));
				stringBuilder.AppendFormat("IPV6 Addresses: {0}\r\n", global::Gibraltar.Monitor.Net.CLRListener.FormatUnicastAddressList(adapterState.UnicastIPAddresses, global::System.Net.Sockets.AddressFamily.InterNetworkV6));
				if (adapterState.UnicastIPAddresses != null)
				{
					foreach (global::System.Net.NetworkInformation.UnicastIPAddressInformation unicastIPAddressInformation in adapterState.UnicastIPAddresses)
					{
						if (unicastIPAddressInformation.DuplicateAddressDetectionState != global::System.Net.NetworkInformation.DuplicateAddressDetectionState.Preferred && unicastIPAddressInformation.DuplicateAddressDetectionState != global::System.Net.NetworkInformation.DuplicateAddressDetectionState.Deprecated)
						{
							string arg2;
							switch (unicastIPAddressInformation.DuplicateAddressDetectionState)
							{
							case global::System.Net.NetworkInformation.DuplicateAddressDetectionState.Invalid:
								arg2 = "the address is not valid. A nonvalid address is expired and no longer assigned to an interface; applications should not send data packets to it.";
								break;
							case global::System.Net.NetworkInformation.DuplicateAddressDetectionState.Tentative:
								arg2 = "the duplicate address detection procedure's evaluation of the address has not completed successfully. Applications should not use the address because it is not yet valid and packets sent to it are discarded.";
								break;
							case global::System.Net.NetworkInformation.DuplicateAddressDetectionState.Duplicate:
								arg2 = "the address is not unique. This address should not be assigned to the network interface.";
								break;
							default:
								arg2 = unicastIPAddressInformation.DuplicateAddressDetectionState.ToString();
								break;
							}
							stringBuilder.AppendFormat("\r\nThe IP address {0} is not currently usable because {1}\r\n", unicastIPAddressInformation.Address, arg2);
						}
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0004449C File Offset: 0x0004269C
		private static string FormatUnicastAddressList(global::System.Net.NetworkInformation.UnicastIPAddressInformationCollection addressCollection, global::System.Net.Sockets.AddressFamily family)
		{
			string text;
			if (addressCollection == null)
			{
				text = "NONE";
			}
			else if (addressCollection.Count == 0)
			{
				text = "NONE";
			}
			else
			{
				text = string.Empty;
				foreach (global::System.Net.NetworkInformation.UnicastIPAddressInformation unicastIPAddressInformation in addressCollection)
				{
					if (unicastIPAddressInformation.Address.AddressFamily == family)
					{
						if (string.IsNullOrEmpty(text))
						{
							text = unicastIPAddressInformation.Address.ToString();
						}
						else
						{
							text = text + ", " + unicastIPAddressInformation.Address;
						}
					}
				}
			}
			return text;
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00044554 File Offset: 0x00042754
		private static string FormatIPAddressList(global::System.Net.NetworkInformation.IPAddressCollection addressCollection)
		{
			if (addressCollection == null)
			{
				return "NONE";
			}
			if (addressCollection.Count == 0)
			{
				return "NONE";
			}
			string text = string.Empty;
			foreach (global::System.Net.IPAddress ipaddress in addressCollection)
			{
				if (string.IsNullOrEmpty(text))
				{
					text = ipaddress.ToString();
				}
				else
				{
					text = text + ", " + ipaddress;
				}
			}
			return text;
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000445E8 File Offset: 0x000427E8
		private static string FormatGatewayIPAddressList(global::System.Net.NetworkInformation.GatewayIPAddressInformationCollection addressCollection)
		{
			if (addressCollection == null)
			{
				return "NONE";
			}
			if (addressCollection.Count == 0)
			{
				return "NONE";
			}
			string text = "";
			foreach (global::System.Net.NetworkInformation.GatewayIPAddressInformation gatewayIPAddressInformation in addressCollection)
			{
				if (string.IsNullOrEmpty(text))
				{
					text += gatewayIPAddressInformation.Address.ToString();
				}
				else
				{
					text = text + ", " + gatewayIPAddressInformation.Address;
				}
			}
			return text;
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0004468C File Offset: 0x0004288C
		private static string FormatBatteryChargeDescription(global::System.Windows.Forms.PowerStatus powerStatus)
		{
			global::System.TimeSpan timeSpan = new global::System.TimeSpan(0, 0, powerStatus.BatteryLifeRemaining);
			return string.Format("Battery Charge Capacity: {0}%\r\nEstimated Runtime Remaining: {1}\r\nBattery Status: {2}\r\n", powerStatus.BatteryLifePercent, timeSpan, powerStatus.BatteryChargeStatus);
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x000446D4 File Offset: 0x000428D4
		private static void LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode mode, string category, string caption, string description, params object[] args)
		{
			global::Gibraltar.Monitor.Net.CLRListener.MessageSource sourceProvider = new global::Gibraltar.Monitor.Net.CLRListener.MessageSource("Gibraltar.Agent.Net.CLRListener", "LogEvent");
			global::Gibraltar.Monitor.Log.WriteMessage(severity, mode, "Gibraltar", category, sourceProvider, null, null, null, caption, description, args);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0004470C File Offset: 0x0004290C
		private static void LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity severity, string category, string caption, string description, params object[] args)
		{
			global::Gibraltar.Monitor.Net.CLRListener.MessageSource sourceProvider = new global::Gibraltar.Monitor.Net.CLRListener.MessageSource("Gibraltar.Agent.Net.CLRListener", "LogEvent");
			global::Gibraltar.Monitor.Log.WriteMessage(severity, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, sourceProvider, null, null, null, caption, description, args);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00044744 File Offset: 0x00042944
		private void SystemEvents_EventsThreadShutdown(object sender, global::System.EventArgs e)
		{
			try
			{
				this.UnregisterUserEvents();
				this.UnregisterPowerEvents();
				if (!global::Gibraltar.Monitor.Log.IsSessionEnding)
				{
					global::Gibraltar.Monitor.Net.CLRListener.LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "System.Events", "System Event Recording Stopping", "The events thread is shutting down, no more system events will be recorded.", new object[0]);
				}
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(null, exception);
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000447A8 File Offset: 0x000429A8
		private void SystemEvents_DisplaySettingsChanged(object sender, global::System.EventArgs e)
		{
			if (this.m_SuppressEvents)
			{
				return;
			}
			try
			{
				global::Gibraltar.Monitor.Net.CLRListener.LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "System.Events.Display", "Display Settings Changed", "The active display settings have been changed.", new object[0]);
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(null, exception);
			}
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00044800 File Offset: 0x00042A00
		private void SystemEvents_TimeChanged(object sender, global::System.EventArgs e)
		{
			if (this.m_SuppressEvents)
			{
				return;
			}
			try
			{
				global::Gibraltar.Monitor.Net.CLRListener.LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "System.Events.Time", "System Time Changed", "The new time is {0} in time zone {1}", new object[]
				{
					global::System.DateTimeOffset.Now,
					global::System.TimeZone.CurrentTimeZone.StandardName
				});
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(null, exception);
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00044874 File Offset: 0x00042A74
		private void SystemEvents_SessionEnding(object sender, global::Microsoft.Win32.SessionEndingEventArgs e)
		{
			if (this.m_SuppressEvents)
			{
				return;
			}
			try
			{
				string text = "(Unknown)";
				global::Microsoft.Win32.SessionEndReasons reason = e.Reason;
				if (reason != global::Microsoft.Win32.SessionEndReasons.Logoff)
				{
					if (reason == global::Microsoft.Win32.SessionEndReasons.SystemShutdown)
					{
						text = "system shutdown";
					}
				}
				else
				{
					text = "user logoff";
				}
				global::Gibraltar.Monitor.Net.CLRListener.LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "System.Events.Session", "Current Logon Session Ending", "The current logon session is ending due to {0}.", new object[]
				{
					text
				});
				global::Gibraltar.Monitor.Net.CLRListener.MessageSource sourceProvider = new global::Gibraltar.Monitor.Net.CLRListener.MessageSource("Gibraltar.Agent.Net.CLRListener", "ExitEvent");
				global::Gibraltar.Monitor.Log.EndSession(global::Loupe.Extensibility.Data.SessionStatus.Normal, sourceProvider, text);
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(null, exception);
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00044918 File Offset: 0x00042B18
		private void SystemEvents_SessionSwitch(object sender, global::Microsoft.Win32.SessionSwitchEventArgs e)
		{
			if (this.m_SuppressEvents)
			{
				return;
			}
			try
			{
				string text;
				switch (e.Reason)
				{
				case global::Microsoft.Win32.SessionSwitchReason.ConsoleConnect:
					text = "a session has been connected from the console.";
					break;
				case global::Microsoft.Win32.SessionSwitchReason.ConsoleDisconnect:
					text = "a session has been disconnected from the console.";
					break;
				case global::Microsoft.Win32.SessionSwitchReason.RemoteConnect:
					text = "a session has been connected from a remote connection.";
					break;
				case global::Microsoft.Win32.SessionSwitchReason.RemoteDisconnect:
					text = "a session has been disconnected from a remote connection.";
					break;
				case global::Microsoft.Win32.SessionSwitchReason.SessionLogon:
					text = "a user has logged on to a session.";
					break;
				case global::Microsoft.Win32.SessionSwitchReason.SessionLogoff:
					text = "a user has logged off from a session.";
					break;
				case global::Microsoft.Win32.SessionSwitchReason.SessionLock:
					text = "a session has been locked.";
					break;
				case global::Microsoft.Win32.SessionSwitchReason.SessionUnlock:
					text = "a session has been unlocked.";
					break;
				case global::Microsoft.Win32.SessionSwitchReason.SessionRemoteControl:
					text = "a session has changed its status to or from remote controlled mode.";
					break;
				default:
					text = e.Reason.ToString();
					break;
				}
				global::Gibraltar.Monitor.Net.CLRListener.LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "System.Events.Session", "Current Logon Session Switching", "The current logon session is switching because {0}", new object[]
				{
					text
				});
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(null, exception);
			}
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00044A24 File Offset: 0x00042C24
		private void SystemEvents_PowerModeChanged(object sender, global::Microsoft.Win32.PowerModeChangedEventArgs e)
		{
			try
			{
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Information;
				string text = null;
				string description = null;
				global::Gibraltar.Monitor.LogWriteMode mode = global::Gibraltar.Monitor.LogWriteMode.Queued;
				switch (e.Mode)
				{
				case global::Microsoft.Win32.PowerModes.Resume:
					text = "System Resuming from Sleep";
					description = "The operating system is about to resume from a suspended state.";
					this.m_SuppressEvents = false;
					break;
				case global::Microsoft.Win32.PowerModes.StatusChange:
				{
					global::System.Windows.Forms.PowerStatus powerStatus = global::System.Windows.Forms.SystemInformation.PowerStatus;
					if (this.m_CurrentChargeStatus != powerStatus.BatteryChargeStatus || this.m_CurrentPowerLineStatus != powerStatus.PowerLineStatus)
					{
						if (this.m_CurrentPowerLineStatus == global::System.Windows.Forms.PowerLineStatus.Online && powerStatus.PowerLineStatus != global::System.Windows.Forms.PowerLineStatus.Online)
						{
							text = "Switching to Battery Power";
							description = global::Gibraltar.Monitor.Net.CLRListener.FormatBatteryChargeDescription(powerStatus);
						}
						else if (powerStatus.PowerLineStatus == global::System.Windows.Forms.PowerLineStatus.Online && this.m_CurrentPowerLineStatus != global::System.Windows.Forms.PowerLineStatus.Online)
						{
							text = "Switching to Line Power";
							description = "The system is transitioning from battery or other backup power to normal line power.";
						}
						else if ((this.m_CurrentPowerLineStatus != global::System.Windows.Forms.PowerLineStatus.Online || powerStatus.PowerLineStatus != global::System.Windows.Forms.PowerLineStatus.Online) && this.m_CurrentChargeStatus != powerStatus.BatteryChargeStatus)
						{
							global::System.Windows.Forms.BatteryChargeStatus batteryChargeStatus = powerStatus.BatteryChargeStatus;
							switch (batteryChargeStatus)
							{
							case global::System.Windows.Forms.BatteryChargeStatus.High:
								text = "Battery fully charged";
								description = global::Gibraltar.Monitor.Net.CLRListener.FormatBatteryChargeDescription(powerStatus);
								break;
							case global::System.Windows.Forms.BatteryChargeStatus.Low:
								text = "Battery is Low";
								description = global::Gibraltar.Monitor.Net.CLRListener.FormatBatteryChargeDescription(powerStatus);
								break;
							case global::System.Windows.Forms.BatteryChargeStatus.High | global::System.Windows.Forms.BatteryChargeStatus.Low:
								break;
							case global::System.Windows.Forms.BatteryChargeStatus.Critical:
								severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Warning;
								text = "Battery is Critically Low";
								description = global::Gibraltar.Monitor.Net.CLRListener.FormatBatteryChargeDescription(powerStatus);
								break;
							default:
								if (batteryChargeStatus != global::System.Windows.Forms.BatteryChargeStatus.Charging)
								{
									if (batteryChargeStatus == global::System.Windows.Forms.BatteryChargeStatus.NoSystemBattery)
									{
										text = "No System Battery";
										description = "The battery has been removed / no battery detected.";
									}
								}
								else
								{
									text = "Battery is Charging";
									description = global::Gibraltar.Monitor.Net.CLRListener.FormatBatteryChargeDescription(powerStatus);
								}
								break;
							}
						}
						this.m_CurrentPowerLineStatus = powerStatus.PowerLineStatus;
						this.m_CurrentChargeStatus = powerStatus.BatteryChargeStatus;
					}
					break;
				}
				case global::Microsoft.Win32.PowerModes.Suspend:
					text = "System Going to Sleep";
					description = "The operating system is about to be suspended.";
					mode = global::Gibraltar.Monitor.LogWriteMode.WaitForCommit;
					this.m_SuppressEvents = true;
					break;
				}
				if (!string.IsNullOrEmpty(text))
				{
					global::Gibraltar.Monitor.Net.CLRListener.LogEvent(severity, mode, "System.Events.Power", text, description, new object[0]);
				}
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(null, exception);
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00044C38 File Offset: 0x00042E38
		private void NetworkChange_NetworkAvailabilityChanged(object sender, global::System.Net.NetworkInformation.NetworkAvailabilityEventArgs e)
		{
			if (this.m_SuppressEvents)
			{
				return;
			}
			try
			{
				string caption;
				string description;
				if (e.IsAvailable)
				{
					caption = "Network is Now Available";
					description = "One or more network interfaces are now connected to a network.";
				}
				else
				{
					caption = "Network Not Available";
					description = "No network interfaces are connected to a network.";
				}
				global::Gibraltar.Monitor.Net.CLRListener.LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "System.Events.Network", caption, description, new object[0]);
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(null, exception);
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00044CB0 File Offset: 0x00042EB0
		private void NetworkChange_NetworkAddressChanged(object sender, global::System.EventArgs e)
		{
			if (this.m_SuppressEvents)
			{
				return;
			}
			try
			{
				this.RecordNetworkState(true);
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(null, exception);
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00044CF4 File Offset: 0x00042EF4
		private static void Application_ApplicationExit(object sender, global::System.EventArgs e)
		{
			if (!global::Gibraltar.Monitor.Log.ExplicitStartSessionCalled)
			{
				global::System.Windows.Forms.Application.ApplicationExit -= global::Gibraltar.Monitor.Net.CLRListener.Application_ApplicationExit;
				global::Gibraltar.Monitor.Log.EndSession(global::Loupe.Extensibility.Data.SessionStatus.Normal, new global::Gibraltar.Monitor.MessageSourceProvider("Gibraltar.Monitor.Net.CLRListener", "ExitEvent"), "ApplicationExit event received.");
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00044D2C File Offset: 0x00042F2C
		private static void AppDomain_DomainUnload(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Forms.Application.ApplicationExit -= global::Gibraltar.Monitor.Net.CLRListener.Application_ApplicationExit;
			global::Gibraltar.Monitor.Log.EndSession(global::Loupe.Extensibility.Data.SessionStatus.Normal, new global::Gibraltar.Monitor.MessageSourceProvider("Gibraltar.Monitor.Net.CLRListener", "ExitEvent"), "DomainUnload event received.");
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00044D5C File Offset: 0x00042F5C
		private static void AppDomain_ProcessExit(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Forms.Application.ApplicationExit -= global::Gibraltar.Monitor.Net.CLRListener.Application_ApplicationExit;
			global::Gibraltar.Monitor.Log.EndSession(global::Loupe.Extensibility.Data.SessionStatus.Normal, new global::Gibraltar.Monitor.MessageSourceProvider("Gibraltar.Monitor.Net.CLRListener", "ExitEvent"), "ProcessExit event received.");
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00044D8C File Offset: 0x00042F8C
		private void AppDomain_AssemblyLoad(object sender, global::System.AssemblyLoadEventArgs args)
		{
			try
			{
				global::Gibraltar.Monitor.SessionAssemblyInfo sessionAssemblyInfo = this.RecordAssembly(args.LoadedAssembly);
				if (sessionAssemblyInfo != null)
				{
					string text = sessionAssemblyInfo.Location;
					if (string.IsNullOrEmpty(text))
					{
						if (global::Gibraltar.Monitor.Log.SessionSummary.PrivacyEnabled)
						{
							text = "(suppressed for privacy)";
						}
						else
						{
							text = "(unknown)";
						}
					}
					global::Gibraltar.Monitor.Net.CLRListener.LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "System.Events.Assembly", string.IsNullOrEmpty(sessionAssemblyInfo.Name) ? "New Assembly Loaded" : ("New Assembly Loaded - " + sessionAssemblyInfo.Name), "Name: {0}\r\nFull name: {1}\r\nLocation: {2}\r\n", new object[]
					{
						sessionAssemblyInfo.Name,
						sessionAssemblyInfo.FullName,
						text
					});
				}
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(null, exception);
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00044E60 File Offset: 0x00043060
		private global::System.Reflection.Assembly AppDomain_AssemblyResolve(object sender, global::System.ResolveEventArgs args)
		{
			try
			{
				bool flag = false;
				if (args.Name.Contains(".XmlSerializers"))
				{
					flag = true;
				}
				if (!flag)
				{
					global::Gibraltar.Monitor.Net.CLRListener.LogEvent(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "System.Events.Assembly", string.Format("Assembly '{0}' Not Found", args.Name), "The .NET runtime is attempting to load a referenced assembly and couldn't find it using normal resolution methods.\r\nIf the application supports dynamic assembly registration through the AssemblyResolve event it may still be located, in which case a log message indicating it was loaded will be recorded after this message.", new object[0]);
				}
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(null, exception);
			}
			return null;
		}

		// Token: 0x0400072A RID: 1834
		private const string ThisLogSystem = "Gibraltar";

		// Token: 0x0400072B RID: 1835
		private bool m_Disposed;

		// Token: 0x0400072C RID: 1836
		private bool m_MasterEventsEnabled;

		// Token: 0x0400072D RID: 1837
		private bool m_AssemblyEventsEnabled;

		// Token: 0x0400072E RID: 1838
		private bool m_AssemblyLoadFailureEventsEnabled;

		// Token: 0x0400072F RID: 1839
		private bool m_NetworkEventsEnabled;

		// Token: 0x04000730 RID: 1840
		private bool m_PowerEventsEnabled;

		// Token: 0x04000731 RID: 1841
		private bool m_UserEventsEnabled;

		// Token: 0x04000732 RID: 1842
		private bool m_SuppressEvents;

		// Token: 0x04000733 RID: 1843
		private global::System.Windows.Forms.PowerLineStatus m_CurrentPowerLineStatus;

		// Token: 0x04000734 RID: 1844
		private global::System.Windows.Forms.BatteryChargeStatus m_CurrentChargeStatus;

		// Token: 0x04000735 RID: 1845
		private readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.SessionAssemblyInfo> m_Assemblies = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.SessionAssemblyInfo>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000736 RID: 1846
		private readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.Net.CLRListener.NetworkState> m_NetworkStates = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.Net.CLRListener.NetworkState>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000737 RID: 1847
		private readonly object m_Lock = new object();

		// Token: 0x04000738 RID: 1848
		private readonly object m_AssemblyLock = new object();

		// Token: 0x04000739 RID: 1849
		private readonly object m_NetworkStatesLock = new object();

		// Token: 0x020004A9 RID: 1193
		private class MessageSource : global::Gibraltar.Monitor.IMessageSourceProvider
		{
			// Token: 0x06003378 RID: 13176 RVA: 0x000BA858 File Offset: 0x000B8A58
			public MessageSource(string className, string methodName)
			{
				this.MethodName = methodName;
				this.ClassName = className;
				this.FileName = null;
				this.LineNumber = 0;
			}

			// Token: 0x17000EC4 RID: 3780
			// (get) Token: 0x06003379 RID: 13177 RVA: 0x000BA88C File Offset: 0x000B8A8C
			// (set) Token: 0x0600337A RID: 13178 RVA: 0x000BA894 File Offset: 0x000B8A94
			public string MethodName { get; private set; }

			// Token: 0x17000EC5 RID: 3781
			// (get) Token: 0x0600337B RID: 13179 RVA: 0x000BA8A0 File Offset: 0x000B8AA0
			// (set) Token: 0x0600337C RID: 13180 RVA: 0x000BA8A8 File Offset: 0x000B8AA8
			public string ClassName { get; private set; }

			// Token: 0x17000EC6 RID: 3782
			// (get) Token: 0x0600337D RID: 13181 RVA: 0x000BA8B4 File Offset: 0x000B8AB4
			// (set) Token: 0x0600337E RID: 13182 RVA: 0x000BA8BC File Offset: 0x000B8ABC
			public string FileName { get; private set; }

			// Token: 0x17000EC7 RID: 3783
			// (get) Token: 0x0600337F RID: 13183 RVA: 0x000BA8C8 File Offset: 0x000B8AC8
			// (set) Token: 0x06003380 RID: 13184 RVA: 0x000BA8D0 File Offset: 0x000B8AD0
			public int LineNumber { get; private set; }
		}

		// Token: 0x020004AA RID: 1194
		private class NetworkState
		{
			// Token: 0x06003381 RID: 13185 RVA: 0x000BA8DC File Offset: 0x000B8ADC
			public NetworkState(global::System.Net.NetworkInformation.NetworkInterface nic)
			{
				this.Id = nic.Id;
				this.Name = nic.Name;
				this.NetworkInterfaceType = nic.NetworkInterfaceType;
				this.Description = nic.Description;
				this.Speed = nic.Speed;
				this.OperationalStatus = nic.OperationalStatus;
				try
				{
					global::System.Net.NetworkInformation.IPInterfaceProperties ipproperties = nic.GetIPProperties();
					this.DnsAddresses = ipproperties.DnsAddresses;
					this.WinsServersAddresses = ipproperties.WinsServersAddresses;
					this.GatewayAddresses = ipproperties.GatewayAddresses;
					this.UnicastIPAddresses = ipproperties.UnicastAddresses;
				}
				catch
				{
				}
			}

			// Token: 0x17000EC8 RID: 3784
			// (get) Token: 0x06003382 RID: 13186 RVA: 0x000BA98C File Offset: 0x000B8B8C
			// (set) Token: 0x06003383 RID: 13187 RVA: 0x000BA994 File Offset: 0x000B8B94
			public string Id { get; private set; }

			// Token: 0x17000EC9 RID: 3785
			// (get) Token: 0x06003384 RID: 13188 RVA: 0x000BA9A0 File Offset: 0x000B8BA0
			// (set) Token: 0x06003385 RID: 13189 RVA: 0x000BA9A8 File Offset: 0x000B8BA8
			public string Name { get; private set; }

			// Token: 0x17000ECA RID: 3786
			// (get) Token: 0x06003386 RID: 13190 RVA: 0x000BA9B4 File Offset: 0x000B8BB4
			// (set) Token: 0x06003387 RID: 13191 RVA: 0x000BA9BC File Offset: 0x000B8BBC
			public global::System.Net.NetworkInformation.NetworkInterfaceType NetworkInterfaceType { get; private set; }

			// Token: 0x17000ECB RID: 3787
			// (get) Token: 0x06003388 RID: 13192 RVA: 0x000BA9C8 File Offset: 0x000B8BC8
			// (set) Token: 0x06003389 RID: 13193 RVA: 0x000BA9D0 File Offset: 0x000B8BD0
			public string Description { get; private set; }

			// Token: 0x17000ECC RID: 3788
			// (get) Token: 0x0600338A RID: 13194 RVA: 0x000BA9DC File Offset: 0x000B8BDC
			// (set) Token: 0x0600338B RID: 13195 RVA: 0x000BA9E4 File Offset: 0x000B8BE4
			public long Speed { get; private set; }

			// Token: 0x17000ECD RID: 3789
			// (get) Token: 0x0600338C RID: 13196 RVA: 0x000BA9F0 File Offset: 0x000B8BF0
			// (set) Token: 0x0600338D RID: 13197 RVA: 0x000BA9F8 File Offset: 0x000B8BF8
			public global::System.Net.NetworkInformation.OperationalStatus OperationalStatus { get; private set; }

			// Token: 0x17000ECE RID: 3790
			// (get) Token: 0x0600338E RID: 13198 RVA: 0x000BAA04 File Offset: 0x000B8C04
			// (set) Token: 0x0600338F RID: 13199 RVA: 0x000BAA0C File Offset: 0x000B8C0C
			public global::System.Net.NetworkInformation.IPAddressCollection DnsAddresses { get; private set; }

			// Token: 0x17000ECF RID: 3791
			// (get) Token: 0x06003390 RID: 13200 RVA: 0x000BAA18 File Offset: 0x000B8C18
			// (set) Token: 0x06003391 RID: 13201 RVA: 0x000BAA20 File Offset: 0x000B8C20
			public global::System.Net.NetworkInformation.GatewayIPAddressInformationCollection GatewayAddresses { get; private set; }

			// Token: 0x17000ED0 RID: 3792
			// (get) Token: 0x06003392 RID: 13202 RVA: 0x000BAA2C File Offset: 0x000B8C2C
			// (set) Token: 0x06003393 RID: 13203 RVA: 0x000BAA34 File Offset: 0x000B8C34
			public global::System.Net.NetworkInformation.IPAddressCollection WinsServersAddresses { get; private set; }

			// Token: 0x17000ED1 RID: 3793
			// (get) Token: 0x06003394 RID: 13204 RVA: 0x000BAA40 File Offset: 0x000B8C40
			// (set) Token: 0x06003395 RID: 13205 RVA: 0x000BAA48 File Offset: 0x000B8C48
			public global::System.Net.NetworkInformation.UnicastIPAddressInformationCollection UnicastIPAddresses { get; private set; }
		}
	}
}
