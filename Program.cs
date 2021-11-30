/*
 * На сколько помню условие задачи. есть два списка:
 * - в первом номера проектов
 * - во втором предложения по ценам за них
 * и нужно выбрать минимальную сумму, при условии, что выполнятся все проекты. 
 * Иначе вернуть -1
 */

		int SolveMinPrice(List<int> projects, List<int> price)
		{
			if (projects.Count <= price.Count)
			{
				Dictionary<int, int> projectsPrice = new Dictionary<int, int>();
				for (int i = 0; i < projects.Count; i++)
				{
					if (!projectsPrice.ContainsKey(projects[i]))
					{
						projectsPrice[projects[i]] = price[i];
					}
					else
					{
						projectsPrice[projects[i]] = Math.Min(projectsPrice[projects[i]], price[i]);
					}
				}
				return projectsPrice.Sum(x => x.Value);
			}

			return -1;
		}


