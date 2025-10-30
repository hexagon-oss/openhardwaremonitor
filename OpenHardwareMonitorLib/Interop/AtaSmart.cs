// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) LibreHardwareMonitor and Contributors.
// All Rights Reserved.

using System.Runtime.InteropServices;
using Windows.Win32.Storage.IscsiDisc;

// ReSharper disable InconsistentNaming

namespace OpenHardwareMonitor.Interop;

public unsafe class AtaSmart
{
    internal const int IOCTL_BUFFER_SIZE = 4096;
    internal const int SCSI_IOCTL_SENSE_SIZE = 24;
    internal const int NVME_IOCTL_CMD_DW_SIZE = 16;
    internal const int NVME_IOCTL_COMPLETE_DW_SIZE = 4;
    internal const int NVME_IOCTL_VENDOR_SPECIFIC_DW_SIZE = 6;

    internal const int NVME_DATA_OUT = 1;
    internal const int NVME_DATA_IN = 2;

    internal const uint NVME_PASS_THROUGH_SRB_IO_CODE = 0xe0002000;

    internal const byte SMART_LBA_HI = 0xC2;
    internal const byte SMART_LBA_MID = 0x4F;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct SMART_ATTRIBUTE
    {
        internal byte Id;
        internal ushort Flags;
        internal byte CurrentValue;
        internal byte WorstValue;
        internal fixed byte RawValue[6];
        internal byte Reserved;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct SMART_THRESHOLD
    {
        public byte Id;
        public byte Threshold;
        public fixed byte Reserved[10];
    }
}
