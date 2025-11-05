/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2012 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Text;

namespace OpenHardwareMonitor.Hardware
{

	public class SMBIOS
	{

		private readonly byte[] _raw;
		private readonly Structure[] _table;

		private readonly Version _version;
		private readonly BIOSInformation _biosInformation;
		private readonly SystemInformation _systemInformation;
		private readonly BaseBoardInformation _baseBoardInformation;
		private readonly ProcessorInformation _processorInformation;
		private readonly MemoryDevice[] _memoryDevices;

		private static string ReadSysFS(string path)
		{
			try
			{
				if (File.Exists(path))
				{
					using (StreamReader reader = new StreamReader(path))
						return reader.ReadLine();
				}
				else
				{
					return null;
				}
			}
			catch
			{
				return null;
			}
		}

		public SMBIOS()
		{
			if (OperatingSystem.IsUnix)
			{
				_raw = null;
				_table = null;

				string boardVendor = ReadSysFS("/sys/class/dmi/id/board_vendor");
				string boardName = ReadSysFS("/sys/class/dmi/id/board_name");
				string boardVersion = ReadSysFS("/sys/class/dmi/id/board_version");
				_baseBoardInformation = new BaseBoardInformation(
				  boardVendor, boardName, boardVersion, null);

				string systemVendor = ReadSysFS("/sys/class/dmi/id/sys_vendor");
				string productName = ReadSysFS("/sys/class/dmi/id/product_name");
				string productVersion = ReadSysFS("/sys/class/dmi/id/product_version");
				_systemInformation = new SystemInformation(systemVendor,
				  productName, productVersion, null, null);

				string biosVendor = ReadSysFS("/sys/class/dmi/id/bios_vendor");
				string biosVersion = ReadSysFS("/sys/class/dmi/id/bios_version");
				_biosInformation = new BIOSInformation(biosVendor, biosVersion);

				_memoryDevices = new MemoryDevice[0];
			}
			else
			{
				List<Structure> structureList = new List<Structure>();
				List<MemoryDevice> memoryDeviceList = new List<MemoryDevice>();

				_raw = null;
				byte majorVersion = 0;
				byte minorVersion = 0;
				try
				{
					ManagementObjectCollection collection;
					using (ManagementObjectSearcher searcher =
					  new ManagementObjectSearcher("root\\WMI",
						"SELECT * FROM MSSMBios_RawSMBiosTables"))
					{
						collection = searcher.Get();
					}

					foreach (ManagementObject mo in collection)
					{
						_raw = (byte[])mo["SMBiosData"];
						majorVersion = (byte)mo["SmbiosMajorVersion"];
						minorVersion = (byte)mo["SmbiosMinorVersion"];
						break;
					}
				}
				catch { }

				if (majorVersion > 0 || minorVersion > 0)
					_version = new Version(majorVersion, minorVersion);

				if (_raw != null && _raw.Length > 0)
				{
					int offset = 0;
					byte type = _raw[offset];
					while (offset + 4 < _raw.Length && type != 127)
					{

						type = _raw[offset];
						int length = _raw[offset + 1];
						ushort handle = (ushort)((_raw[offset + 2] << 8) | _raw[offset + 3]);

						if (offset + length > _raw.Length)
							break;
						byte[] data = new byte[length];
						Array.Copy(_raw, offset, data, 0, length);
						offset += length;

						List<string> stringsList = new List<string>();
						if (offset < _raw.Length && _raw[offset] == 0)
							offset++;

						while (offset < _raw.Length && _raw[offset] != 0)
						{
							StringBuilder sb = new StringBuilder();
							while (offset < _raw.Length && _raw[offset] != 0)
							{
								sb.Append((char)_raw[offset]); offset++;
							}
							offset++;
							stringsList.Add(sb.ToString());
						}
						offset++;
						switch (type)
						{
							case 0x00:
								this._biosInformation = new BIOSInformation(
								  type, handle, data, stringsList.ToArray());
								structureList.Add(this._biosInformation); break;
							case 0x01:
								this._systemInformation = new SystemInformation(
								  type, handle, data, stringsList.ToArray());
								structureList.Add(this._systemInformation); break;
							case 0x02:
								this._baseBoardInformation = new BaseBoardInformation(
								type, handle, data, stringsList.ToArray());
								structureList.Add(this._baseBoardInformation); break;
							case 0x04:
								this._processorInformation = new ProcessorInformation(
								type, handle, data, stringsList.ToArray());
								structureList.Add(this._processorInformation); break;
							case 0x11:
								MemoryDevice m = new MemoryDevice(type, handle, data, stringsList.ToArray());
								memoryDeviceList.Add(m);
								structureList.Add(m); break;
							default:
								structureList.Add(new Structure(
							  type, handle, data, stringsList.ToArray())); break;
						}
					}
				}

				_memoryDevices = memoryDeviceList.ToArray();
				_table = structureList.ToArray();
			}
		}

		public string GetReport()
		{
			StringBuilder r = new StringBuilder();

			if (_version != null)
			{
				r.Append("SMBIOS Version: "); r.AppendLine(_version.ToString(2));
				r.AppendLine();
			}

			if (BIOS != null)
			{
				r.Append("BIOS Vendor: "); r.AppendLine(BIOS.Vendor);
				r.Append("BIOS Version: "); r.AppendLine(BIOS.Version);
				r.AppendLine();
			}

			if (System != null)
			{
				r.Append("System Manufacturer: ");
				r.AppendLine(System.ManufacturerName);
				r.Append("System Name: ");
				r.AppendLine(System.ProductName);
				r.Append("System Version: ");
				r.AppendLine(System.Version);
				r.AppendLine();
			}

			if (Board != null)
			{
				r.Append("Mainboard Manufacturer: ");
				r.AppendLine(Board.ManufacturerName);
				r.Append("Mainboard Name: ");
				r.AppendLine(Board.ProductName);
				r.Append("Mainboard Version: ");
				r.AppendLine(Board.Version);
				r.AppendLine();
			}

			if (Processor != null)
			{
				r.Append("Processor Manufacturer: ");
				r.AppendLine(Processor.ManufacturerName);
				r.Append("Processor Version: ");
				r.AppendLine(Processor.Version);
				r.Append("Processor Core Count: ");
				r.AppendLine(Processor.CoreCount.ToString());
				r.Append("Processor Core Enabled: ");
				r.AppendLine(Processor.CoreEnabled.ToString());
				r.Append("Processor Thread Count: ");
				r.AppendLine(Processor.ThreadCount.ToString());
				r.Append("Processor External Clock: ");
				r.Append(Processor.ExternalClock);
				r.AppendLine(" Mhz");
				r.AppendLine();
			}

			for (int i = 0; i < MemoryDevices.Length; i++)
			{
				r.Append("Memory Device [" + i + "] Manufacturer: ");
				r.AppendLine(MemoryDevices[i].ManufacturerName);
				r.Append("Memory Device [" + i + "] Part Number: ");
				r.AppendLine(MemoryDevices[i].PartNumber);
				r.Append("Memory Device [" + i + "] Device Locator: ");
				r.AppendLine(MemoryDevices[i].DeviceLocator);
				r.Append("Memory Device [" + i + "] Bank Locator: ");
				r.AppendLine(MemoryDevices[i].BankLocator);
				r.AppendLine($"Memory Device [{i}] Speed: {MemoryDevices[i].Speed} MHz");
                r.AppendLine($"Memory Device [{i}] Configured Speed: {MemoryDevices[i].ConfiguredSpeed} MHz");
                r.AppendLine($"Memory Device [{i}] Configured Voltage: {MemoryDevices[i].ConfiguredVoltage} mV");
                r.AppendLine($"Memory Device [{i}] Size: {MemoryDevices[i].Size} MB");
				r.AppendLine();
			}

			if (_raw != null)
			{
				string base64 = Convert.ToBase64String(_raw);
				r.AppendLine("SMBIOS Table");
				r.AppendLine();

				for (int i = 0; i < Math.Ceiling(base64.Length / 64.0); i++)
				{
					r.Append(" ");
					for (int j = 0; j < 0x40; j++)
					{
						int index = (i << 6) | j;
						if (index < base64.Length)
						{
							r.Append(base64[index]);
						}
					}
					r.AppendLine();
				}
				r.AppendLine();
			}

			return r.ToString();
		}

		public BIOSInformation BIOS
		{
			get { return _biosInformation; }
		}

		public SystemInformation System
		{
			get { return _systemInformation; }
		}

		public BaseBoardInformation Board
		{
			get { return _baseBoardInformation; }
		}


		public ProcessorInformation Processor
		{
			get { return _processorInformation; }
		}

		public MemoryDevice[] MemoryDevices
		{
			get { return _memoryDevices; }
		}

		public class Structure
		{
			private readonly byte type;
			private readonly ushort handle;

			private readonly byte[] _data;
			private readonly string[] strings;

			protected int GetByte(int offset)
			{
				if (offset < _data.Length && offset >= 0)
					return _data[offset];
				else
					return 0;
			}

			protected int GetWord(int offset)
			{
				if (offset + 1 < _data.Length && offset >= 0)
					return (_data[offset + 1] << 8) | _data[offset];
				else
					return 0;
			}

            /// <summary>
            /// Gets the dword.
            /// </summary>
            /// <param name="offset">The offset.</param>
            /// <returns><see cref="ushort" />.</returns>
            protected uint GetDword(int offset)
            {
                if (offset + 3 < _data.Length && offset >= 0)
                {
                    return BitConverter.ToUInt32(_data, offset);
                }

                return 0;
            }

			protected string GetString(int offset)
			{
				if (offset < _data.Length && _data[offset] > 0 &&
				 _data[offset] <= strings.Length)
					return strings[_data[offset] - 1];
				else
					return "";
			}

			public Structure(byte type, ushort handle, byte[] data, string[] strings)
			{
				this.type = type;
				this.handle = handle;
				this._data = data;
				this.strings = strings;
			}

			public byte Type { get { return type; } }

			public ushort Handle { get { return handle; } }
		}

		public class BIOSInformation : Structure
		{

			private readonly string vendor;
			private readonly string version;

			public BIOSInformation(string vendor, string version)
			  : base(0x00, 0, null, null)
			{
				this.vendor = vendor;
				this.version = version;
			}

			public BIOSInformation(byte type, ushort handle, byte[] data,
			  string[] strings)
			  : base(type, handle, data, strings)
			{
				this.vendor = GetString(0x04);
				this.version = GetString(0x05);
			}

			public string Vendor { get { return vendor; } }

			public string Version { get { return version; } }
		}

		public class SystemInformation : Structure
		{

			private readonly string manufacturerName;
			private readonly string productName;
			private readonly string version;
			private readonly string serialNumber;
			private readonly string family;

			public SystemInformation(string manufacturerName, string productName,
			  string version, string serialNumber, string family)
			  : base(0x01, 0, null, null)
			{
				this.manufacturerName = manufacturerName;
				this.productName = productName;
				this.version = version;
				this.serialNumber = serialNumber;
				this.family = family;
			}

			public SystemInformation(byte type, ushort handle, byte[] data,
			  string[] strings)
			  : base(type, handle, data, strings)
			{
				this.manufacturerName = GetString(0x04);
				this.productName = GetString(0x05);
				this.version = GetString(0x06);
				this.serialNumber = GetString(0x07);
				this.family = GetString(0x1A);
			}

			public string ManufacturerName { get { return manufacturerName; } }

			public string ProductName { get { return productName; } }

			public string Version { get { return version; } }

			public string SerialNumber { get { return serialNumber; } }

			public string Family { get { return family; } }

		}

		public class BaseBoardInformation : Structure
		{

			private readonly string manufacturerName;
			private readonly string productName;
			private readonly string version;
			private readonly string serialNumber;

			public BaseBoardInformation(string manufacturerName, string productName,
			  string version, string serialNumber)
			  : base(0x02, 0, null, null)
			{
				this.manufacturerName = manufacturerName;
				this.productName = productName;
				this.version = version;
				this.serialNumber = serialNumber;
			}

			public BaseBoardInformation(byte type, ushort handle, byte[] data,
			  string[] strings)
			  : base(type, handle, data, strings)
			{

				this.manufacturerName = GetString(0x04).Trim();
				this.productName = GetString(0x05).Trim();
				this.version = GetString(0x06).Trim();
				this.serialNumber = GetString(0x07).Trim();
			}

			public string ManufacturerName { get { return manufacturerName; } }

			public string ProductName { get { return productName; } }

			public string Version { get { return version; } }

			public string SerialNumber { get { return serialNumber; } }

		}

		public class ProcessorInformation : Structure
		{

			public ProcessorInformation(byte type, ushort handle, byte[] data,
			  string[] strings)
			  : base(type, handle, data, strings)
			{
				this.ManufacturerName = GetString(0x07).Trim();
				this.Version = GetString(0x10).Trim();
				this.CoreCount = GetByte(0x23);
				this.CoreEnabled = GetByte(0x24);
				this.ThreadCount = GetByte(0x25);
				this.ExternalClock = GetWord(0x12);
			}

			public string ManufacturerName { get; private set; }

			public string Version { get; private set; }

			public int CoreCount { get; private set; }

			public int CoreEnabled { get; private set; }

			public int ThreadCount { get; private set; }

			public int ExternalClock { get; private set; }
		}

		public class MemoryDevice : Structure
		{

			private readonly string _deviceLocator;
			private readonly string _bankLocator;
			private readonly string _manufacturerName;
			private readonly string _serialNumber;
			private readonly string _partNumber;
			private readonly int _speed;

			public MemoryDevice(byte type, ushort handle, byte[] data,
			  string[] strings)
			  : base(type, handle, data, strings)
			{
				this._deviceLocator = GetString(0x10).Trim();
				this._bankLocator = GetString(0x11).Trim();
				this._manufacturerName = GetString(0x17).Trim();
				this._serialNumber = GetString(0x18).Trim();
				this._partNumber = GetString(0x1A).Trim();
				this._speed = GetWord(0x15);
                ConfiguredSpeed = GetWord(0x20);
                ConfiguredVoltage = GetWord(0x26);
                Size = GetWord(0x0C);
                if (Size == 0x7FFF)
                {
                    Size = GetDword(0x1C);
                }
            }

            public int ConfiguredSpeed
            {
                get;
            }

            public int ConfiguredVoltage
            {
                get;
            }

            public long Size
            {
                get;
            }

            public string DeviceLocator { get { return _deviceLocator; } }

			public string BankLocator { get { return _bankLocator; } }

			public string ManufacturerName { get { return _manufacturerName; } }

			public string SerialNumber { get { return _serialNumber; } }

			public string PartNumber { get { return _partNumber; } }

			public int Speed { get { return _speed; } }

		}
	}
}
