using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            File file = new File("MyFile", "text");
            
            TextHandler textHandler = new TextHandler();
            WordHandler wordHandler = new WordHandler();
            OtherHandler otherHandler = new OtherHandler();

            textHandler.SetNextHandler(wordHandler);
            textHandler.SetNextHandler(otherHandler);

            textHandler.HandleRequest(file);

        }
    }

    class File
    {
        public string _name;
        public string _extension;

        public File(string name, string extension)
        {
            _name = name;
            _extension = extension;
        }
    }
    
    abstract class BaseHandler
    {
        protected BaseHandler _nextHandler;
        public void SetNextHandler(BaseHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(File file);
    }

    class TextHandler : BaseHandler
    {
        public override void HandleRequest(File file)
        {
            if(file._extension == "text")
            {
                Console.WriteLine("text to PDF");
            }
            else
            {
                _nextHandler.HandleRequest(file);
            }
        }
    }

    class WordHandler : BaseHandler
    {
        public override void HandleRequest(File file)
        {
            if(file._extension == "word")
            {
                Console.WriteLine("Word to pdf");
            }
            else
            {
                _nextHandler.HandleRequest(file);
            }
        }
    }

    class OtherHandler : BaseHandler
    {
        public override void HandleRequest(File file)
        {
            if(file._extension == "other")
            {
                Console.WriteLine("Other to pdf");
            }
        }
    }

}
