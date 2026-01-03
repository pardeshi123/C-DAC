namespace _10DemoReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your choice: 1. PDF, 2. DOCX, 3. Excel, 4. XML, 5. JSON");
                int choice= Convert.ToInt32(Console.ReadLine());
                ReportFactory factory = new ReportFactory();
                Report report = factory.GetSomeReport(choice);
                report.GenerateReport();

            }
        }
    }
    public abstract class Report
    {
        protected abstract void parse();
        protected abstract void validate();
        protected abstract void save();

        public virtual void GenerateReport()
        {
            parse();
            validate();
            save();
            Console.WriteLine("Report generated.");
        }
    }

    public abstract class SpecialReport : Report
    {
        protected abstract void revalidate();
        public override void GenerateReport()
        {
            parse();
            validate();
            revalidate();
            save();
            Console.WriteLine("Special Report generated.");
        }

    }


    public class ReportFactory
    {
        public Report GetSomeReport(int num)
        {
            Report getreport = null;
            switch (num)
            {
                case 1:
                    {
                        getreport = new Pdf();
                        break;
                    }
                case 2:
                    {
                        getreport = new DOCX();
                        break;
                    }
                case 3:
                    {
                        getreport = new Excel();
                        break;
                    }
                case 4:
                    {
                        getreport = new XML();
                        break;
                    }
                case 5:
                    {
                        getreport = new Json();
                        break;
                    }
                default:
                    {
                        break;
                    }


            }
            return getreport;
        }

        #region PDF
        public class Pdf: Report
        {

            protected override void parse()
            {
                Console.WriteLine("PDF parsed.");
            }
            protected override void validate()
            {
                Console.WriteLine("PDF validate.");
            }
            protected override void save()
            {
                Console.WriteLine("PDF save.");
            }
        }
        #endregion


        #region Json
        public class Json : Report
        {

            protected override void parse()
            {
                Console.WriteLine("Json parsed.");
            }
            protected override void validate()
            {
                Console.WriteLine("Json validate.");
            }
            protected override void save()
            {
                Console.WriteLine("Json save.");
            }
        }
        #endregion

        #region XML
        public class XML : SpecialReport
        {

            protected override void parse()
            {
                Console.WriteLine("XML parsed.");
            }
            protected override void validate()
            {
                Console.WriteLine("XML validate.");
            }
            protected override void revalidate()
            {
                Console.WriteLine("XML revalidate.");
            }
            protected override void save()
            {
                Console.WriteLine("XML save.");
            }
        }
        #endregion

        #region DOCX
        public class DOCX : SpecialReport
        {

            protected override void parse()
            {
                Console.WriteLine("DOCX parsed.");
            }
            protected override void validate()
            {
                Console.WriteLine("DOCX validate.");
            }
            protected override void revalidate()
            {
                Console.WriteLine("DOCX revalidate.");
            }
            protected override void save()
            {
                Console.WriteLine("DOCX save.");
            }
        }
        #endregion


        #region Excel
        public class Excel : SpecialReport
        {

            protected override void parse()
            {
                Console.WriteLine("Excel parsed.");
            }
            protected override void validate()
            {
                Console.WriteLine("Excel validate.");
            }
            protected override void revalidate()
            {
                Console.WriteLine("Excel revalidate.");
            }
            protected override void save()
            {
                Console.WriteLine("Excel save.");
            }
        }
        #endregion
        
    }
}
