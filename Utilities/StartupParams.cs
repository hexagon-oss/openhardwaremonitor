using System;
using System.Collections.Generic;

namespace OpenHardwareMonitor.Utilities {
  public class StartupParams {
    private List<Types> Parameters;

    public StartupParams(string[] args) {
      Parameters = new List<Types>();

      for (int i = 0; i < args.Length; i++) {
        Types type;

        if (!args[i].StartsWith("--"))
          continue;

        if (Enum.TryParse(args[i].ToUpper().TrimStart('-'), out type)) {
          Parameters.Add(type);
        }
      }//for
    }

    public bool Contains(Types type) {
      return Parameters.Contains(type);
    }

    public enum Types {
      UNKNOWN,
      STARTMINIMIZED
    }
  }
}
