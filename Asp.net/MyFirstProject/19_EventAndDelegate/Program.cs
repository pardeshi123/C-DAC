using static _19_EventAndDelegate.Program;

namespace _19_EventAndDelegate
{
    public delegate void MyHandler(int marks);
    internal class Program
    {
      
        static void Main(string[] args)
        {

            Student student = new Student();

            student._pass += new MyHandler(student.student_pass);
            student._fail += new MyHandler(student.student_fail);


            student.Marks = Convert.ToInt32(Console.ReadLine());

            student.TriggerEvents(student.Marks);



        }
    }
    public class Student
    {
        public event MyHandler _pass;
        public event MyHandler _fail;
        private int _Marks;


        public int Marks
        {
            set
            {
                _Marks = value;
                if (_Marks > 40)
                {
                    _pass(_Marks);
                }
                else
                {
                    _fail.Invoke(_Marks);
                }
            }
            get
            {
                return _Marks;
            }
        }

        public void TriggerEvents(int mrk)
        {
            if (mrk > 40)
            {
                _pass(mrk);
            }
            else
            {
                _fail.Invoke(mrk);
            }
        }

        public void student_pass(int marks)
        {
            Console.WriteLine($"Congratulations!!!, you have passed with {marks} marks!!!");
        }

        public void student_fail(int marks)
        {
            Console.WriteLine($"Sorry!!!, you have fail with {marks} marks!!!");
        }
    }
}
