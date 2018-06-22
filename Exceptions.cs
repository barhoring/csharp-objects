namespace TreehouseDefense
{
    class TreehouseDefeseException : System.Exception
    {
        public TreehouseDefeseException()
        {

        }
        public TreehouseDefeseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TreehouseDefeseException
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}