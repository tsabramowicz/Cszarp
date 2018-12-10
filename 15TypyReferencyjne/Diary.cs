using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15TypyReferencyjne
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

		public void MinGrade(int a)
		{
			Console.WriteLine(a);
		}


		public static float MaxGrade = 10;
		public static long Count = 0;
		public long Count2 = 0;

		public string Name;

		// Zachowania
		public void AddRating(float rating)
		{
			if (rating >= 0 && rating <= 10)
			{
				ratings.Add(rating);
			}
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
