
namespace _13Demo_Notepad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter the choice as per following data marathi = ma,  Gujrati= GJ, Sanskrut= San, Default English");
                String ch = Console.ReadLine();

                SpellCheckerFactory factory = new SpellCheckerFactory();
                ISpellChecker somechecker = factory.GetSomeSpellChcker(ch);
                Notepad notepad = new Notepad(somechecker);
                notepad.Cut();
                notepad.SpellCheck();
            }
            while (true);

        }
    }

    internal class Notepad
    {
        private ISpellChecker _checker;

        public Notepad(ISpellChecker checker)
        {
            SpellCheckerFactory factory = new SpellCheckerFactory();
            //if (checker == null)
            //{
            //    _checker = factory.GetSomeSpellChcker("en");
            //}
            //else
            //{
                _checker = checker;
            //}
        }

        internal void Cut()
        {
            Console.WriteLine("Text Cut functionality done");
        }

        internal void SpellCheck()
        {
            _checker.DoSpellCheck();
        }
    }

    internal interface ISpellChecker
    {
        void DoSpellCheck();
    }

    internal class SpellCheckerFactory
    {
        internal ISpellChecker GetSomeSpellChcker(string v)
        {
            ISpellChecker _someChecker = null;
            switch (v)
            {
                case "ma":
                    _someChecker = new MarathiSpellChecker();
                    break;
                case "GJ":
                    _someChecker = new GJSpellChecker();
                    break;
                case "San":
                    _someChecker = new SansSpellChecker();
                    break;
                default:
                    _someChecker = new EnglishSpellChecker();
                    break;
            }
            return _someChecker;
        }
    }

    internal class SansSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine(" Sanskrut bhashayam upasthitou");
        }
    }

    internal class GJSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine(" gujarathi ma boluchu ");
        }
    }

    internal class MarathiSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Marathi bhasha sathi Cheking Generate zali ahe ");
        }
    }

    internal class EnglishSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Speck Check done for English Text");
        }
    }
}
