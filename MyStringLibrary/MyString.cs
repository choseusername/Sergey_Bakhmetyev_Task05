using System;

namespace MyStringLibrary
{
    /*
     * class MyString, which describes a string as an array of characters
     */
    public class MyString
    {
        // String as an array of characters
        private char[] data;
        // The terminating zero is not included in the length.
        public int Length => data.Length;

        public override string ToString()
        {
            return new string(data);
        }

        // Compares two MyString objects.
        public static bool operator ==(MyString a, MyString b)
        {
            return MyString.Equals(a, b);
        }

        public static bool operator !=(MyString a, MyString b)
        {
            return !MyString.Equals(a, b);
        }

        // Removes a substring from the current string.
        public static MyString operator -(MyString a, MyString b)
        {
            return new MyString(a.ToString().Replace(b.ToString(), "").ToCharArray());
        }

        // Adds a line to the end of the current one.
        public static MyString operator +(MyString a, MyString b)
        {
            // allocate an array for new string
            char[] newString = new char[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
                newString[i] = a.data[i];

            for (int i = 0; i < b.Length; i++)
                newString[a.Length + i] = b.data[i];

            return new MyString(newString);
        }

        // Compares two MyString objects.
        public override bool Equals(Object obj)
        {
            if (this == null)
                throw new NullReferenceException();

            MyString str = obj as MyString;
            if (str == null)
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (this.Length != str.Length)
                return false;

            for (int i = 0; i < this.Length; ++i)
                if (this.data[i] != str.data[i])
                    return false;
            return true;
        }

        public MyString(string str)
        {
            data = str.ToCharArray();
        }

        public MyString(char[] charArray)
        {
            data = charArray;
        }
    }
}
