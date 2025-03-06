


namespace Utilities
{
    public class CLIUI
    {
        //Quick and Dirty Singleton

        private static CLIUI? instance { get; set; }

        public static CLIUI Instance()
        {
            if (instance == null)
            {
                instance = new CLIUI();
            }
            return instance;
        }


        //Some Basic Console Helper Functions for testing EFcore and the logic of the App.
        public Task< bool> ContextChoose()
        {

            string? input = Console.ReadLine()?.Trim().ToLower();
            var stringInput = 0;
            bool canParse = int.TryParse(input, out stringInput);

            if (stringInput == 1)
            {
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
        
        public async Task  WriteInput(string input)
        {
            var textToDisplay = input.Trim();
             Console.WriteLine(textToDisplay);
            await Task.Delay(1000);
        }
        public Task<string> GetInput(string input)
        {
            var stringInput = input.Trim().ToLower();

            return Task.FromResult( stringInput);
        }
        public int GetInputInteger()
        {
            string? input = Console.ReadLine()?.Trim().ToLower();
            var stringInput = 0;
            bool canParse = int.TryParse(input,out stringInput);
            

            return stringInput;
        }
        public float GetFloatInput()
        {
            string? input = Console.ReadLine()?.Trim().ToLower();
            var stringInput = 0f;
            bool canParse = float.TryParse(input, out stringInput);


            return stringInput;
        }
        public double GetDouble()
        {
            string? input = Console.ReadLine()?.Trim().ToLower();
            var stringInput = 0d;
            bool canParse = double.TryParse(input, out stringInput);


            return stringInput;
        }
    }
}
