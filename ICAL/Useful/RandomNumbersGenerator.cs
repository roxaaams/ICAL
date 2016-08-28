/* Copyright 2015-2016 Roxana Teodora Mafteiu-Scai, Diana Fabiola Popa
#
# This file is part of ICAL - Intelligent Computer Assisted Learning.
#
# ICAL - Intelligent Computer Assisted Learning is free software: you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation, either version 3 of the License, or
# (at your option) any later version.
#
# ICAL - Intelligent Computer Assisted Learning is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with ICAL - Intelligent Computer Assisted Learning.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;

namespace ICAL_Final.Useful
{
    public class RandomNumbersGenerator
    {
        private bool hasSeed;
        private int seed;

        /// <summary>
        /// Initializes a new instance of the class 
        /// </summary>
        /// <param name="seed"> The seed </param>
        public RandomNumbersGenerator(int seed)
        {
            this.seed = seed;
            hasSeed = true;
        }

        /// <summary>
        ///  Generates a list of random integers
        /// </summary>
        /// <param name="smallest"> Used for the inferior limit </param>
        /// <param name="highest">  Used for the superior limit </param>
        /// <param name="count"> Represents the number of random integers </param>
        /// <returns> The list of random integers </returns>
        public List<int> Generate(int smallest, int highest, int count)
        {
            var randomNumbers = new List<int>(count);
            var random = hasSeed ? new Random(seed) : new Random();

            highest = highest - smallest + 1;

            while (count-- > 0)
            {
                var randomNumber = smallest + random.Next(highest);

                randomNumbers.Add(randomNumber);
            }

            return randomNumbers;
        }

    }
}
