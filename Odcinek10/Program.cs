﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
	class Program
	{
		static void Main(string[] args)
		{
			Diary diary = new Diary();
			diary.AddRating(3);
			diary.AddRating(5);

			Diary diary2 = diary;
			diary.AddRating(8);

			Diary diary3 = diary2;
			diary3.AddRating(1);
			diary.AddRating(2);

		
		}
	}
}
