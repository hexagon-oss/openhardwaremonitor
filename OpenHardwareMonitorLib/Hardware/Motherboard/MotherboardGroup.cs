// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) LibreHardwareMonitor and Contributors.
// Partial Copyright (C) Michael Möller <mmoeller@openhardwaremonitor.org> and Contributors.
// All Rights Reserved.

using System.Collections.Generic;

namespace OpenHardwareMonitor.Hardware.Motherboard;

internal class MotherboardGroup : IGroup
{
    private readonly Motherboard[] _motherboards;

    public MotherboardGroup(SMBIOS smbios, ISettings settings)
    {
        _motherboards = new Motherboard[1];
        _motherboards[0] = new Motherboard(smbios, settings);
    }

    public IReadOnlyList<IHardware> Hardware => _motherboards;

    public void Close()
    {
        foreach (Motherboard mainboard in _motherboards)
        {
            mainboard.Dispose();
        }
    }

    public string GetReport()
    {
        return null;
    }
}
