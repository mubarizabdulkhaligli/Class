using System;
namespace classwork
{
	internal class Student
	{
		public string FullName;
		public string GroupNo;
		public int Point;


		public bool IsGraduated()
		{
			if (Point >= 65)
				return true;
			return false;
		}

		public string GetInfo()
		{
			return $"Fullname: {FullName} - GroupNo: {GroupNo} - Point: {Point} - Graduated: {IsGraduated()}";
		}
	}
}

