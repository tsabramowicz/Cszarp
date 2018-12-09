using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentDiary
{
	class Diary
	{
		public Diary()
		{
			ratings = new List<float>();
			Count++;
			Count2++;
		}

		//Stan (zmienne - ocena)
		public List<float> ratings;

		public static float MinGrade = 0;
		public static float Maxgrade = 10;
		public static long Count = 0;
		public long Count2 = 0;
		
		// Zachowania
		public void AddRating(float rating)
		{
			ratings.Add(rating);
		}

		public DiaryStatistics ComputeStatistics()
		{
			DiaryStatistics stats = new DiaryStatistics();

			float sum = 0f;

			foreach (var rating in ratings)
			{
				sum += rating;
			}
			stats.averageGrade = sum / ratings.Count();
			stats.maxGrade = ratings.Max();
			stats.minGrade = ratings.Min();

			return stats;
		}

	}
}
