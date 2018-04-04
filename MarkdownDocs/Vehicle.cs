using System;
using System.Collections.Generic;
using System.Text;

namespace MarkdownDocs
{
    public abstract class Vehicle
    {
        public int FuelLevel { get; private set; }

        /// <summary>
        /// Fill 'er up
        /// </summary>
        /// <param name="octaneLevel">The minimum octance level of the fuel</param>
        /// <param name="amount">Amount og gasoline to add in gallons</param>
        public virtual void AddGasoline(OctaneLevel octaneLevel, int amount)
        {

        }
    }
}
