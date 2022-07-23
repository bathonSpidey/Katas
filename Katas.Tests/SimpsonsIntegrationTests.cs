using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace Katas.Tests
{
		public class SimpsonsIntegrationTests
		{
			[Test]
			public void SimpleCase()
			{
				var result = SimpsonsIntegration.Simpson(40);
				Assert.That(result,Is.EqualTo(1.999619632400204d) );

			}
		}

		public class SimpsonsIntegration
		{
			public static double Simpson(int number)
			{
				var h  = Math.PI / number;
				var multiplier = (Math.PI) / (3 * number);
				var firstTerm = Function(0);
				var secondTerm = Function(Math.PI);
				var thirdTerm = 4 * SumationThirdTerm(number, h);
				var fourthTerm = 2 * SumationFourthTerm(number, h);
				return multiplier*(firstTerm+secondTerm+thirdTerm+fourthTerm);
			}

			private static double SumationFourthTerm(int number, double h)
			{
			var sum = 0d;
			for (int i = 1; i < (number / 2)- 1; i++)
				sum += Function(2 * i * h);
			return sum;
			}


			private static double SumationThirdTerm(int number, double h)
			{
				var sum = 0d;
				for (int i = 1; i < number / 2; i++)
					sum += Function( (2 * i - 1) * h);
				return sum;
			}


			private static double Function(double number) => (3d / 2) * (Math.Pow(Math.Sin(number),3));
		}
}
