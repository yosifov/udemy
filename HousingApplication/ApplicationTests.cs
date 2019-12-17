namespace HousingApplication
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [Category("Housing Application")]
    public class ApplicationTests
    {
        [Test]
        public void SingleFamilyTest()
        {
            List<SingleFamily> singleFamilies = new List<SingleFamily>()
            {
                new SingleFamily("Address 1", "Type of const 1", 2005, 250M, 85.4, 1, 1, false, true),
                new SingleFamily("Address 2", "Type of const 2", 2007, 350M, 95.7, 2, 1, true, true),
                new SingleFamily("Address 3", "Type of const 3", 2009, 450M, 105.8, 2, 1, true, true),
                new SingleFamily("Address 4", "Type of const 4", 2011, 550M, 115.9, 2, 2, true, true),
                new SingleFamily("Address 5", "Type of const 5", 2013, 650M, 125.0, 3, 2, true, true)
            };

            foreach (var singleFamily in singleFamilies)
            {
                Console.WriteLine(singleFamily);
            }
        }

        [Test]
        public void MultiUnitsTest()
        {
            List<MultiUnit> multiUnits = new List<MultiUnit>()
            {
                new MultiUnit("Address 6", "Type of const 6", 2014, "Complex 1", 1, 1100),
                new MultiUnit("Address 7", "Type of const 7", 2015, "Complex 2", 2, 1200),
                new MultiUnit("Address 8", "Type of const 8", 2016, "Complex 3", 3, 1300),
                new MultiUnit("Address 9", "Type of const 9", 2017, "Complex 4", 4, 1400),
                new MultiUnit("Address 10", "Type of const 10", 2018, "Complex 5", 5, 1500)
            };

            foreach (var multiUnit in multiUnits)
            {
                Console.WriteLine(multiUnit);
            }
        }

        [Test]
        public void HousingTests()
        {
            List<Housing> housings = new List<Housing>()
            {
                new SingleFamily("Address 1", "Type of const 1", 2005, 250M, 85.4, 1, 1, false, true),
                new SingleFamily("Address 2", "Type of const 2", 2007, 350M, 95.7, 2, 1, true, true),
                new SingleFamily("Address 3", "Type of const 3", 2009, 450M, 105.8, 2, 1, true, true),
                new SingleFamily("Address 4", "Type of const 4", 2011, 550M, 115.9, 2, 2, true, true),
                new SingleFamily("Address 5", "Type of const 5", 2013, 650M, 125.0, 3, 2, true, true),
                new MultiUnit("Address 6", "Type of const 6", 2014, "Complex 1", 1, 1100),
                new MultiUnit("Address 7", "Type of const 7", 2015, "Complex 2", 2, 1200),
                new MultiUnit("Address 8", "Type of const 8", 2016, "Complex 3", 3, 1300),
                new MultiUnit("Address 9", "Type of const 9", 2017, "Complex 4", 4, 1400),
                new MultiUnit("Address 10", "Type of const 10", 2018, "Complex 5", 5, 1500)
            };

            foreach (var housing in housings)
            {
                Console.WriteLine($"Address: {housing.Address}");
                Console.WriteLine($"Projected rental amount: {housing.ProjectedRentalAmt():C}");
            }
        }
    }
}