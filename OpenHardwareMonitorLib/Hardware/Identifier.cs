/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2010 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenHardwareMonitor.Hardware {
  public class Identifier : IComparable<Identifier> {
    private readonly string identifier;

     private const char Separator = '/';

    private string FilterIdentifier(string identifier)
    {
        return Regex.Replace(identifier, @"\/|\\| |'|:|;|\*|<|>||", ""); 
    }

    public Identifier(params string[] identifiers) {

      StringBuilder s = new StringBuilder();
      for (int i = 0; i < identifiers.Length; i++) {
        s.Append(Separator);
        s.Append(FilterIdentifier(identifiers[i]));
      }
      this.identifier = s.ToString();
    }

    public Identifier(Identifier identifier, params string[] extensions) 
    {
      StringBuilder s = new StringBuilder();
      s.Append(identifier.ToString());
      for (int i = 0; i < extensions.Length; i++) {
        s.Append(Separator);
        s.Append(FilterIdentifier(extensions[i]));
      }
      this.identifier = s.ToString();
    }

    public override string ToString() {
      return identifier;
    }

    public override bool Equals(Object obj) {
      if (obj == null)
        return false;

      Identifier id = obj as Identifier;
      if (id == null)
        return false;

      return (identifier == id.identifier);
    }

    public override int GetHashCode() {
      return identifier.GetHashCode();
    }

    public int CompareTo(Identifier other) {
      if (other == null)
        return 1;
      else 
        return string.Compare(this.identifier, other.identifier, 
          StringComparison.Ordinal);
    }

    public static bool operator ==(Identifier id1, Identifier id2) {
      if (id1.Equals(null))
        return id2.Equals(null);
      else
        return id1.Equals(id2);
    }

    public static bool operator !=(Identifier id1, Identifier id2) {
      return !(id1 == id2);
    }

    public static bool operator <(Identifier id1, Identifier id2) {
      if (id1 == null)
        return id2 != null;
      else 
        return (id1.CompareTo(id2) < 0);
    }

    public static bool operator >(Identifier id1, Identifier id2) {
      if (id1 == null)
        return false;
      else 
        return (id1.CompareTo(id2) > 0);
    }  
  }
}
