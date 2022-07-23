//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework.Constraints;

//namespace Katas.Tests
//{
//		public class TimeFormatTests
//		{
//			[TestCase(0, "00:00:00")]
//			[TestCase(5, "00:00:05")]
//			[TestCase(10, "00:00:10")]
//		public void Seconds(int seconds, string expected)
//			{
//				var result = TimeFormat.GetReadableTime(seconds);
//				Assert.That(result, Is.EqualTo(expected));
//			}
//		}

//		public class TimeFormat
//		{
//			public static string GetReadableTime(int seconds)
//			{
//				if (seconds < 10)
//					return $"00:00:0{seconds}";
//				if (seconds<=59)
//				return "00:00:00";
//			}
//		}
//}
