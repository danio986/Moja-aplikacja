namespace Moja_aplikacja
{
    public class UserInMemory
    {
        private List<string> movies = new List<string>();

        private List<float> grades = new List<float>();

        public string Login { get; private set; }

        public UserInMemory(string login)
        {
            this.Login = login;
        }

        public void AddMovie(string movie)
        {
            this.movies.Add(movie);
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 & grade <= 10)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public void ShowMovies()
        {
            foreach (var movie in this.movies) 
            {
                Console.WriteLine(movie);
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}




        // Pierwsza wersja


        //public class MovieInMemory
        //{
        //    //private List<float> grades = new List<float>();

        //    public float Score { get; private set; }
        //    public string Title { get; private set; }

        //    public MovieInMemory(string title)
        //    {
        //        this.Title = title;
        //        this.Score = 0;
        //    }

        //    public void AddScore(float score)
        //    {
        //        this.Score += score;
        //    }

        //    public void AddScore(string score)
        //    {
        //        if (float.TryParse(score, out float result))
        //        {
        //            this.AddScore(result);
        //        }
        //        else
        //        {
        //            throw new Exception("String is not float");
        //        }
        //    }

        //    public Statistics GetStatistics()
        //    {
        //        var statistics = new Statistics();
        //        statistics.Average = 0;
        //        statistics.Max = float.MinValue;
        //        statistics.Min = float.MaxValue;

        //        foreach (var score in this.Score)
        //        {
        //            statistics.Max = Math.Max(statistics.Max, score);
        //            statistics.Min = Math.Min(statistics.Min, score);
        //            statistics.Average += score;
        //        }

        //        statistics.Average /= this.Score;
        //        return statistics;
        //    }