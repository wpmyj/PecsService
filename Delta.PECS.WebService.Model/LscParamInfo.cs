﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delta.PECS.WebService.Model {
    /// <summary>
    /// Lsc Param Information Class
    /// </summary>
    [Serializable]
    public class LscParamInfo {
        /// <summary>
        /// LscID
        /// </summary>
        public int LscID { get; set; }

        /// <summary>
        /// StaTNumber
        /// </summary>
        public int StaTNumber { get; set; }

        /// <summary>
        /// ElecDevTNumber
        /// </summary>
        public int ElecDevTNumber { get; set; }
    }
}
