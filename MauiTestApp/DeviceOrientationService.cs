using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp
{
    public enum DeviceOrientation
    {
        Undefined,
        Landscape,
        Portrait
    }
    //platform specific code
    public partial class DeviceOrientationService
    {
        public partial DeviceOrientation GetOrientation();
    }
}
