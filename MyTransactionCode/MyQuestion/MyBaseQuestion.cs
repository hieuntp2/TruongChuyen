using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;

namespace MyTransactionCode.MyQuestion
{
    public enum MyQuestionType
    {
        MyOneChoiceQuestion = 1,
        MyMultiChoiceQuestion = 2,
        MyMissingFieldQuestion = 3
    }
    public class MyBaseQuestion
    {
        public string Question;
        public string Answer;
        public int Time;
        public string ClassName;
        public int Prioriy;
        public int Id;

        /// <summary>
        /// Nếu yêu cầu phân biệt chữ hoa/thường thì giá trị = true. Không thì giá trị = false;
        /// </summary>
        public bool isUpcase;
        public string choiceA, choiceB, choiceC, choiceD;

        public MyQuestionType type;

        //public string getClassName() { }
    }

    public class MyOneChoiceQuestion : MyBaseQuestion
    {
        //public override string getClassName()
        //{
        //    return "MyOneChoiceQuestion";
        //}
    }

    public class MyMultiChoiceQuestion : MyBaseQuestion
    {
        //public override string getClassName()
        //{
        //    return "MyMultiChoiceQuestion";
        //}
    }

    public class MyMissingFieldQuestion : MyBaseQuestion
    {
        //public override string getClassName()
        //{
        //    return "MyMissingFieldQuestion";
        //}
    }

    public class MyQuestionFactory
    {
        //public MyBaseQuestion recreateQuestion(JObject question)
        //{
        //    return null;
        //}
    }

    public class MyGroupQuestion
    {
        public List<MyBaseQuestion> questions;
        public string address;
        public string name;
        private int _currentIndexQuestion;

        public int CurrentIndexQuestion
        {
            get { return _currentIndexQuestion; }
            set { _currentIndexQuestion = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public MyGroupQuestion()
        {
            questions = new List<MyBaseQuestion>();
            _currentIndexQuestion = -1;
        }

        public void LoadFromFile(string address)
        {
            string data = System.IO.File.ReadAllText(address);
            JObject jobject = JObject.Parse(data);
            this.convertFromJObjcet(jobject);
        }

        /// <summary>
        /// Thêm câu hỏi vào bộ câu hỏi
        /// </summary>
        /// <param name="question"></param>
        /// <returns>ID của câu hỏi trong bộ câu hỏi</returns>
        public int addQuestion(MyBaseQuestion question)
        {
            question.Id = questions.Count;
            questions.Add(question);

            return question.Id;
        }

        public void removeQuestion(short p)
        {
            foreach (MyBaseQuestion q in questions)
            {
                if (q.Id == p)
                {
                    questions.RemoveAt(p);
                    break;
                }
            }
        }

        public MyBaseQuestion getQuestion(int p)
        {
            foreach(MyBaseQuestion q in questions)
            {
                if(q.Id == p)
                {
                    return q;
                }
            }
            return null;
        }

        public void SaveToFile(string name, string path)
        {
            this.name = name;
            this.address = path;
            // convert oject to json string
            StringBuilder data = new StringBuilder();
            data.Append(JsonConvert.SerializeObject(this));
            
            System.IO.StreamWriter file = new System.IO.StreamWriter(path);
            file.WriteLine(data);
            file.Close();
        }

        public void convertFromJObjcet(JObject jobject)
        {
            this.address = jobject["Address"].ToString();
            this.name = jobject["Name"].ToString();
            
            foreach(var item in jobject["questions"])
            {
                MyBaseQuestion question = new MyBaseQuestion();
                question.Answer = item["Answer"].ToString();
                question.choiceA = item["choiceA"].ToString();
                question.choiceB = item["choiceB"].ToString();
                question.choiceC = item["choiceC"].ToString();
                question.choiceD = item["choiceD"].ToString();
                question.ClassName = item["ClassName"].ToString();
                question.Id = int.Parse(item["Id"].ToString());
                question.isUpcase = bool.Parse(item["isUpcase"].ToString());
                question.Prioriy = int.Parse(item["Prioriy"].ToString());
                question.Question = item["Question"].ToString();
                question.Time = int.Parse(item["Time"].ToString());
              
               
                switch(int.Parse(item["type"].ToString()))
                {
                    case 1:
                        question.type = MyQuestionType.MyOneChoiceQuestion;
                        break;
                    case 2:
                        question.type = MyQuestionType.MyMultiChoiceQuestion;
                        break;
                    case 3:
                        question.type = MyQuestionType.MyMissingFieldQuestion;
                        break;
                }

                questions.Add(question);
            }
        }

        public void updateQuestion(MyBaseQuestion question)
        {
            for(int i = 0; i < questions.Count; i++)
            {
                if(questions[i].Id == question.Id)
                {
                    questions[i] = question;
                }
            }
        }

        public MyBaseQuestion getNextQuestion()
        {
            CurrentIndexQuestion += 1;
            if(CurrentIndexQuestion >= questions.Count)
            {
                CurrentIndexQuestion = questions.Count;
                return null;
            }            
            return questions[CurrentIndexQuestion];
        }
    }
}
