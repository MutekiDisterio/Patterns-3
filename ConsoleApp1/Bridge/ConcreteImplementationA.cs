namespace DesignPatterns.Bridge
{
    class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: Result on platform A.";
        }
    }
}
