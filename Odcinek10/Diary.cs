using System;
using System.Collections.Generic;
using System.Linq;


namespace Odcinek10
{
	class Diary
	{
		public Diary()
		{
			ratings = new List<float>();
		}

		//Stan (zmienne - ocena)
		public List<float> ratings;


		// Zachowania
		/// <summary>
		/// Dodawanie oceny do dzienniczka
		/// </summary>
		/// <param name="rating">Parametrem jest ocena.</param>




		public void AddRating(float rating)
		{
			ratings.Add(rating);
		}

		public float CalculateAverage()
		{
			float sum = 0, avg = 0;

			foreach (var rating in ratings)
			{
				sum += rating;	
			}
			avg = sum / ratings.Count();
			return avg;
		}

		public float GetMaxRating()
		{
			return ratings.Max();
		}

		public float GetMinRating()
		{
			return ratings.Min();
		}
	}
}
