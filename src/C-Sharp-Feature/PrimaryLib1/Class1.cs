

namespace Demo1
{
    public class Class1
    {
        private IClass _class;
        public Class1(IClass @class)
        {
            _class= @class;
        }
        
        public void DoSomething()
        {
            
            int x = 1000;
            _class.Print(x);
        }



    }
}