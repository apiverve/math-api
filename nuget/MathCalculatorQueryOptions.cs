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
        /// Operation: add, subtract, multiply, divide, power, modulo, sqrt, abs, round, floor, ceil
        /// Example: add
        /// </summary>
        [JsonProperty("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// First number (or only number for single-param operations)
        /// Example: 10
        /// </summary>
        [JsonProperty("a")]
        public string A { get; set; }

        /// <summary>
        /// Second number (for two-param operations)
        /// Example: 5
        /// </summary>
        [JsonProperty("b")]
        public string B { get; set; }

        /// <summary>
        /// Mathematical expression to evaluate (alternative to operation mode)
        /// Example: (2 + 3) * 4
        /// </summary>
        [JsonProperty("expression")]
        public string Expression { get; set; }
    }
}
