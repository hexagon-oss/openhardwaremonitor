/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2011 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

using System;
using Microsoft.Extensions.Logging;
using OpenHardwareMonitor.Collections;
using OpenHardwareMonitorLib;

namespace OpenHardwareMonitor.Hardware;

public abstract class Hardware : IHardware, IDisposable
{
    private readonly Identifier _identifier;
    protected readonly string _name;
    private string _customName;
    protected readonly ISettings _settings;
    protected readonly ListSet<ISensor> _active = new ListSet<ISensor>();

    public Hardware(string name, Identifier identifier, ISettings settings)
    {
        _settings = settings;
        _identifier = identifier;
        _name = name;
        Logger = this.GetCurrentClassLogger();
        _customName = settings.GetValue(
            new Identifier(Identifier, "name").ToString(), name);
    }

    public IHardware[] SubHardware
    {
        get { return new IHardware[0]; }
    }

    public virtual IHardware Parent
    {
        get { return null; }
    }

    public virtual ISensor[] Sensors
    {
        get { return _active.ToArray(); }
    }

    protected ILogger Logger
    {
        get;
    }

    protected virtual void ActivateSensor(ISensor sensor)
    {
        if (_active.Add(sensor))
            if (SensorAdded != null)
                SensorAdded(sensor);
    }

    protected virtual void DeactivateSensor(ISensor sensor)
    {
        if (_active.Remove(sensor))
            if (SensorRemoved != null)
                SensorRemoved(sensor);
    }

    public string Name
    {
        get
        {
            return _customName;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _customName = value;
            else
                _customName = _name;
            _settings.SetValue(new Identifier(Identifier, "name").ToString(),
                _customName);
        }
    }

    public Identifier Identifier
    {
        get
        {
            return _identifier;
        }
    }

    public event SensorEventHandler SensorAdded;
    public event SensorEventHandler SensorRemoved;

    public abstract HardwareType HardwareType { get; }

    public virtual string GetReport()
    {
        return null;
    }

    public abstract void Update();

    public event HardwareEventHandler Closing;

    public void Accept(IVisitor visitor)
    {
        if (visitor == null)
            throw new ArgumentNullException("visitor");
        visitor.VisitHardware(this);
    }

    public virtual void Traverse(IVisitor visitor)
    {
        foreach (ISensor sensor in _active)
            sensor.Accept(visitor);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (Closing != null)
                Closing(this);
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
