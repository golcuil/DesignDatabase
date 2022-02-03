namespace DatabaseConnection
{
    class DbCommand
    {
        private DbConnection _connectionType;
        private string _instruction;

        public DbCommand(DbConnection connectionType, string instruction)
        {
            if (connectionType == null || instruction == null)
            {
                throw new InvalidOperationException("Please enter Database or Instruction.");
            }

            this._connectionType = connectionType;
            this._instruction = instruction;

        }

        public void Execute()
        {
            
            Random rnd = new Random();
            int countConnectionAttempt = 1;
            int openingTime = rnd.Next(0, 13);

            Console.WriteLine("Trying to connect Database...");

            for (int i = 0; i <= openingTime; i++)
            {
                Console.Write("- ");
                Thread.Sleep(1000);
            }

            Console.WriteLine();

            if (openingTime > 9)
            {
                Console.WriteLine("Connection is failed. Attempt {0}", countConnectionAttempt);
                countConnectionAttempt++;
                Execute();

            }
            else
            {
                Console.Clear();
                _connectionType.OpenDB();

                Console.WriteLine(_instruction);

                _connectionType.CloseDB();

            }
        }
    }

}
