using System;
using System.Collections.Generic;
using System.Text;

namespace MarkdownDocs
{
    /// <summary>
    /// A transportation device
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// The amount of fuel remaining
        /// </summary>
        public int FuelLevel { get; private set; }

        /// <summary>
        /// Fill 'er up
        /// </summary>
        /// <param name="octaneLevel">The minimum octance level of the fuel</param>
        /// <param name="amount">Amount og gasoline to add in gallons</param>
        public virtual void AddGasoline(OctaneRating octaneLevel, int amount)
        {

        }
    }
}
