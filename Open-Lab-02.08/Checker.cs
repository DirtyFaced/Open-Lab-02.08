using System;

namespace Open_Lab_02._08
{
    public class Checker
    {
        public bool IsEmpty(string str)
        {
            bool mama = false;
            if (str == "")
                { mama = true; };
            return mama;
        }
    }
}
