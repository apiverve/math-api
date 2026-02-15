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
        /// First number (or only number for single-param operations like sqrt, abs)
        /// </summary>
        [JsonProperty("a")]
        public string A { get; set; }

        /// <summary>
        /// Second number (for two-param operations like add, subtract, multiply, divide)
        /// </summary>
        [JsonProperty("b")]
        public string B { get; set; }
    }
}
