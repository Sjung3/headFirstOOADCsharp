using GameDesigner;
using System;

namespace SimpleTester
{
    public class UnitTester
    {
        public void TestType(Unit unit, String type, String expectedOutputType)
        {
            Console.WriteLine("\nTesting setting/getting the property type.");
            unit.Type = type;

            string outputType = unit.Type;

            if (expectedOutputType.Equals(outputType))
                Console.WriteLine("Test passed");
            else
                Console.WriteLine("Test failed: " + outputType + " didn't match " + expectedOutputType);
        }

        public void TestUnitSpecificProperty(Unit unit, String propertyName,
            Object inputValue, Object expectedOutputValue)
        {
            Console.WriteLine("\nTesting setting/getting a unit-specific property");
            unit.SetProperty(propertyName, inputValue);

            Object outputValue = unit.GetProperty(propertyName);

            if (expectedOutputValue.Equals(outputValue))
                Console.WriteLine("Test passed");
            else
                Console.WriteLine("Test failed: " + outputValue + " didn't match " + expectedOutputValue);
        }

        public void TestChangeProperty(Unit unit, String propertyName,
            Object inputValue, Object expectedOutputValue)
        {
            Console.WriteLine("\nTesting changing an existing property's value");
            unit.SetProperty(propertyName, inputValue);

            Object outputValue = unit.GetProperty(propertyName);

            if (expectedOutputValue.Equals(outputValue))
                Console.WriteLine("Test passed");
            else
                Console.WriteLine("Test failed: " + outputValue + " didn't match " + expectedOutputValue);
        }

        public void TestNonExistentProperty(Unit unit, String propertyName)
        {
            Console.WriteLine("\nTesting getting a non-existent property's value");
            Object outputValue;
            try
            {
                outputValue = unit.GetProperty(propertyName);
            }
            catch (SystemException e)
            {
                Console.WriteLine("Test passed");
                return;
            }
            Console.WriteLine("Test failed with value of " + outputValue);
        }

        public static void Main(string[] args)
        {
            UnitTester tester = new UnitTester();
            Unit unit = new Unit(1000);

            tester.TestType(unit, "infantry", "infantry");
            tester.TestUnitSpecificProperty(unit, "hitPoints", new String('a', 'b'), new String('a', 'b'));
            tester.TestChangeProperty(unit, "hitPoints", new String('c', 'd'), new String('c', 'd'));
            tester.TestNonExistentProperty(unit, "strength");
        }
    }
}