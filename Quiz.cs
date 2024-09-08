namespace quiz
{
    public class Quiz
    {
        public struct Question
        {
            public Question(string questionText, string[] answers, int correctAnswer)
            {
                this.questionText = questionText;
                this.answers = answers;
                this.correctAnswer = correctAnswer;
            }
            public string questionText;
            public string[] answers;
            public int correctAnswer;
        }

        List<Question> questions_biology = new List<Question>
        {
            new Question("What is the Human?", ["Alien", "Mammal", "Monkey", "Homo sapiens"], 4),
            new Question("How many bones does a Human have?", ["95", "187", "206", "361"], 3),
            new Question("Where is the brain of a human?", ["Chest", "Head", "Belly", "Eyes"], 2),
            new Question("What is the powerhouse of the cell?", ["Nucleus", "Mitochondria", "Ribosome", "Golgi apparatus"], 2),
            new Question("What pigment is responsible for the green color in plants?", ["Chlorophyll", "Hemoglobin", "Carotene", "Melanin"], 1),
            new Question("Which organ is primarily responsible for filtering blood?", ["Heart", "Liver", "Kidneys", "Lungs"], 3),
            new Question("What is the basic unit of life?", ["Tissue", "Organ", "Cell", "Organism"], 3),
            new Question("Which blood cells are responsible for fighting infections?", ["Red blood cells", "White blood cells", "Platelets", "Plasma cells"], 2),
            new Question("Which part of the brain is responsible for balance?", ["Cerebrum", "Cerebellum", "Medulla", "Hypothalamus"], 2),
            new Question("Which vitamin is produced by the skin when exposed to sunlight?", ["Vitamin A", "Vitamin C", "Vitamin D", "Vitamin E"], 3),
            new Question("Which gas do plants absorb from the atmosphere?", ["Oxygen", "Nitrogen", "Carbon dioxide", "Hydrogen"], 3),
            new Question("What is the largest organ in the human body?", ["Heart", "Liver", "Skin", "Lungs"], 3),
            new Question("Which molecule carries genetic information?", ["RNA", "DNA", "ATP", "Enzyme"], 2),
            new Question("What part of the plant conducts photosynthesis?", ["Roots", "Stem", "Leaves", "Flowers"], 3),
            new Question("Which animal is known as the king of the jungle?", ["Elephant", "Tiger", "Lion", "Bear"], 3),
            new Question("How many chambers does the human heart have?", ["2", "3", "4", "5"], 3),
            new Question("What is the largest bone in the human body?", ["Skull", "Femur", "Humerus", "Tibia"], 2),
            new Question("Which hormone regulates blood sugar levels?", ["Adrenaline", "Insulin", "Thyroxine", "Melatonin"], 2),
            new Question("Which structure protects the lungs and heart?", ["Skull", "Spine", "Rib cage", "Pelvis"], 3),
            new Question("Which animal is known for its ability to regenerate limbs?", ["Octopus", "Starfish", "Frog", "Shark"], 2)
        };

        List<Question> questions_history = new List<Question>()
        {
            new Question("When did World War II end?", ["1943", "1945", "1939", "1941"], 2),
            new Question("When was the first time Vladimir Putin became president?", ["2000", "2004", "2011", "1998"], 1),
            new Question("When did the Soviet Union collapse?", ["1995", "1989", "1999", "1991"], 4),
            new Question("Who was the first President of the United States?", ["George Washington", "Thomas Jefferson", "John Adams", "Benjamin Franklin"], 1),
            new Question("What year did the Titanic sink?", ["1905", "1912", "1920", "1918"], 2),
            new Question("When was the Magna Carta signed?", ["1215", "1066", "1492", "1666"], 1),
            new Question("Who discovered America?", ["Christopher Columbus", "Leif Erikson", "Marco Polo", "Ferdinand Magellan"], 1),
            new Question("When did the Berlin Wall fall?", ["1985", "1987", "1989", "1991"], 3),
            new Question("What year did the American Civil War begin?", ["1859", "1861", "1865", "1870"], 2),
            new Question("Who was the first woman to fly solo across the Atlantic?", ["Harriet Quimby", "Bessie Coleman", "Amelia Earhart", "Jacqueline Cochran"], 3),
            new Question("Which event started World War I?", ["Assassination of Franz Ferdinand", "Invasion of Poland", "Sinking of the Lusitania", "Treaty of Versailles"], 1),
            new Question("Who was the leader of Nazi Germany during World War II?", ["Joseph Stalin", "Adolf Hitler", "Benito Mussolini", "Winston Churchill"], 2),
            new Question("What ancient civilization built the pyramids?", ["Romans", "Greeks", "Egyptians", "Persians"], 3),
            new Question("When did the French Revolution begin?", ["1776", "1789", "1804", "1821"], 2),
            new Question("Who was the first emperor of Rome?", ["Julius Caesar", "Nero", "Augustus", "Caligula"], 3),
            new Question("When did the first man land on the moon?", ["1965", "1967", "1969", "1971"], 3),
            new Question("What year did the Vietnam War end?", ["1973", "1975", "1977", "1979"], 2),
            new Question("Who was the Prime Minister of the UK during most of World War II?", ["Winston Churchill", "Neville Chamberlain", "Clement Attlee", "Anthony Eden"], 1),
            new Question("Which ancient civilization was known for its philosophers like Socrates, Plato, and Aristotle?", ["Roman", "Chinese", "Greek", "Egyptian"], 3),
            new Question("When did the Industrial Revolution begin?", ["16th century", "17th century", "18th century", "19th century"], 3)
        };

        List<Question> questions_geography = new List<Question>()
        {
            new Question("What is the capital city of Portugal?", ["Porto", "Amadora", "Lisbon", "Braga"], 3),
            new Question("Where is Mount Everest located?", ["Switzerland/Germany", "Morocco/Algeria", "USA/Mexico", "China/Nepal"], 4),
            new Question("What's the largest city in Brazil by size?", ["Sao Paulo", "Rio de Janeiro", "Brasilia", "Santos"], 1),
            new Question("Which is the longest river in the world?", ["Amazon", "Nile", "Yangtze", "Mississippi"], 2),
            new Question("What is the smallest country in the world?", ["Malta", "Monaco", "Vatican City", "San Marino"], 3),
            new Question("Which desert is the largest in the world?", ["Sahara", "Arabian", "Gobi", "Kalahari"], 1),
            new Question("What is the capital of Australia?", ["Sydney", "Melbourne", "Canberra", "Perth"], 3),
            new Question("Which country has the most natural lakes?", ["Canada", "Russia", "Brazil", "India"], 1),
            new Question("What ocean is the largest?", ["Atlantic", "Indian", "Arctic", "Pacific"], 4),
            new Question("Which country has the highest population?", ["USA", "India", "China", "Indonesia"], 3),
            new Question("Which continent is the Sahara Desert located?", ["Asia", "Africa", "Australia", "South America"], 2),
            new Question("What is the tallest mountain in North America?", ["Denali", "Mount Logan", "Mount Whitney", "Mount Elbert"], 1),
            new Question("Which city is known as the 'City of Love'?", ["Rome", "Paris", "Venice", "Madrid"], 2),
            new Question("What is the capital city of Canada?", ["Toronto", "Montreal", "Vancouver", "Ottawa"], 4),
            new Question("Which U.S. state is the Grand Canyon located in?", ["California", "Nevada", "Arizona", "Utah"], 3),
            new Question("What is the most populous city in the world?", ["Tokyo", "New York", "Shanghai", "Delhi"], 1),
            new Question("Which river runs through Baghdad?", ["Nile", "Euphrates", "Tigris", "Jordan"], 3),
            new Question("Which country is known as the Land of the Rising Sun?", ["Thailand", "Japan", "South Korea", "China"], 2),
            new Question("What is the capital of Egypt?", ["Cairo", "Alexandria", "Luxor", "Giza"], 1),
            new Question("Which continent has the most countries?", ["Africa", "Asia", "Europe", "South America"], 1)
        };

        List<Question> questions_all = new List<Question>()
        {
            new Question("What is the Human?", ["Alien", "Mammal", "Monkey", "Homo sapiens"], 4),
            new Question("How many bones does a Human have?", ["95", "187", "206", "361"], 3),
            new Question("Where is the brain of a human?", ["Chest", "Head", "Belly", "Eyes"], 2),
            new Question("What is the powerhouse of the cell?", ["Nucleus", "Mitochondria", "Ribosome", "Golgi apparatus"], 2),
            new Question("What pigment is responsible for the green color in plants?", ["Chlorophyll", "Hemoglobin", "Carotene", "Melanin"], 1),
            new Question("Which organ is primarily responsible for filtering blood?", ["Heart", "Liver", "Kidneys", "Lungs"], 3),
            new Question("What is the basic unit of life?", ["Tissue", "Organ", "Cell", "Organism"], 3),
            new Question("Which blood cells are responsible for fighting infections?", ["Red blood cells", "White blood cells", "Platelets", "Plasma cells"], 2),
            new Question("Which part of the brain is responsible for balance?", ["Cerebrum", "Cerebellum", "Medulla", "Hypothalamus"], 2),
            new Question("Which vitamin is produced by the skin when exposed to sunlight?", ["Vitamin A", "Vitamin C", "Vitamin D", "Vitamin E"], 3),
            new Question("Which gas do plants absorb from the atmosphere?", ["Oxygen", "Nitrogen", "Carbon dioxide", "Hydrogen"], 3),
            new Question("What is the largest organ in the human body?", ["Heart", "Liver", "Skin", "Lungs"], 3),
            new Question("Which molecule carries genetic information?", ["RNA", "DNA", "ATP", "Enzyme"], 2),
            new Question("What part of the plant conducts photosynthesis?", ["Roots", "Stem", "Leaves", "Flowers"], 3),
            new Question("Which animal is known as the king of the jungle?", ["Elephant", "Tiger", "Lion", "Bear"], 3),
            new Question("How many chambers does the human heart have?", ["2", "3", "4", "5"], 3),
            new Question("What is the largest bone in the human body?", ["Skull", "Femur", "Humerus", "Tibia"], 2),
            new Question("Which hormone regulates blood sugar levels?", ["Adrenaline", "Insulin", "Thyroxine", "Melatonin"], 2),
            new Question("Which structure protects the lungs and heart?", ["Skull", "Spine", "Rib cage", "Pelvis"], 3),
            new Question("Which animal is known for its ability to regenerate limbs?", ["Octopus", "Starfish", "Frog", "Shark"], 2),
            new Question("When did World War II end?", ["1943", "1945", "1939", "1941"], 2),
            new Question("When was the first time Vladimir Putin became president?", ["2000", "2004", "2011", "1998"], 1),
            new Question("When did the Soviet Union collapse?", ["1995", "1989", "1999", "1991"], 4),
            new Question("Who was the first President of the United States?", ["George Washington", "Thomas Jefferson", "John Adams", "Benjamin Franklin"], 1),
            new Question("What year did the Titanic sink?", ["1905", "1912", "1920", "1918"], 2),
            new Question("When was the Magna Carta signed?", ["1215", "1066", "1492", "1666"], 1),
            new Question("Who discovered America?", ["Christopher Columbus", "Leif Erikson", "Marco Polo", "Ferdinand Magellan"], 1),
            new Question("When did the Berlin Wall fall?", ["1985", "1987", "1989", "1991"], 3),
            new Question("What year did the American Civil War begin?", ["1859", "1861", "1865", "1870"], 2),
            new Question("Who was the first woman to fly solo across the Atlantic?", ["Harriet Quimby", "Bessie Coleman", "Amelia Earhart", "Jacqueline Cochran"], 3),
            new Question("Which event started World War I?", ["Assassination of Franz Ferdinand", "Invasion of Poland", "Sinking of the Lusitania", "Treaty of Versailles"], 1),
            new Question("Who was the leader of Nazi Germany during World War II?", ["Joseph Stalin", "Adolf Hitler", "Benito Mussolini", "Winston Churchill"], 2),
            new Question("What ancient civilization built the pyramids?", ["Romans", "Greeks", "Egyptians", "Persians"], 3),
            new Question("When did the French Revolution begin?", ["1776", "1789", "1804", "1821"], 2),
            new Question("Who was the first emperor of Rome?", ["Julius Caesar", "Nero", "Augustus", "Caligula"], 3),
            new Question("When did the first man land on the moon?", ["1965", "1967", "1969", "1971"], 3),
            new Question("What year did the Vietnam War end?", ["1973", "1975", "1977", "1979"], 2),
            new Question("Who was the Prime Minister of the UK during most of World War II?", ["Winston Churchill", "Neville Chamberlain", "Clement Attlee", "Anthony Eden"], 1),
            new Question("Which ancient civilization was known for its philosophers like Socrates, Plato, and Aristotle?", ["Roman", "Chinese", "Greek", "Egyptian"], 3),
            new Question("When did the Industrial Revolution begin?", ["16th century", "17th century", "18th century", "19th century"], 3),
            new Question("What is the capital city of Portugal?", ["Porto", "Amadora", "Lisbon", "Braga"], 3),
            new Question("Where is Mount Everest located?", ["Switzerland/Germany", "Morocco/Algeria", "USA/Mexico", "China/Nepal"], 4),
            new Question("What's the largest city in Brazil by size?", ["Sao Paulo", "Rio de Janeiro", "Brasilia", "Santos"], 1),
            new Question("Which is the longest river in the world?", ["Amazon", "Nile", "Yangtze", "Mississippi"], 2),
            new Question("What is the smallest country in the world?", ["Malta", "Monaco", "Vatican City", "San Marino"], 3),
            new Question("Which desert is the largest in the world?", ["Sahara", "Arabian", "Gobi", "Kalahari"], 1),
            new Question("What is the capital of Australia?", ["Sydney", "Melbourne", "Canberra", "Perth"], 3),
            new Question("Which country has the most natural lakes?", ["Canada", "Russia", "Brazil", "India"], 1),
            new Question("What ocean is the largest?", ["Atlantic", "Indian", "Arctic", "Pacific"], 4),
            new Question("Which country has the highest population?", ["USA", "India", "China", "Indonesia"], 3),
            new Question("Which continent is the Sahara Desert located?", ["Asia", "Africa", "Australia", "South America"], 2),
            new Question("What is the tallest mountain in North America?", ["Denali", "Mount Logan", "Mount Whitney", "Mount Elbert"], 1),
            new Question("Which city is known as the 'City of Love'?", ["Rome", "Paris", "Venice", "Madrid"], 2),
            new Question("What is the capital city of Canada?", ["Toronto", "Montreal", "Vancouver", "Ottawa"], 4),
            new Question("Which U.S. state is the Grand Canyon located in?", ["California", "Nevada", "Arizona", "Utah"], 3),
            new Question("What is the most populous city in the world?", ["Tokyo", "New York", "Shanghai", "Delhi"], 1),
            new Question("Which river runs through Baghdad?", ["Nile", "Euphrates", "Tigris", "Jordan"], 3),
            new Question("Which country is known as the Land of the Rising Sun?", ["Thailand", "Japan", "South Korea", "China"], 2),
            new Question("What is the capital of Egypt?", ["Cairo", "Alexandria", "Luxor", "Giza"], 1),
            new Question("Which continent has the most countries?", ["Africa", "Asia", "Europe", "South America"], 1)
        };

        Dictionary<string, Dictionary<int, int>> statisticsQuizzes = new Dictionary<string, Dictionary<int, int>>();

        string currentUser = string.Empty;

        public bool CheckLoginPassword()
        {
            Console.WriteLine("1 - Login\n2 - Registrate");

            int? num = null;

            ConsoleKeyInfo userInputSymbol;

            do
            {
                userInputSymbol = Console.ReadKey(true);
            }
            while (userInputSymbol.Key < ConsoleKey.D0 || userInputSymbol.Key > ConsoleKey.D5);

            num = Convert.ToInt32(userInputSymbol.KeyChar.ToString());

            string currentDirectory = Directory.GetCurrentDirectory();

            switch (num)
            {
                case 1:
                    Console.WriteLine("Type in your username:");
                    string? login = Console.ReadLine();

                    Console.WriteLine("Type in your password:");
                    string? password = Console.ReadLine();
                    
                    if (File.Exists(currentDirectory + login + ".txt"))
                    {
                        using (var reader = new StreamReader(currentDirectory + login + ".txt"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                var parts = line.Split(',');
                                if (parts.Length == 3)
                                {
                                    string fileUsername = parts[0];
                                    string filePassword = parts[1];

                                    if (fileUsername == login)
                                    {
                                        if (filePassword == password)
                                        {
                                            Console.WriteLine($"Success. Welcome {login}");
                                            currentUser = login;
                                            return true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Wrong password.");
                                            return false;
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is no User with this name.");
                        break;
                    }

                case 2:
                    Console.WriteLine("Type in your new username:");
                    string? newLogin = Console.ReadLine();

                    Console.WriteLine("Type in your new password:");
                    string? newPassword = Console.ReadLine();

                    Console.WriteLine("Type in your birthdate:");
                    string? newDate = Console.ReadLine();

                    currentUser = newLogin;

                    if (!File.Exists(currentDirectory + newLogin + ".txt"))
                    {
                        try
                        {
                            using (var writer = new StreamWriter(currentDirectory + newLogin + ".txt"))
                            {
                                writer.WriteLine($"{newLogin},{newPassword},{newDate}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error in writing the file.");
                        }

                        Console.WriteLine($"{newLogin} was successfully registrated.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("There is already a User with this username.");
                        return false;
                    }
            }
            return false;
        }

        public void PrintMenu()
        {
            if (CheckLoginPassword())
            {
                const uint NUMBER_EXIT_MENU_ELEMENT = 5;
                int numberMenuElement = 0;

                while (numberMenuElement != NUMBER_EXIT_MENU_ELEMENT)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to Victorina!");
                    Console.WriteLine("1 - Start new Quiz");
                    Console.WriteLine("2 - See your last quiz results");
                    Console.WriteLine("3 - See the Top 20 by category");
                    Console.WriteLine("4 - Change your settings (login and birthdate)");
                    Console.WriteLine("5 - Exit");

                    Console.WriteLine("\nChoose an option:");
                    ConsoleKeyInfo userInputSymbol;

                    do
                    {
                        userInputSymbol = Console.ReadKey(true);
                    }
                    while (userInputSymbol.Key < ConsoleKey.D0 || userInputSymbol.Key > ConsoleKey.D5);

                    numberMenuElement = Convert.ToInt32(userInputSymbol.KeyChar.ToString());

                    switch (numberMenuElement)
                    {
                        case 1:
                            StartQuiz();
                            break;
                    }
                }
            }
        }

        public void StartQuiz()
        {
            Console.Clear();
            Console.WriteLine("1 - Quiz with one category");
            Console.WriteLine("2 - Random quiz with all categories");

            Console.WriteLine("\nChoose an option:");
            ConsoleKeyInfo userInputSymbol;

            do
            {
                userInputSymbol = Console.ReadKey(true);
            }
            while (userInputSymbol.Key < ConsoleKey.D0 || userInputSymbol.Key > ConsoleKey.D2);

            int numberMenuElement = Convert.ToInt32(userInputSymbol.KeyChar.ToString());

            switch (numberMenuElement)
            {
                case 1:
                    int categoryNum = ChooseCategory();

                    switch (categoryNum)
                    {
                        case 1:
                            QuizCategory(questions_biology);
                            break;
                        case 2:
                            QuizCategory(questions_history);
                            break;
                        case 3:
                            QuizCategory(questions_geography);
                            break;
                    }

                    break;

                case 2:
                    RandomQuiz();

                    break;
            }
        }

        public int ChooseCategory()
        {
            Console.Clear();
            Console.WriteLine("1 - Biology\n2 - History\n3 - Geography\n\nChoose a category:");
            ConsoleKeyInfo userInputSymbol = Console.ReadKey();
            Console.Clear();
            return Convert.ToInt32(Convert.ToInt32(userInputSymbol.KeyChar.ToString()));
        }

        public int GradeCalculator(int numCorrect)
        {
            int grade = 0;

            if (numCorrect >= 16)
            {
                grade = 5;
            }
            else if (numCorrect >= 12 && numCorrect <= 15)
            {
                grade = 4;
            }
            else if (numCorrect >= 8 && numCorrect <= 11)
            {
                grade = 3;
            }
            else if (numCorrect >= 0 && numCorrect <= 7)
            {
                grade = 2;
            }

            return grade;
        }

        public void QuizCategory(List<Question> questions)
        {
            int countForeach = 1;
            int userCorrectCount = 0;

            foreach (Question question in questions)
            {
                Console.WriteLine(question.questionText);

                for (int i = 0; i < question.answers.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {question.answers[i]}");
                }

                Console.WriteLine("\nChoose the correct answer:");

                int userAnswer = 0;
                ConsoleKeyInfo userInputSymbol;

                do
                {
                    userInputSymbol = Console.ReadKey();
                    Console.Clear();
                }
                while (userInputSymbol.Key < ConsoleKey.D0 && userInputSymbol.Key > ConsoleKey.D5);

                userAnswer = Convert.ToInt32(Convert.ToInt32(userInputSymbol.KeyChar.ToString()));

                if (userAnswer == question.correctAnswer)
                {
                    ++userCorrectCount;
                    Console.WriteLine("Correct.");
                }
                else
                {
                    Console.WriteLine($"Wrong. The answer was {question.correctAnswer}.");
                }

                if (countForeach < 20)
                {
                    Console.WriteLine("Press any Key to continue with the Quiz:");
                    Console.ReadKey();
                    Console.Clear();
                    ++countForeach;
                }
                else
                {
                    Console.WriteLine($"You got the grade: {GradeCalculator(userCorrectCount)}\nYou had {userCorrectCount} questions answered right.\n");

                    Dictionary<int, int> temp = new Dictionary<int, int>
                    {
                        {GradeCalculator(userCorrectCount), userCorrectCount}
                    };

                    statisticsQuizzes.Add(currentUser, temp);

                    Console.WriteLine("Press any Key to return to the main Menu:");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        public void RandomQuiz()
        {
            Random random = new Random();

            List<Question> randomizedQuestions = new List<Question>(); 

            for (int i = 0; i < 20;  i++)
            {
                int rand = random.Next(60);

                randomizedQuestions.Add(questions_all[rand]);
            }

            int countForeach = 1;
            int userCorrectCount = 0;

            foreach (Question question in randomizedQuestions)
            {
                Console.WriteLine(question.questionText);

                for (int i = 0; i < question.answers.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {question.answers[i]}");
                }

                Console.WriteLine("\nChoose the correct answer:");

                int userAnswer = 0;
                ConsoleKeyInfo userInputSymbol;

                do
                {
                    userInputSymbol = Console.ReadKey();
                    Console.Clear();
                }
                while (userInputSymbol.Key < ConsoleKey.D0 && userInputSymbol.Key > ConsoleKey.D5);

                userAnswer = Convert.ToInt32(Convert.ToInt32(userInputSymbol.KeyChar.ToString()));

                if (userAnswer == question.correctAnswer)
                {
                    ++userCorrectCount;
                    Console.WriteLine("Correct.");
                }
                else
                {
                    Console.WriteLine($"Wrong. The answer was {question.correctAnswer}.");
                }

                if (countForeach < 20)
                {
                    Console.WriteLine("Press any Key to continue with the Quiz:");
                    Console.ReadKey();
                    Console.Clear();
                    ++countForeach;
                }
                else
                {
                    Console.WriteLine($"You got the grade: {GradeCalculator(userCorrectCount)}\nYou had {userCorrectCount} questions answered right.\n");

                    Dictionary<int, int> temp = new Dictionary<int, int>
                    {
                        {GradeCalculator(userCorrectCount), userCorrectCount}
                    };

                    statisticsQuizzes.Add(currentUser, temp);

                    Console.WriteLine("Press any Key to return to the main Menu:");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}