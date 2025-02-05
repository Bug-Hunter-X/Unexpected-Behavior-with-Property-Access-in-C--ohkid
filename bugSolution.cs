public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Access the property only once and store the value in a local variable.
        int x = MyProperty;
        x = x + 1;
        MyProperty = x; //Modifying the property
    }
}