using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.MathCalculator
{
    /// <summary>
    /// Query options for the Math Calculator API
    /// </summary>
    public class MathCalculatorQueryOptions
    {
        /// <summary>
        /// Operation to perform
        /// </summary>
        [JsonProperty("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// First number
        /// </summary>
        [JsonProperty("a")]
        public double A { get; set; }

        /// <summary>
        /// Second number
        /// </summary>
        [JsonProperty("b")]
        public double B { get; set; }
    }
}
