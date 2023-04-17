namespace Moja_aplikacja
{
    public class UserInFile
    {
        private const string fileName = "movies.txt";

        public string Title { get; private set; }

        public UserInFile(string title)
        {
            this.Title = title;
        }

        public void AddMovie(string movie)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.Write(movie + " - ");
            }
        }

        public void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
                if (grade >= 0 & grade <= 10)
                {
                    writer.Write(grade);
                    writer.WriteLine();
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
    }
}

//        public void AddScore(float score)
//        {
//            this.Score += score; 
//        }

//        public void AddScore(string score)
//        {
//            if (float.TryParse(score, out float result))
//            {
//                this.AddScore(result);
//            }
//            else
//            {
//                throw new Exception("String is not float");
//            }
//        }

//        //

//        public override void AddGrade(float grade)
//        {
//            if (grade >= 0 && grade <= 100)
//            {
//                using (var writer = File.AppendText(fileName))
//                {
//                    writer.WriteLine(grade);
//                }
//                if (GradeAdded != null)
//                {
//                    GradeAdded(this, new EventArgs());
//                }
//            }
//            else
//            {
//                throw new Exception("Invalid grade value");
//            }

//        }

//        public override void AddGrade(int grade)
//        {
//            float gradeAsFloat = grade;
//            this.AddGrade(gradeAsFloat);
//        }

//        public override void AddGrade(char grade)
//        {
//            switch (grade)
//            {
//                case 'A':
//                case 'a':
//                    this.AddGrade(100);
//                    break;
//                case 'B':
//                case 'b':
//                    this.AddGrade(80);
//                    break;
//                case 'C':
//                case 'c':
//                    this.AddGrade(60);
//                    break;
//                case 'D':
//                case 'd':
//                    this.AddGrade(40);
//                    break;
//                case 'E':
//                case 'e':
//                    this.AddGrade(20);
//                    break;
//                default:
//                    throw new Exception("Wrong letter");
//            }
//        }

//        public override void AddGrade(string grade)
//        {
//            if (float.TryParse(grade, out float result))
//            {
//                this.AddGrade(result);
//            }
//            else if (char.TryParse(grade, out char Letter))
//            {
//                this.AddGrade(Letter);
//            }
//            else
//            {
//                throw new Exception("String is not float");
//            }
//        }

//        public override void AddGrade(double grade)
//        {
//            float valueInFloat = (float)grade;
//            this.AddGrade(valueInFloat);
//        }

//        public override Statistics GetStatistics()
//        {
//            var gradesFromFile = this.ReadGradesFromFile();
//            var result = this.CountStatistics(gradesFromFile);
//            return result;
//        }

//        private List<float> ReadGradesFromFile()
//        {
//            var grades = new List<float>();
//            if (File.Exists($"{fileName}"))
//            {
//                using (var reader = File.OpenText($"{fileName}"))
//                {
//                    var line = reader.ReadLine();
//                    while (line != null)
//                    {
//                        var number = float.Parse(line);
//                        grades.Add(number);
//                        line = reader.ReadLine();
//                    }
//                }
//            }
//            return grades;
//        }

//        private Statistics CountStatistics(List<float> grades)
//        {
//            var statistics = new Statistics();

//            foreach (var grade in grades)
//            {
//                if (grade >= 0)
//                {
//                    statistics.AddGrade(grade);
//                }
//            }
//            return statistics;
//        }
//    }
//}
//}
