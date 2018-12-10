using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
	class Program
	{
	
		static void Main(string[] args)
		{
			Diary diary = new Diary();
			diary.AddRating(5);
			diary.AddRating(8.5f);
			diary.AddRating(4.7f);

			

			Console.WriteLine(Diary.MaxGrade);

			Diary diary2 = new Diary();
			Diary diary3 = new Diary();
			Diary diary4 = new Diary();
			Diary diary5 = new Diary();
			Diary diary6 = new Diary();

			Console.WriteLine(Diary.MaxGrade);
			
			Console.WriteLine(Diary.Count);

			Console.WriteLine(diary3.Count2);
			Console.WriteLine(diary6.Count2);
			DiaryStatistics stats = diary.ComputeStatistics();
			Console.ReadKey();


		}
	}
}
