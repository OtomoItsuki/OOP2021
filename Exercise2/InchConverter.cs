using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class InchConverter {
        private const double ratio = 0.0254;

        public static double ToMeter(int inch) {
            return inch * ratio;
        }

        internal static double FromMeter(int meter) {
            return meter / ratio;
        }
    }
}
