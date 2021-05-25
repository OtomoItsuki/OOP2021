﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public class FeetConverter {
        public FeetConverter() {
        }

        //メートルからフィートを求める
        public double fromMeter(double meter) {
            return meter / 0.3048;
        }
        //フィートからメートルを求める
        public double toMeter(double feet) {
            return feet * 0.3048;
        }
    }
}
